using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace CTU__Class_Attendance_Monitoring_System
{
    public partial class Mainform : Form
    {
        MySqlConnection conn;
        dbconnection dbconnection = new dbconnection();
        int searchid;
        string checkDataQuery = $"SELECT COUNT(*) FROM bscpe_attendance WHERE student_id = @searchid";
        string columnName = DateTime.Now.ToString("MM_dd_yy");

        public Mainform()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconnection.dbconnect());
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            datestart.Start();
        }

        //for the running clock
        private void datestart_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd , MMMM dd yyyy , hh:mm:ss tt");
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idnumber_txtbox.Text))
            {
                MessageBox.Show("Please input your ID number first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (idnumber_txtbox.Text.Length != 7)
            {
                MessageBox.Show("Please input a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idnumber_txtbox.Text = string.Empty;
                return;
            }
            else
            {
                string tableName = "bscpe_attendance";
                string columnName = DateTime.Now.ToString("MM_dd_yy");

                using (MySqlConnection conn = new MySqlConnection(dbconnection.dbconnect()))
                {
                    try
                    {
                        conn.Open();

                        // Check if the column exists in the table
                        string checkColumnQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' AND COLUMN_NAME = '{columnName}'";

                        using (MySqlCommand checkColumnCommand = new MySqlCommand(checkColumnQuery, conn))
                        {
                            int columnCount = Convert.ToInt32(checkColumnCommand.ExecuteScalar());

                            if (columnCount > 0)
                            {
                                // Column already exists
                                //MessageBox.Show($"Column '{columnName}' already exists in table '{tableName}'.");
                            }
                            else
                            {
                                // Column doesn't exist, create a new column
                                string addColumnQuery = $"ALTER TABLE `{tableName}` ADD COLUMN `{columnName}` BOOL";

                                using (MySqlCommand addColumnCommand = new MySqlCommand(addColumnQuery, conn))
                                {
                                    addColumnCommand.ExecuteNonQuery();
                                    // MessageBox.Show($"New column '{columnName}' created in table '{tableName}'.");
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    searchid = Convert.ToInt32(idnumber_txtbox.Text);
                    //conn.Open();
                    string selectQuery = $"SELECT COUNT(*) FROM bscpe_attendance WHERE student_id = @searchid";
                    string date = DateTime.Now.ToString("MM_dd_yy");
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn))
                    {
                        selectCommand.Parameters.AddWithValue("@searchid", searchid);

                        int rowCount = Convert.ToInt32(selectCommand.ExecuteScalar());
                        if (rowCount > 0)
                        {
                            //if row exists, logs attendance, updates to true
                            string updateQuery = $"UPDATE bscpe_attendance SET {date} = true WHERE student_id = @searchid";

                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                            {
                                updateCommand.Parameters.AddWithValue("@updateValue", true);
                                updateCommand.Parameters.AddWithValue("@searchid", searchid);

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                MessageBox.Show($"Attendance Recorded for {searchid}.", idnumber_txtbox.Text);
                            }
                            idnumber_txtbox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("ID number not registered.");
                            conn.Close();
                            return;
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void idnumber_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //make sure that textbox only takes numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(idnumber_txtbox.Text))
            {
                MessageBox.Show("Please input your ID number first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (idnumber_txtbox.Text.Length != 7)
            {
                MessageBox.Show("Please input a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idnumber_txtbox.Text = string.Empty;
                return;
            }
            else
            {
                searchid = Convert.ToInt32(idnumber_txtbox.Text);
                using (MySqlCommand checkDataCommand = new MySqlCommand(checkDataQuery, conn))
                {
                    conn.Open();
                    checkDataCommand.Parameters.AddWithValue("@searchid", searchid);

                    int rowCount = Convert.ToInt32(checkDataCommand.ExecuteScalar());

                    if (rowCount > 0)
                    {
                        MessageBox.Show("ID number already registered!");
                        conn.Close();
                        return;
                    }
                    else
                    {
                        register_form register_Form = new register_form();
                        register_Form.idnumber = idnumber_txtbox.Text;
                        register_Form.Show();
                        this.Hide();
                    }
                    conn.Close();
                }
            }
        }

        private void attendancetbl_btn_Click(object sender, EventArgs e)
        {
            attendancetable_form attendancetable_Form = new attendancetable_form();
            attendancetable_Form.Show();
            this.Hide();
        }
    }
}