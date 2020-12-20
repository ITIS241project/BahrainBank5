namespace BahrainBank
{
    partial class Form1
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
            this.label_CardNo = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label_EmptyUsename = new System.Windows.Forms.Label();
            this.label_EmptyPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_CardNo
            // 
            this.label_CardNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CardNo.Location = new System.Drawing.Point(12, 41);
            this.label_CardNo.Name = "label_CardNo";
            this.label_CardNo.Size = new System.Drawing.Size(116, 28);
            this.label_CardNo.TabIndex = 0;
            this.label_CardNo.Text = "User Name :";
            // 
            // label_Password
            // 
            this.label_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(12, 84);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(116, 28);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(134, 41);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(145, 20);
            this.textBox_UserName.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(134, 85);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(145, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(85, 146);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(142, 37);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Log in";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(85, 204);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(142, 37);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_EmptyUsename
            // 
            this.label_EmptyUsename.AutoSize = true;
            this.label_EmptyUsename.ForeColor = System.Drawing.Color.Red;
            this.label_EmptyUsename.Location = new System.Drawing.Point(131, 64);
            this.label_EmptyUsename.Name = "label_EmptyUsename";
            this.label_EmptyUsename.Size = new System.Drawing.Size(85, 13);
            this.label_EmptyUsename.TabIndex = 6;
            this.label_EmptyUsename.Text = "Enter UserName";
            this.label_EmptyUsename.Visible = false;
            // 
            // label_EmptyPassword
            // 
            this.label_EmptyPassword.AutoSize = true;
            this.label_EmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.label_EmptyPassword.Location = new System.Drawing.Point(131, 112);
            this.label_EmptyPassword.Name = "label_EmptyPassword";
            this.label_EmptyPassword.Size = new System.Drawing.Size(81, 13);
            this.label_EmptyPassword.TabIndex = 7;
            this.label_EmptyPassword.Text = "Enter Password";
            this.label_EmptyPassword.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.Controls.Add(this.label_EmptyPassword);
            this.Controls.Add(this.label_EmptyUsename);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_CardNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CardNo;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_EmptyUsename;
        private System.Windows.Forms.Label label_EmptyPassword;
    }
}

