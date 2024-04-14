using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal class Cat : Animal, ICat
    {
        public override void PrintAnimal()
        {
            Console.WriteLine($"The cats name is {Name} she is {Age} years old");
        }
        public void Eat(string foodOfType)
        {
            Console.Write($"The cat is eating {foodOfType}");
        }

        public static implicit operator string(Cat v)
        {
            throw new NotImplementedException();
        }
    }
}
