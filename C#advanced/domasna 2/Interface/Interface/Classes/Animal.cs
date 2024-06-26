﻿using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    abstract class Animal : IAnimal 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void PrintAnimal();
    }
}
