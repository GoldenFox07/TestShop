using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class TV : Equipment
    {
        int Diagoal { get; set; }
        int Resolution { get; set; }
        string Fabricator { get; set; }

        TV(string name, int width, int height, int price, int vendorcode, int diagonal, string fabricator, int resolution):base(name, width, height, price, vendorcode)
        {
            Diagoal = diagonal;
            Resolution = resolution;
            Fabricator = fabricator;
        }
    }
}
