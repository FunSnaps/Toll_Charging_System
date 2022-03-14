
namespace LoginAndRegistration
{
    partial class PayTollPg
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
            this.simulateToll = new System.Windows.Forms.Button();
            this.reciptList = new System.Windows.Forms.ListBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.paymentBtn = new System.Windows.Forms.Button();
            this.paymentMadeLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // simulateToll
            // 
            this.simulateToll.Location = new System.Drawing.Point(6, 19);
            this.simulateToll.Name = "simulateToll";
            this.simulateToll.Size = new System.Drawing.Size(81, 53);
            this.simulateToll.TabIndex = 0;
            this.simulateToll.Text = "Drive Through Toll";
            this.simulateToll.UseVisualStyleBackColor = true;
            this.simulateToll.Click += new System.EventHandler(this.simulateToll_Click);
            // 
            // reciptList
            // 
            this.reciptList.FormattingEnabled = true;
            this.reciptList.Location = new System.Drawing.Point(6, 19);
            this.reciptList.Name = "reciptList";
            this.reciptList.Size = new System.Drawing.Size(88, 134);
            this.reciptList.TabIndex = 2;
            this.reciptList.SelectedIndexChanged += new System.EventHandler(this.reciptList_SelectedIndexChanged);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(6, 26);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(28, 13);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "date";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(6, 51);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(30, 13);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "price";
            // 
            // paymentBtn
            // 
            this.paymentBtn.Location = new System.Drawing.Point(9, 104);
            this.paymentBtn.Name = "paymentBtn";
            this.paymentBtn.Size = new System.Drawing.Size(214, 23);
            this.paymentBtn.TabIndex = 6;
            this.paymentBtn.Text = "Pay";
            this.paymentBtn.UseVisualStyleBackColor = true;
            this.paymentBtn.Click += new System.EventHandler(this.paymentBtn_Click);
            // 
            // paymentMadeLbl
            // 
            this.paymentMadeLbl.AutoSize = true;
            this.paymentMadeLbl.Location = new System.Drawing.Point(6, 78);
            this.paymentMadeLbl.Name = "paymentMadeLbl";
            this.paymentMadeLbl.Size = new System.Drawing.Size(82, 13);
            this.paymentMadeLbl.TabIndex = 7;
            this.paymentMadeLbl.Text = "payment made?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateLbl);
            this.groupBox1.Controls.Add(this.paymentMadeLbl);
            this.groupBox1.Controls.Add(this.priceLbl);
            this.groupBox1.Controls.Add(this.paymentBtn);
            this.groupBox1.Location = new System.Drawing.Point(100, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Recipt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reciptList);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 174);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toll History";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simulateToll);
            this.groupBox3.Location = new System.Drawing.Point(419, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 85);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulate Toll";
            // 
            // PayTollPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 229);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "PayTollPg";
            this.Text = "PayTollPg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simulateToll;
        private System.Windows.Forms.ListBox reciptList;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label paymentMadeLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}