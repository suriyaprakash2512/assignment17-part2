using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_part2
{
    public class Product
    {
         int pid;
         string pname;
         double pprice;

        public void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: {pprice}");
        }

        public void SetInformation(int id, string name, double price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }

    }
}
