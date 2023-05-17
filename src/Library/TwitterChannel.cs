namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            var twitter = new TwitterMessage();
            twitter.SendMessage(message.Text, message.To);
        }
    }
}
