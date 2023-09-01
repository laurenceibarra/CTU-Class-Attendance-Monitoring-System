using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTU__Class_Attendance_Monitoring_System
{
    public partial class register_form : Form
    {
        MySqlConnection conn;
        dbconnection dbconnection = new dbconnection();
        MySqlCommand command;
        string searchName;
        string checkDataQuery = $"SELECT COUNT(*) FROM bscpe_attendance WHERE name = @searchName";
        string studentName;
        public string idnumber { get; set; }

        public register_form()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconnection.dbconnect());
        }

        private void register_form_Load(object sender, EventArgs e)
        {
            //gets id number from the textbox from Mainform
            id_number_lbl.Text = idnumber;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            studentName = string.Format("{0}, {1}",lastname_txtbox.Text,firstname_txtbox.Text);

            if (string.IsNullOrEmpty(firstname_txtbox.Text) || string.IsNullOrEmpty(lastname_txtbox.Text))
            {
                MessageBox.Show("Name cannot be blank!", "Error");
                return;
            }
            else
            {
                conn.Open();
                using (MySqlCommand checkDataCommand = new MySqlCommand(checkDataQuery, conn))
                {
                    
                    searchName = studentName;
                    checkDataCommand.Parameters.AddWithValue("@searchName", searchName);

                    int rowCount = Convert.ToInt32(checkDataCommand.ExecuteScalar());

                    if (rowCount > 0)
                    {
                        MessageBox.Show("Name already registered by another ID number!");
                        firstname_txtbox.Clear();
                        lastname_txtbox.Clear();
                        conn.Close();
                        return;
                    }
                    else
                    {
                        command = new MySqlCommand("INSERT INTO `bscpe_attendance` (`student_id`,`name`) VALUES (@student_id, @name)", conn);
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@name", studentName);
                        command.Parameters.AddWithValue("@student_id", id_number_lbl.Text);

                        int rowsaffected = command.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("ID number registered successfully!", "Success");
                        Mainform mainform = new Mainform();
                        mainform.Show();
                        this.Close();
                    }
                    conn.Close();
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Close();
        }
    }
}
