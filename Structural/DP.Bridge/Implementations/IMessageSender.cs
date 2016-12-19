namespace DP.Bridge.Implementations
{
    interface IMessageSender
    {
        void Handle(string subject, string body);
    }
}
