
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FmNotificacionManager : Form
    {
        FmManageSubscription FmManageSubscription;
        FmPublishNotification FmPublishNotification;

        public FmNotificacionManager()
        {
            InitializeComponent();
            FmManageSubscription = new FmManageSubscription();
            FmPublishNotification = new FmPublishNotification();
            BtnPublishNotification.Enabled = false;
        }

        private void BtnManageSubscription_Click(object sender, EventArgs e)
        {
            FmManageSubscription.ShowDialog();
            if (FmManageSubscription.SendViaEmailsList.Count() > 0 || FmManageSubscription.SendViaMobileList.Count() > 0)
            {
                BtnPublishNotification.Enabled = true;
            }
            else
            {
                BtnPublishNotification.Enabled = false;
            }
        }

        private void BtnPublishNotification_Click(object sender, EventArgs e)
        {
            FmPublishNotification.ShowDialog();
            if (FmPublishNotification.IsToPublish)
                FmManageSubscription.Publisher.PublishMessage(FmPublishNotification.Message);
        }

        private void BtnExitOfNotification_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}