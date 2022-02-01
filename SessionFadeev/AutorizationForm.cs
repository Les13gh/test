using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionFadeev
{
    public partial class AutorizationForm : Form
    {
        public String conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev;Persist Security Info=True;User ID=sa;Password=123456";

        private SqlConnection connection;
        GetbdClass getD = new GetbdClass();
        int s = 10;
        int x = 0;
        private int uncorrectLoginTimes;
        public AutorizationForm()
        {
            InitializeComponent();
        }
      
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string pass = Convert.ToBase64String(hash);
            return pass;
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                loginbutt.Enabled = true;
                label3.Visible = false;
                s = 10;
                x = 0;
                return;
            }
            label3.Text = $"{s--}";
        }
        private int FindRole(string userEmail)
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
        private void loginbutt_Click(object sender, EventArgs e)
        {
            MethodSaa(emailbox.Text, pass.Text);
        }

        public void MethodSaa(string login, string password)
        {
            if (getD.Login(login, password))
            {
                Form form = new Form();
                int role = getD.GetUserRole(login);
                OfficeClass currentUser = getD.GetUsers().FirstOrDefault(x => x.EmailAddress == login);
                UActivity activity = new UActivity();
                activity.LoginTime = DateTime.Now.TimeOfDay;
                activity.UserID = currentUser.ID;
                if (role == 1)
                {
                    form = new AdminForm(currentUser, activity);
                }
                if (role == 2)
                {
                    form = new UserForm(currentUser, activity);
                }
                this.Hide();
                form.Show();
            }
            else
            {
                uncorrectLoginTimes++;
                if (uncorrectLoginTimes > 3)
                {
                    uncorrectLoginTimes = 0;
                    label3.Visible = true;
                    loginbutt.Enabled = false;
                    timer1.Enabled = true;
                    timer1.Start();
                }

            }
        }


        private void exitbutt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Close();
        }
    }
}
