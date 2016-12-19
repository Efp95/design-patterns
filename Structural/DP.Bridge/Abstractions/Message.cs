using DP.Bridge.Implementations;

namespace DP.Bridge.Abstractions
{
    abstract class Message : IMessage
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public IMessageSender MessageSender { get; set; }


        public abstract void Send();
    }
}
