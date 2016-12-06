using DP.FactoryMethod.Products;
using System.Collections.Generic;

namespace DP.FactoryMethod.Creators
{
    abstract class Document
    {
        public Document()
        {
            Pages = new List<Page>();
            CreatePages();
        }

        public List<Page> Pages { get; }

        public abstract void CreatePages();

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
