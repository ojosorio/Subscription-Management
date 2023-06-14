using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class SendViaEmail
    {
        public string EmailAddress { get; set; }
        public SendViaEmail() { }

        public SendViaEmail(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public void SendEmail(string msg)
        {
            MessageBox.Show($"The message {msg} has already sent to {EmailAddress}");
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.publishMessage += SendEmail;
        }

        public void UnSubscribe(Publisher publisher)
        {
            publisher.publishMessage -= SendEmail;
        }
    }

}