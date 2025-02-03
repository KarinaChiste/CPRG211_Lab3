using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Animal
    {
        public string Name {  get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public Animal(string name, string colour, int age) 
        {
            Name = name; 
            Colour = colour; 
            Age = age;
        }

        public abstract void Eat();
    }
}
