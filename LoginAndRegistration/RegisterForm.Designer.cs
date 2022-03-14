
namespace LoginAndRegistration
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckboxShowPas = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackToLoginButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(33, 160);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 28);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonlistener);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(33, 234);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(216, 28);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonlistener);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(33, 308);
            this.txtConPassword.Multiline = true;
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '•';
            this.txtConPassword.Size = new System.Drawing.Size(216, 28);
            this.txtConPassword.TabIndex = 6;
            this.txtConPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonlistener);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // CheckboxShowPas
            // 
            this.CheckboxShowPas.AutoSize = true;
            this.CheckboxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckboxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckboxShowPas.Location = new System.Drawing.Point(130, 342);
            this.CheckboxShowPas.Name = "CheckboxShowPas";
            this.CheckboxShowPas.Size = new System.Drawing.Size(119, 21);
            this.CheckboxShowPas.TabIndex = 7;
            this.CheckboxShowPas.Text = "Show password";
            this.CheckboxShowPas.UseVisualStyleBackColor = true;
            this.CheckboxShowPas.CheckedChanged += new System.EventHandler(this.CheckboxShowPas_CheckedChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(33, 369);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(216, 35);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClearButton.Location = new System.Drawing.Point(33, 410);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(216, 35);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an account?";
            // 
            // BackToLoginButton
            // 
            this.BackToLoginButton.AutoSize = true;
            this.BackToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackToLoginButton.Location = new System.Drawing.Point(98, 494);
            this.BackToLoginButton.Name = "BackToLoginButton";
            this.BackToLoginButton.Size = new System.Drawing.Size(92, 17);
            this.BackToLoginButton.TabIndex = 11;
            this.BackToLoginButton.Text = "back to Login\r\n";
            this.BackToLoginButton.Click += new System.EventHandler(this.label6_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(239, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(34, 34);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackToLoginButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CheckboxShowPas);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonlistener);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckboxShowPas;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BackToLoginButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

