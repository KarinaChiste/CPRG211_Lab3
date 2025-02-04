using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Dog2 : IAnimal
    {
        private string colour;
        private string height;
        private int age;
        public string Name { get; set; }
        public string Colour
        {
            get { return colour; }
            set { this.colour = value; }
        }
        public string Height
        {
            get { return height; }
            set { this.height = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public Dog2(string name)
        {
            this.Name = name;
            
        }

        public string Cry()
        {
            return "Woof!";
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
