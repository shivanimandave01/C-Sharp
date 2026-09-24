
namespace Picture_Box.Window_Forms
{
    partial class Frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Stud_Id = new System.Windows.Forms.TextBox();
            this.lbl_Stud_Id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.lbl_Student_Id = new System.Windows.Forms.Label();
            this.lbl_Stud_Name = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Branch = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_tb_Id = new System.Windows.Forms.Label();
            this.lbl_tb_Name = new System.Windows.Forms.Label();
            this.lbl_tb_Course = new System.Windows.Forms.Label();
            this.lbl_tb_Branch = new System.Windows.Forms.Label();
            this.lbl_tb_Year = new System.Windows.Forms.Label();
            this.lbl_tb_DOB = new System.Windows.Forms.Label();
            this.lbl_tb_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Clg_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(149, 267);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(125, 51);
            this.btn_Search.TabIndex = 25;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Stud_Id
            // 
            this.tb_Stud_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stud_Id.Location = new System.Drawing.Point(241, 163);
            this.tb_Stud_Id.MaxLength = 8;
            this.tb_Stud_Id.Name = "tb_Stud_Id";
            this.tb_Stud_Id.Size = new System.Drawing.Size(212, 30);
            this.tb_Stud_Id.TabIndex = 24;
            // 
            // lbl_Stud_Id
            // 
            this.lbl_Stud_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Id.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Stud_Id.Location = new System.Drawing.Point(12, 163);
            this.lbl_Stud_Id.Name = "lbl_Stud_Id";
            this.lbl_Stud_Id.Size = new System.Drawing.Size(166, 38);
            this.lbl_Stud_Id.TabIndex = 23;
            this.lbl_Stud_Id.Text = "Student ID";
            this.lbl_Stud_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Photo
            // 
            this.pb_Photo.Location = new System.Drawing.Point(757, 149);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(109, 135);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Photo.TabIndex = 27;
            this.pb_Photo.TabStop = false;
            // 
            // lbl_Student_Id
            // 
            this.lbl_Student_Id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Student_Id.Location = new System.Drawing.Point(610, 308);
            this.lbl_Student_Id.Name = "lbl_Student_Id";
            this.lbl_Student_Id.Size = new System.Drawing.Size(131, 33);
            this.lbl_Student_Id.TabIndex = 28;
            this.lbl_Student_Id.Text = "Student ID";
            // 
            // lbl_Stud_Name
            // 
            this.lbl_Stud_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Stud_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Stud_Name.Location = new System.Drawing.Point(610, 355);
            this.lbl_Stud_Name.Name = "lbl_Stud_Name";
            this.lbl_Stud_Name.Size = new System.Drawing.Size(139, 33);
            this.lbl_Stud_Name.TabIndex = 29;
            this.lbl_Stud_Name.Text = "Student Name";
            // 
            // lbl_Course
            // 
            this.lbl_Course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Course.Location = new System.Drawing.Point(610, 403);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(131, 33);
            this.lbl_Course.TabIndex = 30;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Branch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Branch.Location = new System.Drawing.Point(610, 454);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(131, 33);
            this.lbl_Branch.TabIndex = 31;
            this.lbl_Branch.Text = "Branch";
            // 
            // lbl_Year
            // 
            this.lbl_Year.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Year.Location = new System.Drawing.Point(610, 506);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(131, 33);
            this.lbl_Year.TabIndex = 32;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_DOB.Location = new System.Drawing.Point(610, 561);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(131, 33);
            this.lbl_DOB.TabIndex = 33;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Mob_No.Location = new System.Drawing.Point(610, 617);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(131, 33);
            this.lbl_Mob_No.TabIndex = 34;
            this.lbl_Mob_No.Text = "Mobile No.";
            // 
            // lbl_tb_Id
            // 
            this.lbl_tb_Id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Id.Location = new System.Drawing.Point(795, 308);
            this.lbl_tb_Id.Name = "lbl_tb_Id";
            this.lbl_tb_Id.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Id.TabIndex = 35;
            // 
            // lbl_tb_Name
            // 
            this.lbl_tb_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Name.Location = new System.Drawing.Point(795, 355);
            this.lbl_tb_Name.Name = "lbl_tb_Name";
            this.lbl_tb_Name.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Name.TabIndex = 36;
            // 
            // lbl_tb_Course
            // 
            this.lbl_tb_Course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Course.Location = new System.Drawing.Point(795, 403);
            this.lbl_tb_Course.Name = "lbl_tb_Course";
            this.lbl_tb_Course.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Course.TabIndex = 37;
            // 
            // lbl_tb_Branch
            // 
            this.lbl_tb_Branch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Branch.Location = new System.Drawing.Point(795, 454);
            this.lbl_tb_Branch.Name = "lbl_tb_Branch";
            this.lbl_tb_Branch.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Branch.TabIndex = 38;
            // 
            // lbl_tb_Year
            // 
            this.lbl_tb_Year.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Year.Location = new System.Drawing.Point(795, 506);
            this.lbl_tb_Year.Name = "lbl_tb_Year";
            this.lbl_tb_Year.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Year.TabIndex = 39;
            // 
            // lbl_tb_DOB
            // 
            this.lbl_tb_DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_DOB.Location = new System.Drawing.Point(795, 567);
            this.lbl_tb_DOB.Name = "lbl_tb_DOB";
            this.lbl_tb_DOB.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_DOB.TabIndex = 40;
            // 
            // lbl_tb_Mob_No
            // 
            this.lbl_tb_Mob_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tb_Mob_No.Location = new System.Drawing.Point(795, 617);
            this.lbl_tb_Mob_No.Name = "lbl_tb_Mob_No";
            this.lbl_tb_Mob_No.Size = new System.Drawing.Size(232, 27);
            this.lbl_tb_Mob_No.TabIndex = 41;
            // 
            // lbl_Clg_Name
            // 
            this.lbl_Clg_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clg_Name.Location = new System.Drawing.Point(653, 62);
            this.lbl_Clg_Name.Name = "lbl_Clg_Name";
            this.lbl_Clg_Name.Size = new System.Drawing.Size(340, 58);
            this.lbl_Clg_Name.TabIndex = 42;
            this.lbl_Clg_Name.Text = "label1";
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 777);
            this.Controls.Add(this.lbl_Clg_Name);
            this.Controls.Add(this.lbl_tb_Mob_No);
            this.Controls.Add(this.lbl_tb_DOB);
            this.Controls.Add(this.lbl_tb_Year);
            this.Controls.Add(this.lbl_tb_Branch);
            this.Controls.Add(this.lbl_tb_Course);
            this.Controls.Add(this.lbl_tb_Name);
            this.Controls.Add(this.lbl_tb_Id);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Branch);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Stud_Name);
            this.Controls.Add(this.lbl_Student_Id);
            this.Controls.Add(this.pb_Photo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Stud_Id);
            this.Controls.Add(this.lbl_Stud_Id);
            this.Name = "Frm_Search";
            this.Text = "Identity card Preview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Stud_Id;
        private System.Windows.Forms.Label lbl_Stud_Id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.Label lbl_Student_Id;
        private System.Windows.Forms.Label lbl_Stud_Name;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Branch;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_tb_Id;
        private System.Windows.Forms.Label lbl_tb_Name;
        private System.Windows.Forms.Label lbl_tb_Course;
        private System.Windows.Forms.Label lbl_tb_Branch;
        private System.Windows.Forms.Label lbl_tb_Year;
        private System.Windows.Forms.Label lbl_tb_DOB;
        private System.Windows.Forms.Label lbl_tb_Mob_No;
        private System.Windows.Forms.Label lbl_Clg_Name;
    }
}