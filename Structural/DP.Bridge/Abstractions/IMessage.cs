using DP.Bridge.Implementations;

namespace DP.Bridge.Abstractions
{
    interface IMessage
    {
        string Subject { get; set; }
        string Body { get; set; }
        IMessageSender MessageSender { get; set; }

        void Send();
    }
}
