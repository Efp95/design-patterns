using System;

namespace DP.Bridge.Implementations
{
    class MSMQSender : IMessageSender
    {
        public void Handle(string subject, string body)
        {
            Console.WriteLine($"MSMQ\n{subject}\n{body}\n");
        }
    }
}
