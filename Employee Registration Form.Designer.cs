namespace Pre_School_Managment_System
{
    partial class Employee_Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Registration_Form));
            this.Save_btn = new System.Windows.Forms.Button();
            this.Student_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Female_radioButton = new System.Windows.Forms.RadioButton();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Description_and_Criminal_Record_txt = new System.Windows.Forms.TextBox();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.House_Address_txt = new System.Windows.Forms.TextBox();
            this.Contact_Details_txt = new System.Windows.Forms.TextBox();
            this.National_ID_txt = new System.Windows.Forms.TextBox();
            this.Description_and_Criminal_Record_lbl = new System.Windows.Forms.Label();
            this.First_Name_txt = new System.Windows.Forms.TextBox();
            this.Surname_lbl = new System.Windows.Forms.Label();
            this.Sex_lbl = new System.Windows.Forms.Label();
            this.DOB_lbl = new System.Windows.Forms.Label();
            this.House_Address_lbl = new System.Windows.Forms.Label();
            this.Contact_Details_lbl = new System.Windows.Forms.Label();
            this.National_ID_lbl = new System.Windows.Forms.Label();
            this.First_Name_lbl = new System.Windows.Forms.Label();
            this.Married_radioButton = new System.Windows.Forms.RadioButton();
            this.Marital_Status_lbl = new System.Windows.Forms.Label();
            this.Divoced_radioButton = new System.Windows.Forms.RadioButton();
            this.Single_radioButton = new System.Windows.Forms.RadioButton();
            this.User_txt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Save_btn.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(630, 621);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(242, 97);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "&SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Student_dateTimePicker
            // 
            this.Student_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Student_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Student_dateTimePicker.Location = new System.Drawing.Point(1033, 412);
            this.Student_dateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.Student_dateTimePicker.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.Student_dateTimePicker.Name = "Student_dateTimePicker";
            this.Student_dateTimePicker.Size = new System.Drawing.Size(335, 29);
            this.Student_dateTimePicker.TabIndex = 12;
            this.Student_dateTimePicker.Value = new System.DateTime(2019, 12, 4, 0, 1, 32, 0);
            // 
            // Female_radioButton
            // 
            this.Female_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Female_radioButton.AutoSize = true;
            this.Female_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Female_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Female_radioButton.Location = new System.Drawing.Point(230, 23);
            this.Female_radioButton.Name = "Female_radioButton";
            this.Female_radioButton.Size = new System.Drawing.Size(93, 26);
            this.Female_radioButton.TabIndex = 11;
            this.Female_radioButton.TabStop = true;
            this.Female_radioButton.Text = "Female";
            this.Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Male_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Male_radioButton.Location = new System.Drawing.Point(14, 23);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(70, 26);
            this.Male_radioButton.TabIndex = 10;
            this.Male_radioButton.TabStop = true;
            this.Male_radioButton.Text = "Male";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Description_and_Criminal_Record_txt
            // 
            this.Description_and_Criminal_Record_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_and_Criminal_Record_txt.Location = new System.Drawing.Point(327, 432);
            this.Description_and_Criminal_Record_txt.Multiline = true;
            this.Description_and_Criminal_Record_txt.Name = "Description_and_Criminal_Record_txt";
            this.Description_and_Criminal_Record_txt.Size = new System.Drawing.Size(401, 97);
            this.Description_and_Criminal_Record_txt.TabIndex = 6;
            // 
            // Surname_txt
            // 
            this.Surname_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname_txt.Location = new System.Drawing.Point(327, 243);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(401, 26);
            this.Surname_txt.TabIndex = 3;
            // 
            // House_Address_txt
            // 
            this.House_Address_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.House_Address_txt.Location = new System.Drawing.Point(327, 306);
            this.House_Address_txt.Name = "House_Address_txt";
            this.House_Address_txt.Size = new System.Drawing.Size(401, 26);
            this.House_Address_txt.TabIndex = 4;
            // 
            // Contact_Details_txt
            // 
            this.Contact_Details_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Details_txt.Location = new System.Drawing.Point(327, 369);
            this.Contact_Details_txt.Name = "Contact_Details_txt";
            this.Contact_Details_txt.Size = new System.Drawing.Size(401, 26);
            this.Contact_Details_txt.TabIndex = 5;
            // 
            // National_ID_txt
            // 
            this.National_ID_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.National_ID_txt.Location = new System.Drawing.Point(327, 117);
            this.National_ID_txt.Name = "National_ID_txt";
            this.National_ID_txt.Size = new System.Drawing.Size(401, 26);
            this.National_ID_txt.TabIndex = 1;
            // 
            // Description_and_Criminal_Record_lbl
            // 
            this.Description_and_Criminal_Record_lbl.Location = new System.Drawing.Point(109, 451);
            this.Description_and_Criminal_Record_lbl.Name = "Description_and_Criminal_Record_lbl";
            this.Description_and_Criminal_Record_lbl.Size = new System.Drawing.Size(188, 64);
            this.Description_and_Criminal_Record_lbl.TabIndex = 34;
            this.Description_and_Criminal_Record_lbl.Text = "Description and Criminal Record    :";
            // 
            // First_Name_txt
            // 
            this.First_Name_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_txt.Location = new System.Drawing.Point(327, 180);
            this.First_Name_txt.Name = "First_Name_txt";
            this.First_Name_txt.Size = new System.Drawing.Size(401, 26);
            this.First_Name_txt.TabIndex = 2;
            // 
            // Surname_lbl
            // 
            this.Surname_lbl.AutoSize = true;
            this.Surname_lbl.Location = new System.Drawing.Point(190, 245);
            this.Surname_lbl.Name = "Surname_lbl";
            this.Surname_lbl.Size = new System.Drawing.Size(103, 22);
            this.Surname_lbl.TabIndex = 32;
            this.Surname_lbl.Text = "Surname :";
            // 
            // Sex_lbl
            // 
            this.Sex_lbl.AutoSize = true;
            this.Sex_lbl.Location = new System.Drawing.Point(940, 336);
            this.Sex_lbl.Name = "Sex_lbl";
            this.Sex_lbl.Size = new System.Drawing.Size(55, 22);
            this.Sex_lbl.TabIndex = 31;
            this.Sex_lbl.Text = "Sex :";
            // 
            // DOB_lbl
            // 
            this.DOB_lbl.AutoSize = true;
            this.DOB_lbl.Location = new System.Drawing.Point(919, 419);
            this.DOB_lbl.Name = "DOB_lbl";
            this.DOB_lbl.Size = new System.Drawing.Size(76, 22);
            this.DOB_lbl.TabIndex = 30;
            this.DOB_lbl.Text = "D.O.B :";
            // 
            // House_Address_lbl
            // 
            this.House_Address_lbl.AutoSize = true;
            this.House_Address_lbl.Location = new System.Drawing.Point(133, 309);
            this.House_Address_lbl.Name = "House_Address_lbl";
            this.House_Address_lbl.Size = new System.Drawing.Size(160, 22);
            this.House_Address_lbl.TabIndex = 29;
            this.House_Address_lbl.Text = "House Address :";
            // 
            // Contact_Details_lbl
            // 
            this.Contact_Details_lbl.AutoSize = true;
            this.Contact_Details_lbl.Location = new System.Drawing.Point(132, 373);
            this.Contact_Details_lbl.Name = "Contact_Details_lbl";
            this.Contact_Details_lbl.Size = new System.Drawing.Size(161, 22);
            this.Contact_Details_lbl.TabIndex = 28;
            this.Contact_Details_lbl.Text = "Contact Details :";
            // 
            // National_ID_lbl
            // 
            this.National_ID_lbl.AutoSize = true;
            this.National_ID_lbl.Location = new System.Drawing.Point(172, 117);
            this.National_ID_lbl.Name = "National_ID_lbl";
            this.National_ID_lbl.Size = new System.Drawing.Size(121, 22);
            this.National_ID_lbl.TabIndex = 26;
            this.National_ID_lbl.Text = "National ID :";
            // 
            // First_Name_lbl
            // 
            this.First_Name_lbl.AutoSize = true;
            this.First_Name_lbl.Location = new System.Drawing.Point(177, 181);
            this.First_Name_lbl.Name = "First_Name_lbl";
            this.First_Name_lbl.Size = new System.Drawing.Size(120, 22);
            this.First_Name_lbl.TabIndex = 25;
            this.First_Name_lbl.Text = "First Name :";
            // 
            // Married_radioButton
            // 
            this.Married_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Married_radioButton.AutoSize = true;
            this.Married_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Married_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Married_radioButton.Location = new System.Drawing.Point(108, 19);
            this.Married_radioButton.Name = "Married_radioButton";
            this.Married_radioButton.Size = new System.Drawing.Size(98, 26);
            this.Married_radioButton.TabIndex = 8;
            this.Married_radioButton.TabStop = true;
            this.Married_radioButton.Text = "Married";
            this.Married_radioButton.UseVisualStyleBackColor = true;
            // 
            // Marital_Status_lbl
            // 
            this.Marital_Status_lbl.AutoSize = true;
            this.Marital_Status_lbl.Location = new System.Drawing.Point(847, 237);
            this.Marital_Status_lbl.Name = "Marital_Status_lbl";
            this.Marital_Status_lbl.Size = new System.Drawing.Size(148, 22);
            this.Marital_Status_lbl.TabIndex = 46;
            this.Marital_Status_lbl.Text = "Marital Status :";
            // 
            // Divoced_radioButton
            // 
            this.Divoced_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divoced_radioButton.AutoSize = true;
            this.Divoced_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Divoced_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divoced_radioButton.Location = new System.Drawing.Point(226, 19);
            this.Divoced_radioButton.Name = "Divoced_radioButton";
            this.Divoced_radioButton.Size = new System.Drawing.Size(101, 26);
            this.Divoced_radioButton.TabIndex = 9;
            this.Divoced_radioButton.TabStop = true;
            this.Divoced_radioButton.Text = "Divoced";
            this.Divoced_radioButton.UseVisualStyleBackColor = true;
            // 
            // Single_radioButton
            // 
            this.Single_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Single_radioButton.AutoSize = true;
            this.Single_radioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Single_radioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Single_radioButton.Location = new System.Drawing.Point(4, 19);
            this.Single_radioButton.Name = "Single_radioButton";
            this.Single_radioButton.Size = new System.Drawing.Size(84, 26);
            this.Single_radioButton.TabIndex = 7;
            this.Single_radioButton.TabStop = true;
            this.Single_radioButton.Text = "Single";
            this.Single_radioButton.UseVisualStyleBackColor = true;
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(12, 9);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(107, 22);
            this.User_txt.TabIndex = 47;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Married_radioButton);
            this.groupBox1.Controls.Add(this.Divoced_radioButton);
            this.groupBox1.Controls.Add(this.Single_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(1029, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 55);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Female_radioButton);
            this.groupBox2.Controls.Add(this.Male_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(1033, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 55);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // Employee_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1506, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Marital_Status_lbl);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Student_dateTimePicker);
            this.Controls.Add(this.Description_and_Criminal_Record_txt);
            this.Controls.Add(this.Surname_txt);
            this.Controls.Add(this.House_Address_txt);
            this.Controls.Add(this.Contact_Details_txt);
            this.Controls.Add(this.National_ID_txt);
            this.Controls.Add(this.Description_and_Criminal_Record_lbl);
            this.Controls.Add(this.First_Name_txt);
            this.Controls.Add(this.Surname_lbl);
            this.Controls.Add(this.Sex_lbl);
            this.Controls.Add(this.DOB_lbl);
            this.Controls.Add(this.House_Address_lbl);
            this.Controls.Add(this.Contact_Details_lbl);
            this.Controls.Add(this.National_ID_lbl);
            this.Controls.Add(this.First_Name_lbl);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "Employee_Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Registration Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.DateTimePicker Student_dateTimePicker;
        private System.Windows.Forms.RadioButton Female_radioButton;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.TextBox Description_and_Criminal_Record_txt;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.TextBox House_Address_txt;
        private System.Windows.Forms.TextBox Contact_Details_txt;
        private System.Windows.Forms.TextBox National_ID_txt;
        private System.Windows.Forms.Label Description_and_Criminal_Record_lbl;
        private System.Windows.Forms.TextBox First_Name_txt;
        private System.Windows.Forms.Label Surname_lbl;
        private System.Windows.Forms.Label Sex_lbl;
        private System.Windows.Forms.Label DOB_lbl;
        private System.Windows.Forms.Label House_Address_lbl;
        private System.Windows.Forms.Label Contact_Details_lbl;
        private System.Windows.Forms.Label National_ID_lbl;
        private System.Windows.Forms.Label First_Name_lbl;
        private System.Windows.Forms.RadioButton Married_radioButton;
        private System.Windows.Forms.Label Marital_Status_lbl;
        private System.Windows.Forms.RadioButton Divoced_radioButton;
        private System.Windows.Forms.RadioButton Single_radioButton;
        private System.Windows.Forms.Label User_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}