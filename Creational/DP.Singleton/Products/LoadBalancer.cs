using System;
using System.Collections.Generic;

namespace DP.Singleton.Products
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer _instance = new LoadBalancer();

        private IList<Server> _servers;
        private Random _random = new Random();

        static LoadBalancer()
        {
        }
        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                 new Server{ Name = "ServerI", IpAddress = "121.14.220.5" },
                 new Server{ Name = "ServerII", IpAddress = "121.14.220.6" },
                 new Server{ Name = "ServerIII", IpAddress = "121.14.220.7" },
                 new Server{ Name = "ServerIV", IpAddress = "121.14.220.8" },
                 new Server{ Name = "ServerV", IpAddress = "121.14.220.9" }
            };
        }

        public static LoadBalancer Instance => _instance;

        public Server AvailableServer
        {
            get
            {
                int randomIndex = _random.Next(_servers.Count);
                return _servers[randomIndex];
            }
        }
    }
}
