using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public class Dog : Mammals
    {
        public override string Name => "dog";
        public override string Type => "domestic mammal";
        public override string Food => "meat";
        public override string Eat()
        {
            Console.WriteLine("The dog is eating.");
            return "The dog is eating.";
        }
        public override string Move()
        {
            Console.WriteLine("The dog is walking.");
            return "The dog is walking.";
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
