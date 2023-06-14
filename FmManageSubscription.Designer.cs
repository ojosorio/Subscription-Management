using System.Windows.Forms;

namespace Lab2
{
    partial class FmManageSubscription
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
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.BtnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ChkByEmail = new System.Windows.Forms.CheckBox();
            this.ChkBySMS = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSMS = new System.Windows.Forms.TextBox();
            this.LblInvalidEmail = new System.Windows.Forms.Label();
            this.LblInvalidNumber = new System.Windows.Forms.Label();
            this.LblInvalid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSubscribe.Location = new System.Drawing.Point(57, 202);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(185, 52);
            this.BtnSubscribe.TabIndex = 1;
            this.BtnSubscribe.Text = "Subscribe";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // BtnUnsubscribe
            // 
            this.BtnUnsubscribe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnUnsubscribe.Location = new System.Drawing.Point(268, 202);
            this.BtnUnsubscribe.Name = "BtnUnsubscribe";
            this.BtnUnsubscribe.Size = new System.Drawing.Size(185, 52);
            this.BtnUnsubscribe.TabIndex = 2;
            this.BtnUnsubscribe.Text = "Unsubscribe";
            this.BtnUnsubscribe.UseVisualStyleBackColor = true;
            this.BtnUnsubscribe.Click += new System.EventHandler(this.BtnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(479, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 52);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChkByEmail
            // 
            this.ChkByEmail.AutoSize = true;
            this.ChkByEmail.Location = new System.Drawing.Point(36, 45);
            this.ChkByEmail.Name = "ChkByEmail";
            this.ChkByEmail.Size = new System.Drawing.Size(208, 25);
            this.ChkByEmail.TabIndex = 4;
            this.ChkByEmail.Text = "Notification Sent by Email";
            this.ChkByEmail.UseVisualStyleBackColor = true;
            this.ChkByEmail.CheckedChanged += new System.EventHandler(this.ChkByEmail_CheckedChanged);
            // 
            // ChkBySMS
            // 
            this.ChkBySMS.AutoSize = true;
            this.ChkBySMS.Location = new System.Drawing.Point(36, 96);
            this.ChkBySMS.Name = "ChkBySMS";
            this.ChkBySMS.Size = new System.Drawing.Size(202, 25);
            this.ChkBySMS.TabIndex = 5;
            this.ChkBySMS.Text = "Notification Sent by SMS";
            this.ChkBySMS.UseVisualStyleBackColor = true;
            this.ChkBySMS.CheckedChanged += new System.EventHandler(this.ChkBySMS_CheckedChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(260, 41);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(311, 29);
            this.TxtEmail.TabIndex = 6;
            // 
            // TxtSMS
            // 
            this.TxtSMS.Location = new System.Drawing.Point(260, 92);
            this.TxtSMS.MaxLength = 10;
            this.TxtSMS.Name = "TxtSMS";
            this.TxtSMS.Size = new System.Drawing.Size(311, 29);
            this.TxtSMS.TabIndex = 7;
            // 
            // LblInvalidEmail
            // 
            this.LblInvalidEmail.AutoSize = true;
            this.LblInvalidEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblInvalidEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.LblInvalidEmail.Location = new System.Drawing.Point(260, 70);
            this.LblInvalidEmail.Name = "LblInvalidEmail";
            this.LblInvalidEmail.Size = new System.Drawing.Size(100, 19);
            this.LblInvalidEmail.TabIndex = 8;
            this.LblInvalidEmail.Text = "*Invalid Email";
            // 
            // LblInvalidNumber
            // 
            this.LblInvalidNumber.AutoSize = true;
            this.LblInvalidNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblInvalidNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.LblInvalidNumber.Location = new System.Drawing.Point(260, 122);
            this.LblInvalidNumber.Name = "LblInvalidNumber";
            this.LblInvalidNumber.Size = new System.Drawing.Size(119, 19);
            this.LblInvalidNumber.TabIndex = 9;
            this.LblInvalidNumber.Text = "*Invalid Number";
            // 
            // LblInvalid
            // 
            this.LblInvalid.AutoSize = true;
            this.LblInvalid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblInvalid.ForeColor = System.Drawing.Color.Firebrick;
            this.LblInvalid.Location = new System.Drawing.Point(36, 146);
            this.LblInvalid.Name = "LblInvalid";
            this.LblInvalid.Size = new System.Drawing.Size(60, 19);
            this.LblInvalid.TabIndex = 10;
            this.LblInvalid.Text = "*Invalid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSMS);
            this.groupBox1.Controls.Add(this.LblInvalid);
            this.groupBox1.Controls.Add(this.ChkByEmail);
            this.groupBox1.Controls.Add(this.LblInvalidNumber);
            this.groupBox1.Controls.Add(this.ChkBySMS);
            this.groupBox1.Controls.Add(this.LblInvalidEmail);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 177);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // FmManageSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnUnsubscribe);
            this.Controls.Add(this.BtnSubscribe);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FmManageSubscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.FmManageSubscription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSubscribe;
        private Button BtnUnsubscribe;
        private Button btnCancel;
        private CheckBox ChkByEmail;
        private CheckBox ChkBySMS;
        private TextBox TxtEmail;
        private TextBox TxtSMS;
        private Label LblInvalidEmail;
        private Label LblInvalidNumber;
        private Label LblInvalid;
        private GroupBox groupBox1;
    }
}