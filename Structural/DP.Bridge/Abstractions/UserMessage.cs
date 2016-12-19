namespace DP.Bridge.Abstractions
{
    class UserMessage : Message
    {
        public string Comments { get; set; }

        public override void Send()
        {
            string fullBody = $"{Body}\nUser Comments: {Comments}";
            MessageSender.Handle(Subject, fullBody);
        }
    }
}
