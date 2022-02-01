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
    public partial class ScheduleEditForm : Form
    {
        public string conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev2;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlCommand cmd;

        int userID = 0;
        public ScheduleEditForm(string id, string from, string to, string aircraft, string date, string time, string price)
        {
            InitializeComponent();
            userID = Convert.ToInt32(id);

            FromLabel.Text = "From: " + from;
            ToLabel.Text = "To: " + to;
            Airlabel.Text = "Aircraft: " + aircraft;
            datebox.Text = date;
            Timebox.Text = time;
            Pricebox.Text = price;
        }

        private void cancelbutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Pricebox.Text.Length > 0)
            {
                connection = new SqlConnection(conStr);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand(String.Format("UPDATE Schedules SET Date='{0}', Time='{1}', EconomyPrice='{2}' WHERE ID={3}", datebox.Text, Timebox.Text, Pricebox.Text, userID), connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                (Application.OpenForms["SchedulePanel"] as ManageFlightSchedulesForm).UpdateGridSchedules();
                this.Close();
            }
            else MessageBox.Show("Необходимо заполнить ВСЕ поля");
        }
    }
}
