namespace CTU__Class_Attendance_Monitoring_System
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            datestart = new System.Windows.Forms.Timer(components);
            date = new Label();
            label1 = new Label();
            idnumber_txtbox = new TextBox();
            login_btn = new Button();
            register_btn = new Button();
            attendancetbl_btn = new Button();
            close_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 185, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-7, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 238);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Location = new Point(226, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 234);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-74, -38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(389, 305);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(227, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // datestart
            // 
            datestart.Tick += datestart_Tick;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(227, 70);
            date.Name = "date";
            date.Size = new Size(354, 26);
            date.TabIndex = 2;
            date.Text = "dddd , MMMM dd yyyy , hh:mm:ss";
            date.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(382, 105);
            label1.Name = "label1";
            label1.Size = new Size(98, 14);
            label1.TabIndex = 3;
            label1.Text = "Enter Id number:";
            // 
            // idnumber_txtbox
            // 
            idnumber_txtbox.Location = new Point(333, 122);
            idnumber_txtbox.Name = "idnumber_txtbox";
            idnumber_txtbox.Size = new Size(204, 23);
            idnumber_txtbox.TabIndex = 4;
            idnumber_txtbox.KeyPress += idnumber_txtbox_KeyPress;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.Location = new Point(395, 151);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 23);
            login_btn.TabIndex = 5;
            login_btn.Text = "Log-in";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // register_btn
            // 
            register_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            register_btn.Location = new Point(395, 180);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(75, 23);
            register_btn.TabIndex = 6;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // attendancetbl_btn
            // 
            attendancetbl_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            attendancetbl_btn.Location = new Point(585, 189);
            attendancetbl_btn.Name = "attendancetbl_btn";
            attendancetbl_btn.Size = new Size(75, 23);
            attendancetbl_btn.TabIndex = 7;
            attendancetbl_btn.Text = "Records";
            attendancetbl_btn.UseVisualStyleBackColor = true;
            attendancetbl_btn.Click += attendancetbl_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            close_btn.Location = new Point(643, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(26, 27);
            close_btn.TabIndex = 8;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 224);
            Controls.Add(close_btn);
            Controls.Add(attendancetbl_btn);
            Controls.Add(register_btn);
            Controls.Add(login_btn);
            Controls.Add(idnumber_txtbox);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer datestart;
        private Label date;
        private Label label1;
        private TextBox idnumber_txtbox;
        private Button login_btn;
        private Button register_btn;
        private Button attendancetbl_btn;
        private Button close_btn;
    }
}