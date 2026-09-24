
namespace Picture_Box.Window_Forms
{
    partial class Frm_Update_Stud_Info
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Student_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Remove_Photo = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.cmb_Blood_Gr = new System.Windows.Forms.ComboBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Blood_Group = new System.Windows.Forms.Label();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Branch = new System.Windows.Forms.ComboBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Stud_Name = new System.Windows.Forms.TextBox();
            this.tb_Stud_Id = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Branch = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Stud_Name = new System.Windows.Forms.Label();
            this.lbl_Stud_Id = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gb_Student_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Clear.Location = new System.Drawing.Point(828, 704);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(183, 51);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = " Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(406, 704);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(192, 51);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // gb_Student_Details
            // 
            this.gb_Student_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_Student_Details.Controls.Add(this.btn_Search);
            this.gb_Student_Details.Controls.Add(this.btn_Remove_Photo);
            this.gb_Student_Details.Controls.Add(this.btn_Browse);
            this.gb_Student_Details.Controls.Add(this.pb_Photo);
            this.gb_Student_Details.Controls.Add(this.tb_Address);
            this.gb_Student_Details.Controls.Add(this.tb_Email_Id);
            this.gb_Student_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Student_Details.Controls.Add(this.cmb_Blood_Gr);
            this.gb_Student_Details.Controls.Add(this.cmb_Gender);
            this.gb_Student_Details.Controls.Add(this.lbl_Address);
            this.gb_Student_Details.Controls.Add(this.lbl_Blood_Group);
            this.gb_Student_Details.Controls.Add(this.lbl_Email_Id);
            this.gb_Student_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Student_Details.Controls.Add(this.lbl_Gender);
            this.gb_Student_Details.Controls.Add(this.cmb_Year);
            this.gb_Student_Details.Controls.Add(this.cmb_Branch);
            this.gb_Student_Details.Controls.Add(this.cmb_Course);
            this.gb_Student_Details.Controls.Add(this.dtp_DOB);
            this.gb_Student_Details.Controls.Add(this.tb_Stud_Name);
            this.gb_Student_Details.Controls.Add(this.tb_Stud_Id);
            this.gb_Student_Details.Controls.Add(this.lbl_Year);
            this.gb_Student_Details.Controls.Add(this.lbl_Branch);
            this.gb_Student_Details.Controls.Add(this.lbl_Course);
            this.gb_Student_Details.Controls.Add(this.lbl_DOB);
            this.gb_Student_Details.Controls.Add(this.lbl_Stud_Name);
            this.gb_Student_Details.Controls.Add(this.lbl_Stud_Id);
            this.gb_Student_Details.Location = new System.Drawing.Point(20, 114);
            this.gb_Student_Details.Name = "gb_Student_Details";
            this.gb_Student_Details.Size = new System.Drawing.Size(1304, 538);
            this.gb_Student_Details.TabIndex = 18;
            this.gb_Student_Details.TabStop = false;
            this.gb_Student_Details.Text = "Student Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(463, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(125, 51);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Remove_Photo
            // 
            this.btn_Remove_Photo.BackColor = System.Drawing.Color.Orange;
            this.btn_Remove_Photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove_Photo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Remove_Photo.Location = new System.Drawing.Point(1081, 400);
            this.btn_Remove_Photo.Name = "btn_Remove_Photo";
            this.btn_Remove_Photo.Size = new System.Drawing.Size(206, 51);
            this.btn_Remove_Photo.TabIndex = 13;
            this.btn_Remove_Photo.Text = "🗑️ Remove Photo";
            this.btn_Remove_Photo.UseVisualStyleBackColor = false;
            this.btn_Remove_Photo.Click += new System.EventHandler(this.btn_Remove_Photo_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(1081, 305);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(206, 51);
            this.btn_Browse.TabIndex = 12;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            // 
            // pb_Photo
            // 
            this.pb_Photo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pb_Photo.Location = new System.Drawing.Point(1081, 72);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(208, 197);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Photo.TabIndex = 22;
            this.pb_Photo.TabStop = false;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(772, 387);
            this.tb_Address.MaxLength = 100;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(248, 117);
            this.tb_Address.TabIndex = 11;
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(772, 220);
            this.tb_Email_Id.MaxLength = 30;
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(248, 30);
            this.tb_Email_Id.TabIndex = 9;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(772, 135);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(248, 30);
            this.tb_Mobile_No.TabIndex = 8;
            // 
            // cmb_Blood_Gr
            // 
            this.cmb_Blood_Gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Blood_Gr.FormattingEnabled = true;
            this.cmb_Blood_Gr.Location = new System.Drawing.Point(772, 300);
            this.cmb_Blood_Gr.Name = "cmb_Blood_Gr";
            this.cmb_Blood_Gr.Size = new System.Drawing.Size(248, 33);
            this.cmb_Blood_Gr.TabIndex = 10;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(772, 53);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(248, 33);
            this.cmb_Gender.TabIndex = 7;
            // 
            // lbl_Address
            // 
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Address.Location = new System.Drawing.Point(587, 386);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(166, 38);
            this.lbl_Address.TabIndex = 16;
            this.lbl_Address.Text = "Address";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Blood_Group
            // 
            this.lbl_Blood_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood_Group.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Blood_Group.Location = new System.Drawing.Point(587, 300);
            this.lbl_Blood_Group.Name = "lbl_Blood_Group";
            this.lbl_Blood_Group.Size = new System.Drawing.Size(166, 38);
            this.lbl_Blood_Group.TabIndex = 15;
            this.lbl_Blood_Group.Text = "Blood Group";
            this.lbl_Blood_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Email_Id.Location = new System.Drawing.Point(587, 210);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(166, 38);
            this.lbl_Email_Id.TabIndex = 14;
            this.lbl_Email_Id.Text = "Email ID";
            this.lbl_Email_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(587, 128);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(166, 38);
            this.lbl_Mobile_No.TabIndex = 13;
            this.lbl_Mobile_No.Text = "Mobile No.";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Gender.Location = new System.Drawing.Point(587, 46);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(166, 38);
            this.lbl_Gender.TabIndex = 12;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Year
            // 
            this.cmb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year"});
            this.cmb_Year.Location = new System.Drawing.Point(236, 473);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(287, 33);
            this.cmb_Year.TabIndex = 6;
            // 
            // cmb_Branch
            // 
            this.cmb_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Branch.FormattingEnabled = true;
            this.cmb_Branch.Items.AddRange(new object[] {
            "Computer Science",
            "Chemistry",
            "Physics",
            "Economy"});
            this.cmb_Branch.Location = new System.Drawing.Point(236, 386);
            this.cmb_Branch.Name = "cmb_Branch";
            this.cmb_Branch.Size = new System.Drawing.Size(287, 33);
            this.cmb_Branch.TabIndex = 5;
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BSC(CS) Optional",
            "BSc Chemistry",
            "BSc Physics",
            "BSc Economy",
            "BSc Statistics"});
            this.cmb_Course.Location = new System.Drawing.Point(236, 305);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(287, 33);
            this.cmb_Course.TabIndex = 4;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(236, 218);
            this.dtp_DOB.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(288, 30);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            // 
            // tb_Stud_Name
            // 
            this.tb_Stud_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_Name.Location = new System.Drawing.Point(236, 128);
            this.tb_Stud_Name.MaxLength = 50;
            this.tb_Stud_Name.Name = "tb_Stud_Name";
            this.tb_Stud_Name.Size = new System.Drawing.Size(289, 30);
            this.tb_Stud_Name.TabIndex = 2;
            // 
            // tb_Stud_Id
            // 
            this.tb_Stud_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_Id.Location = new System.Drawing.Point(236, 46);
            this.tb_Stud_Id.MaxLength = 8;
            this.tb_Stud_Id.Name = "tb_Stud_Id";
            this.tb_Stud_Id.Size = new System.Drawing.Size(212, 30);
            this.tb_Stud_Id.TabIndex = 1;
            // 
            // lbl_Year
            // 
            this.lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Year.Location = new System.Drawing.Point(17, 466);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(166, 38);
            this.lbl_Year.TabIndex = 5;
            this.lbl_Year.Text = "Year";
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Branch.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Branch.Location = new System.Drawing.Point(17, 379);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(166, 38);
            this.lbl_Branch.TabIndex = 4;
            this.lbl_Branch.Text = "Branch";
            this.lbl_Branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Course
            // 
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Course.Location = new System.Drawing.Point(17, 300);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(166, 38);
            this.lbl_Course.TabIndex = 3;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Purple;
            this.lbl_DOB.Location = new System.Drawing.Point(17, 210);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(191, 38);
            this.lbl_DOB.TabIndex = 2;
            this.lbl_DOB.Text = "Date Of Birth";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Stud_Name
            // 
            this.lbl_Stud_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Stud_Name.Location = new System.Drawing.Point(17, 120);
            this.lbl_Stud_Name.Name = "lbl_Stud_Name";
            this.lbl_Stud_Name.Size = new System.Drawing.Size(191, 38);
            this.lbl_Stud_Name.TabIndex = 1;
            this.lbl_Stud_Name.Text = "Student Name";
            this.lbl_Stud_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Stud_Id
            // 
            this.lbl_Stud_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Id.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Stud_Id.Location = new System.Drawing.Point(17, 39);
            this.lbl_Stud_Id.Name = "lbl_Stud_Id";
            this.lbl_Stud_Id.Size = new System.Drawing.Size(166, 38);
            this.lbl_Stud_Id.TabIndex = 0;
            this.lbl_Stud_Id.Text = "Student ID";
            this.lbl_Stud_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1341, 78);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "Update Student Information";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Update_Stud_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 799);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.gb_Student_Details);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Frm_Update_Stud_Info";
            this.Text = "Update_Stud_Info";
            this.gb_Student_Details.ResumeLayout(false);
            this.gb_Student_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox gb_Student_Details;
        private System.Windows.Forms.Button btn_Remove_Photo;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.ComboBox cmb_Blood_Gr;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Blood_Group;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Branch;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Stud_Name;
        private System.Windows.Forms.TextBox tb_Stud_Id;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Branch;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Stud_Name;
        private System.Windows.Forms.Label lbl_Stud_Id;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Search;
    }
}