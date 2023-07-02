using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
    public class Chicken : Birds
    {
        public override string Name => "Chicken";
        public override string Type => "DomesticBird";
        public override string Food => "crumbles";
        public override string Eat()
        {
            Console.WriteLine("The Chicken is eating.");
            return "The Chicken is eating.";
        }
        public override string Move()
        {
            Console.WriteLine("The Chicken is Walking.");
            return "The Chicken is Walking.";
        }
        public override string Fly()
        {
            Console.WriteLine("The Chicken is cant fly.");
            return "The Chicken is cant fly.";
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
