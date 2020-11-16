namespace Pre_School_Managment_System
{
    partial class Assert_Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assert_Registration_Form));
            this.Assert_Name_txt = new System.Windows.Forms.TextBox();
            this.Assert_Name_lbl = new System.Windows.Forms.Label();
            this.Add_Assert_btn = new System.Windows.Forms.Button();
            this.Assert_Value_lbl = new System.Windows.Forms.Label();
            this.Purchase_Date_lbl = new System.Windows.Forms.Label();
            this.Assert_Decription_lbl = new System.Windows.Forms.Label();
            this.Assert_Decription_txt = new System.Windows.Forms.TextBox();
            this.Assert_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Disposal_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Disposal_Date_lbl = new System.Windows.Forms.Label();
            this.Assert_Value_txt = new System.Windows.Forms.NumericUpDown();
            this.Depriciation_Value_txt = new System.Windows.Forms.NumericUpDown();
            this.Depriciation_Value_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Assert_Value_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depriciation_Value_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // Assert_Name_txt
            // 
            this.Assert_Name_txt.Location = new System.Drawing.Point(330, 119);
            this.Assert_Name_txt.Name = "Assert_Name_txt";
            this.Assert_Name_txt.Size = new System.Drawing.Size(452, 32);
            this.Assert_Name_txt.TabIndex = 0;
            // 
            // Assert_Name_lbl
            // 
            this.Assert_Name_lbl.AutoSize = true;
            this.Assert_Name_lbl.Location = new System.Drawing.Point(108, 122);
            this.Assert_Name_lbl.Name = "Assert_Name_lbl";
            this.Assert_Name_lbl.Size = new System.Drawing.Size(151, 24);
            this.Assert_Name_lbl.TabIndex = 1;
            this.Assert_Name_lbl.Text = "Assert Name :";
            // 
            // Add_Assert_btn
            // 
            this.Add_Assert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Add_Assert_btn.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Assert_btn.Location = new System.Drawing.Point(681, 567);
            this.Add_Assert_btn.Name = "Add_Assert_btn";
            this.Add_Assert_btn.Size = new System.Drawing.Size(265, 81);
            this.Add_Assert_btn.TabIndex = 2;
            this.Add_Assert_btn.Text = "&Add Assert";
            this.Add_Assert_btn.UseVisualStyleBackColor = false;
            this.Add_Assert_btn.Click += new System.EventHandler(this.Add_Assert_btn_Click);
            // 
            // Assert_Value_lbl
            // 
            this.Assert_Value_lbl.AutoSize = true;
            this.Assert_Value_lbl.Location = new System.Drawing.Point(924, 235);
            this.Assert_Value_lbl.Name = "Assert_Value_lbl";
            this.Assert_Value_lbl.Size = new System.Drawing.Size(149, 24);
            this.Assert_Value_lbl.TabIndex = 5;
            this.Assert_Value_lbl.Text = "Assert Value :";
            // 
            // Purchase_Date_lbl
            // 
            this.Purchase_Date_lbl.AutoSize = true;
            this.Purchase_Date_lbl.Location = new System.Drawing.Point(89, 351);
            this.Purchase_Date_lbl.Name = "Purchase_Date_lbl";
            this.Purchase_Date_lbl.Size = new System.Drawing.Size(170, 24);
            this.Purchase_Date_lbl.TabIndex = 7;
            this.Purchase_Date_lbl.Text = "Purchase Date :";
            // 
            // Assert_Decription_lbl
            // 
            this.Assert_Decription_lbl.AutoSize = true;
            this.Assert_Decription_lbl.Location = new System.Drawing.Point(61, 235);
            this.Assert_Decription_lbl.Name = "Assert_Decription_lbl";
            this.Assert_Decription_lbl.Size = new System.Drawing.Size(199, 24);
            this.Assert_Decription_lbl.TabIndex = 9;
            this.Assert_Decription_lbl.Text = "Assert Decription :";
            // 
            // Assert_Decription_txt
            // 
            this.Assert_Decription_txt.Location = new System.Drawing.Point(330, 203);
            this.Assert_Decription_txt.Multiline = true;
            this.Assert_Decription_txt.Name = "Assert_Decription_txt";
            this.Assert_Decription_txt.Size = new System.Drawing.Size(452, 90);
            this.Assert_Decription_txt.TabIndex = 8;
            // 
            // Assert_dateTimePicker
            // 
            this.Assert_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Assert_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Assert_dateTimePicker.Location = new System.Drawing.Point(330, 345);
            this.Assert_dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.Assert_dateTimePicker.Name = "Assert_dateTimePicker";
            this.Assert_dateTimePicker.Size = new System.Drawing.Size(452, 32);
            this.Assert_dateTimePicker.TabIndex = 10;
            // 
            // Disposal_dateTimePicker
            // 
            this.Disposal_dateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.Disposal_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Disposal_dateTimePicker.Location = new System.Drawing.Point(330, 429);
            this.Disposal_dateTimePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.Disposal_dateTimePicker.Name = "Disposal_dateTimePicker";
            this.Disposal_dateTimePicker.Size = new System.Drawing.Size(452, 32);
            this.Disposal_dateTimePicker.TabIndex = 12;
            this.Disposal_dateTimePicker.Value = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            // 
            // Disposal_Date_lbl
            // 
            this.Disposal_Date_lbl.AutoSize = true;
            this.Disposal_Date_lbl.Location = new System.Drawing.Point(98, 436);
            this.Disposal_Date_lbl.Name = "Disposal_Date_lbl";
            this.Disposal_Date_lbl.Size = new System.Drawing.Size(162, 24);
            this.Disposal_Date_lbl.TabIndex = 11;
            this.Disposal_Date_lbl.Text = "Disposal Date :";
            // 
            // Assert_Value_txt
            // 
            this.Assert_Value_txt.DecimalPlaces = 2;
            this.Assert_Value_txt.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assert_Value_txt.Location = new System.Drawing.Point(1102, 221);
            this.Assert_Value_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Assert_Value_txt.Name = "Assert_Value_txt";
            this.Assert_Value_txt.Size = new System.Drawing.Size(334, 48);
            this.Assert_Value_txt.TabIndex = 13;
            // 
            // Depriciation_Value_txt
            // 
            this.Depriciation_Value_txt.DecimalPlaces = 2;
            this.Depriciation_Value_txt.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depriciation_Value_txt.Location = new System.Drawing.Point(1102, 337);
            this.Depriciation_Value_txt.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Depriciation_Value_txt.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Depriciation_Value_txt.Name = "Depriciation_Value_txt";
            this.Depriciation_Value_txt.Size = new System.Drawing.Size(334, 48);
            this.Depriciation_Value_txt.TabIndex = 15;
            // 
            // Depriciation_Value_lbl
            // 
            this.Depriciation_Value_lbl.AutoSize = true;
            this.Depriciation_Value_lbl.Location = new System.Drawing.Point(864, 351);
            this.Depriciation_Value_lbl.Name = "Depriciation_Value_lbl";
            this.Depriciation_Value_lbl.Size = new System.Drawing.Size(209, 24);
            this.Depriciation_Value_lbl.TabIndex = 14;
            this.Depriciation_Value_lbl.Text = "Depriciation Value :";
            // 
            // User_txt
            // 
            this.User_txt.AutoSize = true;
            this.User_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User_txt.ForeColor = System.Drawing.Color.SteelBlue;
            this.User_txt.Location = new System.Drawing.Point(12, 9);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(118, 24);
            this.User_txt.TabIndex = 48;
            this.User_txt.Text = "Main Menu";
            this.User_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.User_txt.Visible = false;
            // 
            // Assert_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1529, 660);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Depriciation_Value_txt);
            this.Controls.Add(this.Depriciation_Value_lbl);
            this.Controls.Add(this.Assert_Value_txt);
            this.Controls.Add(this.Disposal_dateTimePicker);
            this.Controls.Add(this.Disposal_Date_lbl);
            this.Controls.Add(this.Assert_dateTimePicker);
            this.Controls.Add(this.Assert_Decription_lbl);
            this.Controls.Add(this.Assert_Decription_txt);
            this.Controls.Add(this.Purchase_Date_lbl);
            this.Controls.Add(this.Assert_Value_lbl);
            this.Controls.Add(this.Add_Assert_btn);
            this.Controls.Add(this.Assert_Name_lbl);
            this.Controls.Add(this.Assert_Name_txt);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Assert_Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assert Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.Assert_Value_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Depriciation_Value_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Assert_Name_txt;
        private System.Windows.Forms.Label Assert_Name_lbl;
        private System.Windows.Forms.Button Add_Assert_btn;
        private System.Windows.Forms.Label Assert_Value_lbl;
        private System.Windows.Forms.Label Purchase_Date_lbl;
        private System.Windows.Forms.Label Assert_Decription_lbl;
        private System.Windows.Forms.TextBox Assert_Decription_txt;
        private System.Windows.Forms.DateTimePicker Assert_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Disposal_dateTimePicker;
        private System.Windows.Forms.Label Disposal_Date_lbl;
        private System.Windows.Forms.NumericUpDown Assert_Value_txt;
        private System.Windows.Forms.NumericUpDown Depriciation_Value_txt;
        private System.Windows.Forms.Label Depriciation_Value_lbl;
        private System.Windows.Forms.Label User_txt;
    }
}