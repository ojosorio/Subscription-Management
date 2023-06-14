using System.Windows.Forms;

namespace Lab2
{
    partial class FmPublishNotification
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
            this.BtnPublishNotification = new System.Windows.Forms.Button();
            this.BtnExitOfPublish = new System.Windows.Forms.Button();
            this.TxtNotificationContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPublishNotification
            // 
            this.BtnPublishNotification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPublishNotification.Location = new System.Drawing.Point(89, 130);
            this.BtnPublishNotification.Name = "BtnPublishNotification";
            this.BtnPublishNotification.Size = new System.Drawing.Size(159, 45);
            this.BtnPublishNotification.TabIndex = 2;
            this.BtnPublishNotification.Text = "Publish Notification";
            this.BtnPublishNotification.UseVisualStyleBackColor = true;
            this.BtnPublishNotification.Click += new System.EventHandler(this.BtnPublishNotification_Click);
            // 
            // BtnExitOfPublish
            // 
            this.BtnExitOfPublish.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnExitOfPublish.Location = new System.Drawing.Point(292, 130);
            this.BtnExitOfPublish.Name = "BtnExitOfPublish";
            this.BtnExitOfPublish.Size = new System.Drawing.Size(159, 45);
            this.BtnExitOfPublish.TabIndex = 3;
            this.BtnExitOfPublish.Text = "Exit";
            this.BtnExitOfPublish.UseVisualStyleBackColor = true;
            this.BtnExitOfPublish.Click += new System.EventHandler(this.BtnExitOfPublish_Click);
            // 
            // TxtNotificationContent
            // 
            this.TxtNotificationContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtNotificationContent.Location = new System.Drawing.Point(214, 43);
            this.TxtNotificationContent.Multiline = true;
            this.TxtNotificationContent.Name = "TxtNotificationContent";
            this.TxtNotificationContent.Size = new System.Drawing.Size(267, 71);
            this.TxtNotificationContent.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Notification Content";
            // 
            // FmPublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNotificationContent);
            this.Controls.Add(this.BtnExitOfPublish);
            this.Controls.Add(this.BtnPublishNotification);
            this.Name = "FmPublishNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish Notification";
            this.Load += new System.EventHandler(this.FmPublishNotification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPublishNotification;
        private Button BtnExitOfPublish;
        private TextBox TxtNotificationContent;
        private Label label1;
    }
}