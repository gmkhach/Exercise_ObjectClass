using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Product
    {
        public string ProductName { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
