namespace CTU__Class_Attendance_Monitoring_System
{
    partial class attendancetable_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendancetable_form));
            panel1 = new Panel();
            status_lbl = new Label();
            chk_status_btn = new Button();
            searchid_txtbox = new TextBox();
            pictureBox1 = new PictureBox();
            back_btn = new Button();
            panel2 = new Panel();
            attendance_tbl = new DataGridView();
            export_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendance_tbl).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 185, 0);
            panel1.Controls.Add(status_lbl);
            panel1.Controls.Add(chk_status_btn);
            panel1.Controls.Add(searchid_txtbox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(back_btn);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 98);
            panel1.TabIndex = 0;
            // 
            // status_lbl
            // 
            status_lbl.AutoSize = true;
            status_lbl.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            status_lbl.Location = new Point(662, 74);
            status_lbl.Name = "status_lbl";
            status_lbl.Size = new Size(11, 14);
            status_lbl.TabIndex = 4;
            status_lbl.Text = "-";
            // 
            // chk_status_btn
            // 
            chk_status_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chk_status_btn.Location = new Point(689, 40);
            chk_status_btn.Name = "chk_status_btn";
            chk_status_btn.Size = new Size(100, 23);
            chk_status_btn.TabIndex = 3;
            chk_status_btn.Text = "Check Status";
            chk_status_btn.UseVisualStyleBackColor = true;
            chk_status_btn.Click += chk_status_btn_Click;
            // 
            // searchid_txtbox
            // 
            searchid_txtbox.Location = new Point(484, 40);
            searchid_txtbox.Name = "searchid_txtbox";
            searchid_txtbox.Size = new Size(199, 23);
            searchid_txtbox.TabIndex = 2;
            searchid_txtbox.KeyPress += searchid_txtbox_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // back_btn
            // 
            back_btn.FlatStyle = FlatStyle.System;
            back_btn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.ForeColor = Color.Blue;
            back_btn.Location = new Point(3, 16);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(29, 28);
            back_btn.TabIndex = 0;
            back_btn.Text = "<";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(-1, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 10);
            panel2.TabIndex = 1;
            // 
            // attendance_tbl
            // 
            attendance_tbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendance_tbl.Location = new Point(12, 113);
            attendance_tbl.Name = "attendance_tbl";
            attendance_tbl.RowTemplate.Height = 25;
            attendance_tbl.Size = new Size(776, 318);
            attendance_tbl.TabIndex = 2;
            // 
            // export_btn
            // 
            export_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            export_btn.Location = new Point(699, 437);
            export_btn.Name = "export_btn";
            export_btn.Size = new Size(89, 23);
            export_btn.TabIndex = 3;
            export_btn.Text = "Export to PDF";
            export_btn.UseVisualStyleBackColor = true;
            export_btn.Click += export_btn_Click;
            // 
            // attendancetable_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(export_btn);
            Controls.Add(attendance_tbl);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "attendancetable_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += attendancetable_form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendance_tbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label status_lbl;
        private Button chk_status_btn;
        private TextBox searchid_txtbox;
        private PictureBox pictureBox1;
        private Button back_btn;
        private Panel panel2;
        private DataGridView attendance_tbl;
        private Button export_btn;
    }
}