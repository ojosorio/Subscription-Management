using System.Windows.Forms;

namespace Lab2
{
    partial class FmNotificacionManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnManageSubscription = new System.Windows.Forms.Button();
            this.BtnPublishNotification = new System.Windows.Forms.Button();
            this.BtnExitOfNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnManageSubscription
            // 
            this.BtnManageSubscription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnManageSubscription.Location = new System.Drawing.Point(31, 67);
            this.BtnManageSubscription.Name = "BtnManageSubscription";
            this.BtnManageSubscription.Size = new System.Drawing.Size(159, 54);
            this.BtnManageSubscription.TabIndex = 0;
            this.BtnManageSubscription.Text = "Manage Subscription";
            this.BtnManageSubscription.UseVisualStyleBackColor = true;
            this.BtnManageSubscription.Click += new System.EventHandler(this.BtnManageSubscription_Click);
            // 
            // BtnPublishNotification
            // 
            this.BtnPublishNotification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPublishNotification.Location = new System.Drawing.Point(216, 67);
            this.BtnPublishNotification.Name = "BtnPublishNotification";
            this.BtnPublishNotification.Size = new System.Drawing.Size(159, 54);
            this.BtnPublishNotification.TabIndex = 1;
            this.BtnPublishNotification.Text = "Publish Notification";
            this.BtnPublishNotification.UseVisualStyleBackColor = true;
            this.BtnPublishNotification.Click += new System.EventHandler(this.BtnPublishNotification_Click);
            // 
            // BtnExitOfNotification
            // 
            this.BtnExitOfNotification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnExitOfNotification.Location = new System.Drawing.Point(399, 67);
            this.BtnExitOfNotification.Name = "BtnExitOfNotification";
            this.BtnExitOfNotification.Size = new System.Drawing.Size(159, 54);
            this.BtnExitOfNotification.TabIndex = 2;
            this.BtnExitOfNotification.Text = "Exit";
            this.BtnExitOfNotification.UseVisualStyleBackColor = true;
            this.BtnExitOfNotification.Click += new System.EventHandler(this.BtnExitOfNotification_Click);
            // 
            // FmNotificacionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 176);
            this.Controls.Add(this.BtnExitOfNotification);
            this.Controls.Add(this.BtnPublishNotification);
            this.Controls.Add(this.BtnManageSubscription);
            this.Name = "FmNotificacionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnManageSubscription;
        private Button BtnPublishNotification;
        private Button BtnExitOfNotification;
    }
}