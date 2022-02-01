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
    public partial class ManageFlightSchedulesForm : Form
    {
        public string conStr = @"Data Source=DESKTOP-EA6F6S7\XIAOMIALEH;Initial Catalog=Session_Fadeev2;User ID=sa;Password=123456";
        private SqlConnection connection;
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader ExecuteReader;

        private bool DateFlightChanged = false;
        public ManageFlightSchedulesForm()
        {
            InitializeComponent();
            UpdateGridSchedules();
        }
        public void UpdateGridSchedules()
        {
            connection = new SqlConnection(conStr);
            try
            {
                connection.Open();

                ds = new DataSet();
                SqlDataAdapter DAShedule = new SqlDataAdapter("SELECT Schedules.Date AS 'Date', Schedules.Time AS 'Time', (SELECT IATACode FROM Airports WHERE ID = Routes.DepartureAirportID) AS 'From', (SELECT IATACode FROM Airports WHERE ID = Routes.ArrivalAirportID) AS 'To', Schedules.FlightNumber AS 'Flight number', Aircrafts.Name AS 'Aircraft', CAST(Schedules.EconomyPrice AS int) AS 'Economy price', FLOOR(Schedules.EconomyPrice+(Schedules.EconomyPrice*0.35)) AS 'Business price', FLOOR(Schedules.EconomyPrice+(Schedules.EconomyPrice*0.30)) AS 'First class price', Schedules.Confirmed, Schedules.ID FROM Schedules INNER JOIN Aircrafts ON Schedules.AircraftID = Aircrafts.ID INNER JOIN Routes ON Schedules.RouteID = Routes.ID", connection);
                DAShedule.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[9].Value.ToString() == "False") row.DefaultCellStyle.BackColor = Color.Red;
                    else row.DefaultCellStyle.BackColor = Color.White;
                }

                DataSet DSFrom = new DataSet();
                SqlDataAdapter DAFrom = new SqlDataAdapter("SELECT IATACode FROM Airports", connection);
                DAFrom.Fill(DSFrom);
                DSFrom.Tables[0].Rows.Add("");

                DataSet DSTo = new DataSet();
                SqlDataAdapter DATo = new SqlDataAdapter("SELECT IATACode FROM Airports", connection);
                DATo.Fill(DSTo);
                DSTo.Tables[0].Rows.Add("");

                Frombox.DataSource = DSFrom.Tables[0];
                Frombox.DisplayMember = "IATACode";
                Frombox.ValueMember = "IATACode";

                Tobox.DataSource = DSTo.Tables[0];
                Tobox.DisplayMember = "IATACode";
                Tobox.ValueMember = "IATACode";

                Frombox.SelectedIndex = Frombox.Items.Count - 1;
                Tobox.SelectedIndex = Tobox.Items.Count - 1;

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
       

        private void Applybutt_Click(object sender, EventArgs e)
        {
            int FilterCounter = 0;
            if (Frombox.SelectedValue.ToString().Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("From = '{0}'", Frombox.SelectedValue.ToString());
            else FilterCounter++;
            if (Frombox.SelectedValue.ToString().Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("To = '{0}'", Tobox.SelectedValue.ToString());
            else FilterCounter++;
            if (FNum.Text.Length > 0) (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Flight number = '{0}'", FNum.Text);
            else FilterCounter++;
            if (datebox.Text != "") (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date = '{0}'", datebox.Text);
            else FilterCounter++;
            if (FilterCounter == 4 && datebox.Text == "") (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;

            switch (Sortby.SelectedIndex)
            {
                case 0:
                   dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Descending);
                    break;
                case 1:
                    dataGridView1.Sort(dataGridView1.Columns["Date"], ListSortDirection.Ascending);
                    break;
                case 2:
                    dataGridView1.Sort(dataGridView1.Columns["Economy price"], ListSortDirection.Ascending);
                    break;
                case 3:
                    dataGridView1.Sort(dataGridView1.Columns["Confirmed"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void CancelFbutt_Click(object sender, EventArgs e)
        {
            string TempFlightActive = "";
            if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "True") TempFlightActive = "False";
            else TempFlightActive = "True";

            connection = new SqlConnection(conStr);
            try
            {
                connection.Open();
                cmd = new SqlCommand(String.Format("UPDATE Schedules SET Confirmed='{0}' WHERE ID='{1}'", TempFlightActive, dataGridView1.SelectedRows[0].Cells[10].Value), connection);
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
            UpdateGridSchedules(); 
        }

        private void EditFbutt_Click(object sender, EventArgs e)
        {
            ScheduleEditForm scheduleEditForm = new ScheduleEditForm(dataGridView1.CurrentRow.Cells[10].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString());
            scheduleEditForm.Show();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ApplyScheduleForm ImportScheduleForm = new ApplyScheduleForm();
            ImportScheduleForm.Show();
        }
    }
}
