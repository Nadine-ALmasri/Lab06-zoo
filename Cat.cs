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
        public override void Eat()
        {
            Console.WriteLine("The cat is eating.");
        }
        public override void Move()
        {
            Console.WriteLine("The cat is walking.");
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
