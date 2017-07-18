using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    abstract class Equipment
    {
        string name { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        int Price { get; set; }
        int VendorCode {get; set; }
        
        public Equipment(string name, int width, int height, int price, int vendorcode)
        {
            Width = width;
            Height = height;
            Price = price;
            VendorCode = vendorcode;
        }
    }
}
