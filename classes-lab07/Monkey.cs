using Lab06_zoo.Interfaces_lab07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo.classes_lab07
{
    public class Monkey : Mammals, Families, Living
    {
        public string Activity()
        {
            Console.WriteLine("The Monkey swing or climb on trees");
            return "The Monkey swing or climb on trees";

        }

        public string bodyCover()
        {
            Console.WriteLine("Monkeys have skin and fur");
            return "Monkeys have skin and fur";

        }

        public string family()
        {
            Console.WriteLine("Monkeys belong to the family Cebidae");
            return "Monkeys belong to the family Cebidae";

        }

        public bool LivesInGroups()
        {
            return true;
        }

        public string Place()
        {
            Console.WriteLine("The Monkey Lives In tropical rainforests");
            return "tropical rainforests";

        }
        public override string Move()
        {
            Console.WriteLine("The Monkey is walking.");
            return "The Monkey is walking.";
        }
    }
}
