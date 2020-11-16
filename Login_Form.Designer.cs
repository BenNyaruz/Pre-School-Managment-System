namespace Pre_School_Managment_System
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Accept_btn = new System.Windows.Forms.Button();
            this.ShowPass_chbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(181, 55);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(239, 30);
            this.UserName_txt.TabIndex = 0;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(181, 102);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(239, 30);
            this.Password_txt.TabIndex = 1;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Location = new System.Drawing.Point(38, 58);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(106, 23);
            this.Username_lbl.TabIndex = 2;
            this.Username_lbl.Text = "Username:";
            this.Username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Location = new System.Drawing.Point(42, 105);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(102, 23);
            this.Password_lbl.TabIndex = 3;
            this.Password_lbl.Text = "Password:";
            this.Password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Tomato;
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_btn.ForeColor = System.Drawing.Color.Black;
            this.Cancel_btn.Location = new System.Drawing.Point(181, 184);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(92, 38);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "&Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Accept_btn
            // 
            this.Accept_btn.BackColor = System.Drawing.Color.Lime;
            this.Accept_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Accept_btn.Location = new System.Drawing.Point(328, 184);
            this.Accept_btn.Name = "Accept_btn";
            this.Accept_btn.Size = new System.Drawing.Size(92, 38);
            this.Accept_btn.TabIndex = 3;
            this.Accept_btn.Text = "&Accept";
            this.Accept_btn.UseVisualStyleBackColor = false;
            this.Accept_btn.Click += new System.EventHandler(this.Accept_btn_Click);
            // 
            // ShowPass_chbox
            // 
            this.ShowPass_chbox.AutoSize = true;
            this.ShowPass_chbox.Location = new System.Drawing.Point(259, 137);
            this.ShowPass_chbox.Name = "ShowPass_chbox";
            this.ShowPass_chbox.Size = new System.Drawing.Size(170, 27);
            this.ShowPass_chbox.TabIndex = 2;
            this.ShowPass_chbox.Text = "Show Password";
            this.ShowPass_chbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPass_chbox.UseVisualStyleBackColor = true;
            this.ShowPass_chbox.CheckedChanged += new System.EventHandler(this.ShowPass_chbox_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(506, 275);
            this.Controls.Add(this.ShowPass_chbox);
            this.Controls.Add(this.Accept_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre School Managment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Accept_btn;
        private System.Windows.Forms.CheckBox ShowPass_chbox;
    }
}

