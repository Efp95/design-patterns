using System;

namespace DP.Bridge.Implementations
{
    class EmailSender : IMessageSender
    {
        public void Handle(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }
}
