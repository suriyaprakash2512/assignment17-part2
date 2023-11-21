using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();
            herbalProduct.SetInformation(222, "Herbal Shampoo", 780.50, "Aloe Vera", 
                         DateTime.Parse("2023-12-01"), DateTime.Parse("2025-01-01"));
            Console.WriteLine("Herbal Product Details:");
            herbalProduct.ShowDetails();
            Console.ReadKey();

        }
    }
}
