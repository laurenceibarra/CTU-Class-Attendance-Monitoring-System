namespace CTU__Class_Attendance_Monitoring_System
{
    partial class register_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_form));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            id_number_lbl = new Label();
            label1 = new Label();
            firstname_txtbox = new TextBox();
            submit_btn = new Button();
            cancel_btn = new Button();
            lastname_txtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 185, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(3, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 100);
            panel2.TabIndex = 1;
            // 
            // id_number_lbl
            // 
            id_number_lbl.AutoSize = true;
            id_number_lbl.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            id_number_lbl.Location = new Point(168, 66);
            id_number_lbl.Name = "id_number_lbl";
            id_number_lbl.Size = new Size(36, 14);
            id_number_lbl.TabIndex = 1;
            id_number_lbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 66);
            label1.Name = "label1";
            label1.Size = new Size(124, 14);
            label1.TabIndex = 2;
            label1.Text = "Enter name for ID no: ";
            // 
            // firstname_txtbox
            // 
            firstname_txtbox.Location = new Point(49, 111);
            firstname_txtbox.Name = "firstname_txtbox";
            firstname_txtbox.Size = new Size(339, 23);
            firstname_txtbox.TabIndex = 3;
            // 
            // submit_btn
            // 
            submit_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit_btn.Location = new Point(179, 186);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(75, 23);
            submit_btn.TabIndex = 4;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(179, 215);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(75, 23);
            cancel_btn.TabIndex = 5;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // lastname_txtbox
            // 
            lastname_txtbox.Location = new Point(49, 157);
            lastname_txtbox.Name = "lastname_txtbox";
            lastname_txtbox.Size = new Size(339, 23);
            lastname_txtbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 94);
            label2.Name = "label2";
            label2.Size = new Size(74, 14);
            label2.TabIndex = 7;
            label2.Text = "Given Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 140);
            label3.Name = "label3";
            label3.Size = new Size(60, 14);
            label3.TabIndex = 8;
            label3.Text = "Surname: ";
            // 
            // register_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lastname_txtbox);
            Controls.Add(cancel_btn);
            Controls.Add(submit_btn);
            Controls.Add(firstname_txtbox);
            Controls.Add(label1);
            Controls.Add(id_number_lbl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "register_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += register_form_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label id_number_lbl;
        private Label label1;
        private TextBox firstname_txtbox;
        private Button submit_btn;
        private Button cancel_btn;
        private TextBox lastname_txtbox;
        private Label label2;
        private Label label3;
    }
}