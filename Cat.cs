using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public  class Cat : Mammals 
    {
        public override string Name => "cat";
        public override string Type => "Felidae";
        public override string Food => "meat and milk";
        public override string Eat()
        {
            Console.WriteLine("The cat is eating.");
            return "The cat is eating.";
        }
        public override string Move()
        {
            Console.WriteLine("The cat is walking.");
            return "The cat is walking.";
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
