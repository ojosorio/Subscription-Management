using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FmManageSubscription : Form
    {
        public Publisher Publisher { get; private set; }
        public List<SendViaEmail> SendViaEmailsList { get; private set; }
        public List<SendViaMobile> SendViaMobileList { get; private set; }

        public FmManageSubscription()
        {
            InitializeComponent();
            Publisher = new Publisher();
            SendViaEmailsList = new List<SendViaEmail>();
            SendViaMobileList = new List<SendViaMobile>();
        }

        private void FmManageSubscription_Load(object sender, EventArgs e)
        {
            LblInvalidEmail.Hide();
            LblInvalidNumber.Hide();
            LblInvalid.Hide();
            TxtEmail.Text = string.Empty;
            TxtSMS.Text = string.Empty;
            ChkByEmail.Checked = true;
        }

        private void ChkByEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkByEmail.Checked)
            {
                ChkBySMS.Checked = false;
                ChkBySMS.Enabled = false;
                TxtSMS.Enabled = false;
                TxtSMS.Text = string.Empty;
                LblInvalidNumber.Hide();
            }
            else
            {
                TxtSMS.Enabled = true;
                ChkBySMS.Enabled = true;
            }
        }

        private void ChkBySMS_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBySMS.Checked)
            {
                ChkByEmail.Checked = false;
                ChkByEmail.Enabled = false;
                TxtEmail.Enabled = false;
                TxtEmail.Text = string.Empty;
                LblInvalidEmail.Hide();
            }
            else
            {
                TxtEmail.Enabled = true;
                ChkByEmail.Enabled = true;
            }
        }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            ResetAllInvalidLabels();

            if (IsFormComplete() && ChkByEmail.Checked && IsEmailValid() && IsEmailSubscribed(TxtEmail.Text.Trim()))
            {
                LblInvalid.Hide();
                SendViaEmail sendViaEmail = new SendViaEmail(TxtEmail.Text.Trim());
                sendViaEmail.Subscribe(Publisher);
                SendViaEmailsList.Add(sendViaEmail);
                MessageBox.Show("Email Address Subscribed Successfully");
                Close();
            }

            if (IsFormComplete() && ChkBySMS.Checked && IsPhoneValid() && IsPhoneSubscribed(TxtSMS.Text.Trim()))
            {
                LblInvalid.Hide();
                SendViaMobile sendViaMobile = new SendViaMobile(TxtSMS.Text.Trim());
                sendViaMobile.Subscribe(Publisher);
                SendViaMobileList.Add(sendViaMobile);
                MessageBox.Show("Phone Subscribed Successfully");
                Close();
            }
        }

        private void BtnUnsubscribe_Click(object sender, EventArgs e)
        {
            ResetAllInvalidLabels();
            if (!IsFormComplete()) return;

            SendViaEmail sendViaEmail = SendViaEmailsList.FirstOrDefault(f => f.EmailAddress == TxtEmail.Text.Trim());

            if (ChkByEmail.Checked && IsEmailValid() && sendViaEmail != null)
            {
                SendViaEmailsList.Remove(sendViaEmail);
                sendViaEmail.UnSubscribe(Publisher);
                LblInvalid.Hide();
                MessageBox.Show("Email Address Unsubscribed Successfully");
                Close();
            }
            else if (ChkByEmail.Checked && IsEmailValid())
            {
                LblInvalid.Text = "*Email address Has Not Been Subscribed";
                LblInvalid.Show();
            }

            SendViaMobile sendViaMobile = SendViaMobileList.FirstOrDefault(f => f.CellPhone == TxtSMS.Text.Trim());

            if (ChkBySMS.Checked && sendViaMobile != null)
            {
                SendViaMobileList.Remove(sendViaMobile);
                sendViaMobile.UnSubscribe(Publisher);
                LblInvalid.Hide();
                MessageBox.Show("Phone Unsubscribed Successfully");
                Close();
            }
            else if (ChkBySMS.Checked)
            {
                LblInvalid.Text = "*Phone Has Not Been Subscribed";
                LblInvalid.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsFormComplete()
        {
            if ((!ChkByEmail.Checked && !ChkBySMS.Checked) || (ChkByEmail.Checked && string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                    || (ChkBySMS.Checked && string.IsNullOrEmpty(TxtSMS.Text.Trim())))
            {
                LblInvalid.Text = "*Complete Fields";
                LblInvalid.Show();
                return false;
            }

            return true;
        }

        private bool IsEmailValid()
        {
            Regex regexExpression;

            regexExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (regexExpression.IsMatch(TxtEmail.Text.Trim()))
            {
                LblInvalidEmail.Hide();
                return true;
            }
            else
            {
                LblInvalidEmail.Show();
                TxtEmail.Focus();
                return false;
            }
        }

        private bool IsPhoneValid()
        {
            Regex regexExpression;

            regexExpression = new Regex(@"^[0-9]{9,10}$");

            if (regexExpression.IsMatch(TxtSMS.Text.Trim()))
            {
                LblInvalidNumber.Hide();
                return true;
            }
            else
            {
                LblInvalidNumber.Show();
                TxtSMS.Focus();
                return false;
            }
        }

        private bool IsEmailSubscribed(string subscription)
        {
            if (SendViaEmailsList.Any(s => s.EmailAddress.ToLower() == subscription.Trim().ToLower()))
            {
                LblInvalid.Text = "*Email Address Already Subscribed";
                LblInvalid.Show();
                return false;
            }

            LblInvalid.Text = string.Empty;
            return true;
        }

        private bool IsPhoneSubscribed(string subscription)
        {
            if (SendViaMobileList.Any(s => s.CellPhone == subscription.Trim()))
            {
                LblInvalid.Text = "*Phone Already Subscribed";
                LblInvalid.Show();
                return false;
            }

            LblInvalid.Text = string.Empty;
            return true;
        }

        private void ResetAllInvalidLabels()
        {
            LblInvalid.Hide();
            LblInvalidEmail.Hide();
            LblInvalidNumber.Hide();
        }

    }
}
