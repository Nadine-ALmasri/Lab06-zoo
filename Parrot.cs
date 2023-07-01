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
        public override void Eat()
        {
            Console.WriteLine("The Parrot is eating.");
        }
        public override void Move()
        {
            Console.WriteLine("The Parrot is flying.");
        }
        public override void Fly()
        {
            Console.WriteLine("The Parrot is flying.");
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
