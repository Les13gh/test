using Microsoft.VisualBasic.FileIO;
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
    public partial class ApplyScheduleForm : Form
    {
        public string conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev2;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlCommand cmd;

        public ApplyScheduleForm()
        {
            InitializeComponent();
        }

        private void importbutton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "schedule Files|*.csv";
            dialog.Title = "Выберите график билета: ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != null)
                {
                    importbox.Text = dialog.FileName;

                    using (TextFieldParser parser = new TextFieldParser(dialog.FileName))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();
                            foreach (string field in fields)
                            {
                                MessageBox.Show(field);
                            }
                        }
                    }
                }
            }

        }
    }
}
