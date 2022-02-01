using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionFadeev
{
    class GetbdClass
    {
        public String conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev;Persist Security Info=True;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlDataReader dr;

        public GetbdClass()
        {
            connection = new SqlConnection(conStr);
        }

        public int GetUserRole(string userEmail)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT RoleId FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", userEmail);
                int i = Convert.ToInt32(com.ExecuteScalar());
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public TimeSpan GetUserTimeInSystem(string email)
        {
            TimeSpan time = new TimeSpan();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT UserFullTimeInSystem FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", email);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    time = TimeSpan.Parse(dr["UserFullTimeInSystem"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return time;
        }

        internal void IncrementCrashes(string emailAddress)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand com = new SqlCommand($"SELECT NumberOfCrashes FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", emailAddress);
                int crashes = Convert.ToInt32(com.ExecuteScalar());

                crashes++;

                SqlCommand cmd = new SqlCommand($"UPDATE Users SET NumberOfCrashes=@NumberOfCrashes WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("NumberOfCrashes", crashes);
                com.Parameters.AddWithValue("Email", emailAddress);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateUserTimeInSystem(TimeSpan pitime, string email)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"UPDATE Users SET UserFullTimeInSystem=@UserFullTimeInSystem WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("UserFullTimeInSystem", pitime);
                com.Parameters.AddWithValue("Email", email);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertUActivity(UActivity uActivity)
        {
            try
            {
                connection.Open();

                SqlCommand com = new SqlCommand($"INSERT INTO Logout" + $"(User_ID, Login_Time, Logout_Time, Logout_Rizon, FullTimeInSession)" +
                    $" VALUES(@User_ID, @Login_Time, @Logout_Time, @Logout_Rizon, @FullTimeInSession) ", connection);

                com.Parameters.AddWithValue("User_ID", uActivity.UserID);
                com.Parameters.AddWithValue("Login_Time", uActivity.LoginTime);
                com.Parameters.AddWithValue("Logout_Time", uActivity.LogoutTime);
                com.Parameters.AddWithValue("Logout_Rizon", uActivity.LogoutRizon);
                com.Parameters.AddWithValue("FullTimeInSession", uActivity.TimeInSystem);

                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        public List<OfficeClass> GetUsers()
        {
            List<OfficeClass> users = new List<OfficeClass>();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT * FROM Users", connection);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    int active = Convert.ToInt32(dr["Active"]);
                    int roleId = Convert.ToInt32(dr["RoleId"]);
                    int id = Convert.ToInt32(dr["ID"]);
                    string TimeInSystem = dr["UserFullTimeInSystem"].ToString();
                    int numberOfCrashes = Convert.ToInt32(dr["NumberOfCrashes"]);

                    OfficeClass user = new OfficeClass(active, roleId);

                    user.ID = id;

                    user.Name = dr["FirstName"].ToString();

                    user.LastName = dr["LastName"].ToString();

                    int birthday = Convert.ToDateTime(dr["Birthdate"]).Year;
                    user.Age = DateTime.Now.Year - birthday;

                    user.UserRole = roleId == 1 ? "Администратор" : "Сотрудник";

                    user.EmailAddress = dr["Email"].ToString();

                    int officeId = Convert.ToInt32(dr["OfficeID"]);
                    if (officeId == 1)
                    {
                        user.Office = user.offices[officeId - 1];
                    }
                    else
                    {
                        user.Office = user.offices[officeId - 2];
                    }
                    user.Active = active == 1 ? true : false;

                    if (TimeInSystem != "00:00:00")
                    {
                        user.FullTimeInSystem = TimeSpan.Parse(TimeInSystem);
                    }

                    user.NumberOfCrashes = numberOfCrashes;

                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return users;
        }

        internal void ChangeUserRole(string emailAddress, int roleId)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand com = new SqlCommand($"UPDATE Users SET RoleId=@RoleId WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("RoleId", roleId);
                com.Parameters.AddWithValue("Email", emailAddress);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ChangeActiveStatus(int active, string userEmail)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"UPDATE Users SET Active=@Active WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Active", active);
                com.Parameters.AddWithValue("Email", userEmail);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public bool Login(string userEmail, string userPassword)
        {
            AutorizationForm log = new AutorizationForm();
            string password = log.GetHash(userPassword);
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT count(*) FROM Users WHERE Email=@Email AND Password=@Password", connection);
                com.Parameters.AddWithValue("Email", userEmail);
                com.Parameters.AddWithValue("Password", password);
                int i = Convert.ToInt32(com.ExecuteScalar());
                if (i == 0)
                {
                    MessageBox.Show("Пользователь не найден");
                    return false;
                }
                if (i == 1)
                {
                    if (CheckActiveUser(userEmail))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь заблокирован администратором.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        private bool CheckActiveUser(string userEmail)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand com = new SqlCommand($"SELECT Active FROM Users WHERE Email=@Email", connection);
            com.Parameters.AddWithValue("Email", userEmail);
            int active = Convert.ToInt32(com.ExecuteScalar());
            if (active == 1)
            {
                return true;
            }
            return false;
        }

        public List<UActivity> GetUserActivities()
        {
            List<UActivity> activities = new List<UActivity>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT * FROM Logout", connection);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    int userId = Convert.ToInt32(dr["User_ID"]);
                    string loginTime = dr["Login_Time"].ToString();
                    string logoutTime = dr["Logout_Time"].ToString();
                    string timeSpentOnSystem = dr["FullTimeInSession"].ToString();
                    string logoutReason = dr["Logout_Rizon"].ToString();

                    UActivity activity = new UActivity();
                    activity.UserID = userId;
                    activity.LoginTime = TimeSpan.Parse(loginTime);
                    activity.LogoutTime = TimeSpan.Parse(logoutTime);
                    activity.TimeInSystem = TimeSpan.Parse(timeSpentOnSystem);
                    activity.LogoutRizon = logoutReason;

                    activities.Add(activity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return activities;
        }
    }


}




