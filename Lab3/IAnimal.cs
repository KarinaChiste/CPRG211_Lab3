﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IAnimal
    {
        
        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        int Age { get; set; }

        abstract void Eat();

        string Cry();
    }
}
