using DP.Singleton.Products;
using System;

namespace DP.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.Instance;
            var b2 = LoadBalancer.Instance;
            var b3 = LoadBalancer.Instance;
            var b4 = LoadBalancer.Instance;

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            LoadBalancer balancer = LoadBalancer.Instance;
            for (int i = 0; i < 35; i++)
            {
                string serverName = balancer.AvailableServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
