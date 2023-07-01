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
    public override void Eat()
    {
        Console.WriteLine("The Giraffe is eating.");
    }
    public override void Move()
    {
        Console.WriteLine("The Giraffe is walking.");
    }
    public override void Display()
    {
        base.Display();
    }
}
}

