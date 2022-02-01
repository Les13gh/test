using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionFadeev
{
    public partial class UserForm : Form
    {
        private List<UActivity> activities;

        GetbdClass getD = new GetbdClass();
        public OfficeClass CurrentUser { get; set; }
        public UActivity UActivity { get; set; }
        public UserForm(OfficeClass user, UActivity uActivity)
        {
            InitializeComponent();
            CurrentUser = user;
            UActivity = uActivity;
            activities = getD.GetUserActivities();
            label1.Text = $"Hi, {CurrentUser.Name}, welcome to AMONIC Airlines";
            label2.Text = $"time spent on system: {CurrentUser.FullTimeInSystem}";
            label3.Text = $"number of crashes: {CurrentUser.NumberOfCrashes}";
            dataGridView1.DataSource = activities.Where(item => item.UserID == CurrentUser.ID).ToList();
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.UserLogout(CurrentUser, UActivity, "UserClosing");
            this.Hide();
            AutorizationForm autoform = new AutorizationForm();
            autoform.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.UserLogout(CurrentUser, UActivity, e.CloseReason.ToString());
            Application.Exit();
        }
    }
}
