using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public class SendViaMobile
    {
        public string CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(string phone)
        {
            CellPhone = phone;
        }

        private void SendMessage(string msg)
        {
            MessageBox.Show($"The message {msg} has already texted to {CellPhone}");
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.publishMessage += SendMessage;
        }

        public void UnSubscribe(Publisher publisher)
        {
            publisher.publishMessage -= SendMessage;
        }
    }
}