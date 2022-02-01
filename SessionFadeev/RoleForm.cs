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
    public partial class RoleForm : Form
    {
        public OfficeClass UserForChange { get; set; }

        private GetbdClass db = new GetbdClass();

        private bool roleChanged = false;

        private int i = 0;

        private readonly Requestor form;
        public RoleForm(OfficeClass userForChange, Requestor form)
        {
            InitializeComponent();
            UserForChange = userForChange;
            this.form = form;
            SetComboBox();
        }
        private void SetComboBox()
        {
            emailbox.Text = UserForChange.EmailAddress;
            FNbox.Text = UserForChange.Name;
            LNbox.Text = UserForChange.LastName;
            ofbox.Items.Add(UserForChange.Office);
            ofbox.SelectedIndex = 0;

            emailbox.Enabled = false;
            FNbox.Enabled = false;
            LNbox.Enabled = false;
            ofbox.Enabled = false;

            if (UserForChange.UserRole == "Администратор")
            {
                Admbox.Checked = true;
            }
            else userbox.Checked = true;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            form.Block();
            this.Close();
        }

        private void userbox_CheckedChanged(object sender, EventArgs e)
        {
            if (i > 0)
            {
                roleChanged = true;
            }
            i++;
        }

        private void Admbox_CheckedChanged(object sender, EventArgs e)
        {
            if (i > 0)
            {
                roleChanged = true;
            }
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roleChanged)
            {
                int roleId = UserForChange.UserRole == "Сотрудник" ? 1 : 2;
                db.ChangeUserRole(UserForChange.EmailAddress, roleId);
            }
            form.Block();
            this.Close();


        }

        private void RoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Block();
        }
    }
}
