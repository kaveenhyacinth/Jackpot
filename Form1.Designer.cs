namespace JackPot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.txtNo3 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("BROKEREN", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(410, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Three Numbers of Luck";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNo1
            // 
            this.txtNo1.AcceptsReturn = true;
            this.txtNo1.AcceptsTab = true;
            this.txtNo1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNo1.Location = new System.Drawing.Point(50, 105);
            this.txtNo1.Margin = new System.Windows.Forms.Padding(20);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(100, 20);
            this.txtNo1.TabIndex = 1;
            this.txtNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNo2
            // 
            this.txtNo2.AcceptsReturn = true;
            this.txtNo2.AcceptsTab = true;
            this.txtNo2.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNo2.Location = new System.Drawing.Point(175, 105);
            this.txtNo2.Margin = new System.Windows.Forms.Padding(20);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(100, 20);
            this.txtNo2.TabIndex = 2;
            this.txtNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNo3
            // 
            this.txtNo3.AcceptsReturn = true;
            this.txtNo3.AcceptsTab = true;
            this.txtNo3.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNo3.Location = new System.Drawing.Point(300, 105);
            this.txtNo3.Margin = new System.Windows.Forms.Padding(20);
            this.txtNo3.Name = "txtNo3";
            this.txtNo3.Size = new System.Drawing.Size(100, 20);
            this.txtNo3.TabIndex = 3;
            this.txtNo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFind.Location = new System.Drawing.Point(175, 169);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 53);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find Your Luck!";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Azure;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(50, 252);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(350, 88);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "Pending ...";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtNo3);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo1);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jackpot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.TextBox txtNo3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblDisplay;
    }
}

