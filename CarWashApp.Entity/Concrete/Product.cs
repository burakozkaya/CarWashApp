﻿using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock {  get; set; }
        public int WarningStock { get; set; }

    }
}
