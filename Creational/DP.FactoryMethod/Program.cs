using DP.FactoryMethod.Creators;
using System;
using System.Collections.Generic;

namespace DP.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<Document>();
            documents.Add(new Resume());
            documents.Add(new Report());

            foreach (var doc in documents)
            {
                Console.WriteLine($"== {doc} ==");
                foreach (var page in doc.Pages)
                {
                    Console.WriteLine($" - {page}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
