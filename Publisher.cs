
namespace Lab2
{
    public class Publisher
    {
        public delegate void PublishMessageDel(string msg);
        public PublishMessageDel publishMessage = null;

        public void PublishMessage(string message)
        {
            publishMessage.Invoke(message);
        }
    }
}