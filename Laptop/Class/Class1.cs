using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop.Class
{  
   class laptop
   {
       public string brand;
       public string videokarta;
       public string processor;
       public string ram;
       public string hardDrive;
       public double displaySize;
   
       public void FullName()
       {
           Console.WriteLine($"Brand: {brand}\n" +
                             $"Graphics Coprocessor: {videokarta}\n" +
                             $"Processor: {processor}\n" +
                             $"RAM: {ram}\n" +
                             $"Hard Drive: {hardDrive}\n" +
                             $"Standing screen display size: {displaySize} Inches");
       }
   
   
   
   }

}

