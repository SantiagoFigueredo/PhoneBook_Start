namespace Library
{
    public class WhatsAppChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send(message.To, message.Text);
        }
    }
}
