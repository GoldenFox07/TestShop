using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
     public class Stock
    {
        public virtual int VendorCode { get; set; }

        public virtual int Quantity { get; set; }

        public virtual string Fabricator { get; set; }

        public virtual string Name { get; set; }
    }
}
