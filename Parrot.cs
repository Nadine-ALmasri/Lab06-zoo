using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public class Parrot: Birds
    {
        public override string Name => "Parrot";
        public override string Type => "Birds";
        public override string Food => "crumbles";
        public override string Eat()
        {
            Console.WriteLine("The Parrot is eating.");
            return "The Parrot is eating.";
        }
        public override string Move()
        {
            Console.WriteLine("The Parrot is flying.");
            return "The Parrot is flying.";
        }
        public override string Fly()
        {
            Console.WriteLine("The Parrot is flying.");
            return "The Parrot is flying.";
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
