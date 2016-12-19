using DP.Bridge.Abstractions;
using DP.Bridge.Implementations;
using System;

namespace DP.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender queueSender = new MSMQSender();
            IMessageSender emailSender = new EmailSender();
            IMessageSender webSender = new WebServiceSender();

            #region [System Message]
            IMessage systemMessage = new SystemMessage
            {
                Subject = "Test Message From System",
                Body = "Just a simple system message based on Bridge Pattern"
            };

            systemMessage.MessageSender = queueSender;
            systemMessage.Send();

            systemMessage.MessageSender = emailSender;
            systemMessage.Send();

            systemMessage.MessageSender = webSender;
            systemMessage.Send();
            #endregion

            #region [User Message]
            IMessage userMessage = new UserMessage
            {
                Subject = "Test Message From User",
                Body = "Just a simple user message based on Bridge Pattern",
                Comments = "Best example I found"
            };

            userMessage.MessageSender = queueSender;
            userMessage.Send();

            userMessage.MessageSender = emailSender;
            userMessage.Send();

            userMessage.MessageSender = webSender;
            userMessage.Send();
            #endregion

            Console.ReadLine();
        }
    }
}
