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
    
    public partial class AdminForm : Form, Requestor
    {
        public String conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev;Persist Security Info=True;User ID=sa;Password=123456";
        private bool formCanBeChanged = false;
        public SqlDataReader dr;
        OfficeClass user = new OfficeClass();
        public List<OfficeClass> userlist;
        GetbdClass getD = new GetbdClass();

        public UActivity UActivity { get; set; }
        public OfficeClass CurrentUser { get; set; }
        public AdminForm(OfficeClass user, UActivity uActivity)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(user.offices);
            comboBox1.SelectedIndex = 0;
            userlist = getD.GetUsers();
            AddColumns();
            SetDataGrid(userlist);

            UActivity = uActivity;
            CurrentUser = user;
        }
        public void SetDataGrid(List<OfficeClass> usersForAdd)
        {
            foreach (var i in usersForAdd)
            {
                dataGridView1.Rows.Add(i.Name, i.LastName, i.Age, i.UserRole, i.EmailAddress, i.Office);
                dataGridView1.Rows[usersForAdd.IndexOf(i)].DefaultCellStyle.BackColor = i.ColorInDg;
            }
        }


        public void AddColumns()
        {
            dataGridView1.Columns.Add("Column1", "Name");
            dataGridView1.Columns.Add("Column2", "LastName");
            dataGridView1.Columns.Add("Column3", "Age");
            dataGridView1.Columns.Add("Column4", "User Role");
            dataGridView1.Columns.Add("Column5", "Email Address");
            dataGridView1.Columns.Add("Column6", "Office");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autoform = new AutorizationForm();
            autoform.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(this);
            this.Enabled = false;
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formCanBeChanged)
            {
                dataGridView1.Rows.Clear();
                if (comboBox1.SelectedIndex == 0)
                {
                    SetDataGrid(userlist);
                }
                List<OfficeClass> filteredUser = userlist.Where(item => item.Office == comboBox1.SelectedItem.ToString()).ToList();
                SetDataGrid(filteredUser);
            }
        }

        private void AdminForm_Shown(object sender, EventArgs e)
        {
            formCanBeChanged = true;
        }

        private void activebutt_Click(object sender, EventArgs e)
        {
            string userEmail = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            bool status = userlist.FirstOrDefault(x => x.EmailAddress == userEmail).Active;

            int active = status == true ? 0 : 1;

            getD.ChangeActiveStatus(active, userEmail);

            userlist = getD.GetUsers();
            dataGridView1.Rows.Clear();
            AddToDataGrid(userlist);
        }

        private void AddToDataGrid(List<OfficeClass> userlist)
        {
            foreach (var i in userlist)
            {
                dataGridView1.Rows.Add(i.Name, i.LastName, i.Age, i.UserRole, i.EmailAddress, i.Office);
                dataGridView1.Rows[userlist.IndexOf(i)].DefaultCellStyle.BackColor = i.ColorInDg;
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Manager.UserLogout(CurrentUser, UActivity, e.CloseReason.ToString());
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OfficeClass userForChange = userlist.FirstOrDefault(item => item.EmailAddress == dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            RoleForm roleform = new RoleForm(userForChange, this);
            this.Enabled = false;
            roleform.Show();
        }

        public void Block()
        {
            this.Enabled = true;
            userlist = getD.GetUsers();
            dataGridView1.Rows.Clear();
            AddToDataGrid(userlist);
        }

        private void FligthManeger_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageFlightSchedulesForm managerFSForm = new ManageFlightSchedulesForm();
            managerFSForm.Show();
        }
    }
}
