using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionFadeev
{

    public partial class AddUserForm : Form
    {
        public String conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev;Persist Security Info=True;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlCommand cmd;
        AutorizationForm auto = new AutorizationForm();
        bool act = true;
        private readonly Requestor form;
        public AddUserForm(Requestor form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Cancelbutt_Click(object sender, EventArgs e)
        {
            form.Block();
            this.Close();
        }

        private void Savebutt_Click(object sender, EventArgs e)
        {
            String password = pass.Text;
            password = auto.GetHash(password);
            connection = new SqlConnection(conStr);
            string userfulltimeinsystem = "00:00:00";
            string crashes = "0";
            try
            {
                connection.Open();
                cmd = new SqlCommand(String.Format("INSERT INTO [Users] (RoleID, Email, Password, FirstName, LastName, OfficeID, Birthdate , Active, UserFullTimeInSystem, NumberOfCrashes) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", 2, Email.Text, password, FirstNam.Text, LastName.Text, Office.Text, BD.Text, act, userfulltimeinsystem, crashes), connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь успешно добавлен! ");
                form.Block();
                this.Close();

            }
            catch(Exception ex)
            {   
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Email.Text = "";
        }

        private void Office_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
