using System;

namespace DP.Bridge.Implementations
{
    class WebServiceSender : IMessageSender
    {
        public void Handle(string subject, string body)
        {
            Console.WriteLine($"WebService\n{subject}\n{body}\n");
        }
    }
}
