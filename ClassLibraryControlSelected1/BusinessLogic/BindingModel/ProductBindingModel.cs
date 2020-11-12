﻿using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BindingModel
{
    public class ProductBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int? Count { get; set; }

        public Category Category { get; set; }
    }
}
