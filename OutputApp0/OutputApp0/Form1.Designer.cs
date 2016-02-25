namespace OutputApp0
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIncomingIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnAcceptTransfer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(147, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MYNGO Aerospace Data Receive Simulator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIncomingIP
            // 
            this.lblIncomingIP.AutoSize = true;
            this.lblIncomingIP.Location = new System.Drawing.Point(220, 89);
            this.lblIncomingIP.Name = "lblIncomingIP";
            this.lblIncomingIP.Size = new System.Drawing.Size(121, 13);
            this.lblIncomingIP.TabIndex = 1;
            this.lblIncomingIP.Text = "Transmitting IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(188, 107);
            this.txtIP.MaxLength = 16;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(197, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAcceptTransfer
            // 
            this.btnAcceptTransfer.Location = new System.Drawing.Point(344, 251);
            this.btnAcceptTransfer.Name = "btnAcceptTransfer";
            this.btnAcceptTransfer.Size = new System.Drawing.Size(98, 25);
            this.btnAcceptTransfer.TabIndex = 3;
            this.btnAcceptTransfer.Text = "Accept Transfer";
            this.btnAcceptTransfer.UseVisualStyleBackColor = true;
            this.btnAcceptTransfer.Click += new System.EventHandler(this.btnAcceptTransfer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(452, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 342);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAcceptTransfer);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblIncomingIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Output Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIncomingIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnAcceptTransfer;
        private System.Windows.Forms.Button btnClose;
    }
}

