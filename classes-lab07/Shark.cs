using Lab06_zoo.Interfaces_lab07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
    public class Shark : Fishes, Families, Living
    {
        public string Activity()
        {
            Console.WriteLine("The Shark Do Swiming");
            return "The Shark Do Swiming";

        }

        public string bodyCover()
        {
            Console.WriteLine("The Shark body covers by V-shaped scales");
            return "V-shaped scales";

        }

        public string family()
        {
            Console.WriteLine("The Shark is belong to Fishes");
            return "Fish";

        }

        public bool LivesInGroups()
        {
            return false;
        }

        public string Place()
        {
            Console.WriteLine("The Shark Lives In ocean habitats");
            return "ocean habitats";

        }
        public override string Eat()
        {
            Console.WriteLine("The Shark is Eating");
            return "The Shark is Eating";
        }
    }
}
