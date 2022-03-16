using Laptop.Class;
using System;

namespace Laptop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            laptop comp = new laptop();
            {   
                comp.brand = "Asus Rog Strix";
                comp.videokarta = "RTX 2070";
                comp.processor = "Core i7 - 9th";
                comp.ram = "16 GB DDR4";
                comp.hardDrive = "512 SSD";
                comp.displaySize = 15.6;

                comp.FullName();
            }

        }
        
   
    
    }
}
