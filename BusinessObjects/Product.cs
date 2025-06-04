﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public short? UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public virtual Category Category { get; set; }

        public Product(int id, string name, int catId, short unitInStock, decimal price)
        {
            ProductId = id;
            ProductName = name;
            CategoryId = catId;
            UnitsInStock = unitInStock;
            UnitPrice = price;
        }

    }
}
