
namespace LoginAndRegistration
{
    partial class DashboardForm
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
            this.paymentsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paymentsBtn
            // 
            this.paymentsBtn.Location = new System.Drawing.Point(577, 347);
            this.paymentsBtn.Name = "paymentsBtn";
            this.paymentsBtn.Size = new System.Drawing.Size(136, 43);
            this.paymentsBtn.TabIndex = 0;
            this.paymentsBtn.Text = "Payments";
            this.paymentsBtn.UseVisualStyleBackColor = true;
            this.paymentsBtn.Click += new System.EventHandler(this.paymentsBtn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paymentsBtn);
            this.Name = "DashboardForm";
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paymentsBtn;
    }
}