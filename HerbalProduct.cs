﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_part2
{
    public class HerbalProduct: Product 
    {
         string herbsUsed;
         DateTime mfDate;
         DateTime expDate;

        public new void ShowDetails()
        {
            base.ShowDetails(); 
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
            Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
        }

        public void SetInformation(int id, string name, double price, string herbs, DateTime mf, DateTime exp)
        {
            base.SetInformation(id, name, price); 
            herbsUsed = herbs;
            mfDate = mf;
            expDate = exp;
        }

    }
}
