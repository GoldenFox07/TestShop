using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
       public virtual string Fio { get; protected set; }

       public virtual int Id { get; protected set; }

       public virtual string Date { get; protected set; }

       public virtual int Num { get; protected set; }
    }
}
