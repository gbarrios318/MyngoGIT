namespace InputApp0
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbRunway = new System.Windows.Forms.RadioButton();
            this.rbWheelsUp = new System.Windows.Forms.RadioButton();
            this.lblFlightStatus = new System.Windows.Forms.GroupBox();
            this.rbCruising = new System.Windows.Forms.RadioButton();
            this.rbLanding = new System.Windows.Forms.RadioButton();
            this.rbEmergency = new System.Windows.Forms.RadioButton();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFlightStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTitle.Location = new System.Drawing.Point(170, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MYNGO Aerospace Input Simulator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbRunway
            // 
            this.rbRunway.AutoSize = true;
            this.rbRunway.Checked = true;
            this.rbRunway.Location = new System.Drawing.Point(15, 37);
            this.rbRunway.Name = "rbRunway";
            this.rbRunway.Size = new System.Drawing.Size(64, 17);
            this.rbRunway.TabIndex = 1;
            this.rbRunway.TabStop = true;
            this.rbRunway.Text = "Runway";
            this.rbRunway.UseVisualStyleBackColor = true;
            // 
            // rbWheelsUp
            // 
            this.rbWheelsUp.AutoSize = true;
            this.rbWheelsUp.Location = new System.Drawing.Point(15, 61);
            this.rbWheelsUp.Name = "rbWheelsUp";
            this.rbWheelsUp.Size = new System.Drawing.Size(78, 17);
            this.rbWheelsUp.TabIndex = 2;
            this.rbWheelsUp.Text = "Wheels Up";
            this.rbWheelsUp.UseVisualStyleBackColor = true;
            // 
            // lblFlightStatus
            // 
            this.lblFlightStatus.Controls.Add(this.rbEmergency);
            this.lblFlightStatus.Controls.Add(this.rbLanding);
            this.lblFlightStatus.Controls.Add(this.rbCruising);
            this.lblFlightStatus.Controls.Add(this.rbRunway);
            this.lblFlightStatus.Controls.Add(this.rbWheelsUp);
            this.lblFlightStatus.Location = new System.Drawing.Point(123, 104);
            this.lblFlightStatus.Name = "lblFlightStatus";
            this.lblFlightStatus.Size = new System.Drawing.Size(255, 169);
            this.lblFlightStatus.TabIndex = 3;
            this.lblFlightStatus.TabStop = false;
            this.lblFlightStatus.Text = "Flight Status";
            // 
            // rbCruising
            // 
            this.rbCruising.AutoSize = true;
            this.rbCruising.Location = new System.Drawing.Point(15, 85);
            this.rbCruising.Name = "rbCruising";
            this.rbCruising.Size = new System.Drawing.Size(62, 17);
            this.rbCruising.TabIndex = 3;
            this.rbCruising.Text = "Cruising";
            this.rbCruising.UseVisualStyleBackColor = true;
            // 
            // rbLanding
            // 
            this.rbLanding.AutoSize = true;
            this.rbLanding.Location = new System.Drawing.Point(15, 108);
            this.rbLanding.Name = "rbLanding";
            this.rbLanding.Size = new System.Drawing.Size(63, 17);
            this.rbLanding.TabIndex = 4;
            this.rbLanding.Text = "Landing";
            this.rbLanding.UseVisualStyleBackColor = true;
            // 
            // rbEmergency
            // 
            this.rbEmergency.AutoSize = true;
            this.rbEmergency.Location = new System.Drawing.Point(15, 132);
            this.rbEmergency.Name = "rbEmergency";
            this.rbEmergency.Size = new System.Drawing.Size(78, 17);
            this.rbEmergency.TabIndex = 5;
            this.rbEmergency.Text = "Emergency";
            this.rbEmergency.UseVisualStyleBackColor = true;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(120, 299);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(114, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination IP Address";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(123, 316);
            this.txtIP.MaxLength = 16;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(255, 20);
            this.txtIP.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(301, 389);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(111, 26);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblFlightStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Input Simulation ";
            this.lblFlightStatus.ResumeLayout(false);
            this.lblFlightStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbRunway;
        private System.Windows.Forms.RadioButton rbWheelsUp;
        private System.Windows.Forms.GroupBox lblFlightStatus;
        private System.Windows.Forms.RadioButton rbEmergency;
        private System.Windows.Forms.RadioButton rbLanding;
        private System.Windows.Forms.RadioButton rbCruising;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
    }
}

