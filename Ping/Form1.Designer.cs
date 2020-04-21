namespace Ping
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
            this.lblPing = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Location = new System.Drawing.Point(21, 21);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(61, 13);
            this.lblPing.TabIndex = 0;
            this.lblPing.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(88, 18);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(154, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "8.8.8.8";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(248, 16);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(24, 76);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(299, 235);
            this.txtResponse.TabIndex = 3;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(21, 60);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(58, 13);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 337);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblResponse;
    }
}

