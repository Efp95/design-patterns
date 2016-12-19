namespace DP.Bridge.Abstractions
{
    class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.Handle(Subject, Body);
        }
    }
}
