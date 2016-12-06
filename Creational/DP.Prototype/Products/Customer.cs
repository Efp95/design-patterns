using DP.Prototype.Prototypes;
using System;

namespace DP.Prototype.Products
{
    [Serializable]
    public class Customer : BaseProtoCloneable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    [Serializable]
    public class Address
    {
        public int Id { get; set; }
        public string Avenue { get; set; }
    }
}
