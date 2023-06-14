using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FmPublishNotification : Form
    {
        public bool IsToPublish { get; private set; }
        public string Message { get; private set; }
        public FmPublishNotification()
        {
            InitializeComponent();
        }

        private void BtnPublishNotification_Click(object sender, EventArgs e)
        {
            IsToPublish = true;
            Message = TxtNotificationContent.Text.Trim();
            Close();
        }

        private void BtnExitOfPublish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FmPublishNotification_Load(object sender, EventArgs e)
        {
            TxtNotificationContent.Text = string.Empty;
            IsToPublish = false;
            Message = string.Empty;
        }
    }
}
