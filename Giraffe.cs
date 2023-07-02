using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public class Giraffe: Mammals 
    {
      

        
        public override string Name => "Giraffe";
    public override string Type => "herbivorous mammal";
    public override string Food => "herbivore";
    public override string Eat()
    {
        Console.WriteLine("The Giraffe is eating.");
            return "The Giraffe is eating.";
    }
    public override string Move()
    {
        Console.WriteLine("The Giraffe is walking.");
            return "The Giraffe is walking.";
    }
    public override void Display()
    {
        base.Display();
    }
}
}

