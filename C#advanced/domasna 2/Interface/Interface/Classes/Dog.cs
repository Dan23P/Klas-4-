using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal class Dog : Animal, IDog
    {
        public override void PrintAnimal()
        {
            Console.WriteLine($"The dogs name is {Name} he is {Age} years old");
        }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
    }

}
