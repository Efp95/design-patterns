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
            
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }
            
            LoadBalancer balancer = LoadBalancer.Instance;
            for (int i = 0; i < 35; i++)
            {
                string serverName = balancer.AvailableServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }
            
            Console.ReadLine();
        }
    }
}
