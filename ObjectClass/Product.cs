﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Product : EntityBase
    {
        public string ProductName { get; set; }

        public override string ToString()
        {
            return ProductName;
        }

        public override bool Validate()
        {
            return string.IsNullOrEmpty(ProductName) ? false : true;
        }
    }
}
