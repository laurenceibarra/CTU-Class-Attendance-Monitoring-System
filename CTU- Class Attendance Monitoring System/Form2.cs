using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CTU__Class_Attendance_Monitoring_System
{
    public partial class attendancetable_form : Form
    {
        MySqlConnection conn;
        dbconnection dbconnection = new dbconnection();
        public attendancetable_form()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconnection.dbconnect());
        }

        private void chk_status_btn_Click(object sender, EventArgs e)
        {
            if (searchid_txtbox.Text.Length != 7)
            {
                MessageBox.Show("Please input a valid ID number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                searchid_txtbox.Text = string.Empty;
                return;
            }
            else
            {
                string searchid = searchid_txtbox.Text;
                string columnName = "student_id";
                foreach (DataGridViewRow row in attendance_tbl.Rows)
                {
                    if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString().Contains(searchid))
                    {
                        // Select the row
                        row.Selected = true;
                        attendance_tbl.CurrentCell = row.Cells[columnName];

                        if (attendance_tbl.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = attendance_tbl.SelectedRows[0];
                        }
                    }
                }

                int absences = 0;
                if (attendance_tbl.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = attendance_tbl.SelectedCells[0].OwningRow;

                    for (int columnIndex = 2; columnIndex < selectedRow.Cells.Count; columnIndex++)
                    {
                        DataGridViewCell cell = selectedRow.Cells[columnIndex];

                        //if cell is null, absences is counted
                        if (cell.Value == DBNull.Value)
                        {
                            absences++;
                        }

                    }
                }

                if (absences == 0)
                {
                    status_lbl.Text = "Perfect Attendance";
                }
                else if(absences == 1)
                {
                    status_lbl.Text = $"{absences} absence";
                }
                else
                {
                    status_lbl.Text = $"{absences} absences";
                }
            }

        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            // Add a new column "Absences" to the DataGridView
            DataGridViewTextBoxColumn absencesColumn = new DataGridViewTextBoxColumn();
            absencesColumn.Name = "Absences";
            absencesColumn.HeaderText = "Absences";
            attendance_tbl.Columns.Add(absencesColumn);

            // Iterate over each row and count the null values in columns starting from the 3rd column
            foreach (DataGridViewRow row in attendance_tbl.Rows)
            {
                int absencesCount = 0;
                for (int col = 2; col < attendance_tbl.Columns.Count; col++) // Start from the 3rd column
                {
                    if (row.Cells[col].Value == DBNull.Value)
                    {
                        absencesCount++;
                    }
                }
                // Set the count of null values in the "Absences" column for the current row
                row.Cells["Absences"].Value = absencesCount;
            }

            // Export the modified DataGridView to PDF using the existing code

            // Create a new save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.FileName = "attendance.pdf";

            // Show the save file dialog and check if the user clicked the "Save" button
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create a new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    // Open the PDF document for writing
                    document.Open();

                    // Add a new table to the document
                    PdfPTable table = new PdfPTable(attendance_tbl.Columns.Count);
                    table.WidthPercentage = 100;

                    // Add the column headers to the table
                    foreach (DataGridViewColumn column in attendance_tbl.Columns)
                    {
                        table.AddCell(column.HeaderText);
                    }

                    // Add the rows and cells to the table
                    foreach (DataGridViewRow dgvRow in attendance_tbl.Rows)
                    {
                        foreach (DataGridViewCell cell in dgvRow.Cells)
                        {
                            string cellValue = cell.Value?.ToString() ?? string.Empty;
                            if (cellValue == "True")
                            {
                                cellValue = "Present"; // Change "True" to "Present"
                            }
                            else if (string.IsNullOrEmpty(cellValue))
                            {
                                cellValue = "Absent";
                            }
                            table.AddCell(cellValue);
                        }
                    }

                    // Add the table to the document
                    document.Add(table);

                    // Close the PDF document
                    document.Close();

                    // Show a success message to the user
                    MessageBox.Show("Attendance exported to PDF successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Show an error message to the user
                    MessageBox.Show("Error exporting attendance to PDF: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Remove the "Absences" column from the DataGridView after exporting
            attendance_tbl.Columns.Remove("Absences");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Mainform mainform = new Mainform();
            mainform.Show();
            this.Close();
        }

        private void attendancetable_form_Load(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuery = $"SELECT * FROM bscpe_attendance";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                attendance_tbl.DataSource = dataTable;
                attendance_tbl.ReadOnly = true;
                attendance_tbl.AllowUserToAddRows = false;
                attendance_tbl.AllowUserToDeleteRows = false;

                attendance_tbl.Columns[0].HeaderText = "ID number";
                attendance_tbl.Columns[1].HeaderText = "Name";
            }
            conn.Close();
        }

        private void searchid_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
