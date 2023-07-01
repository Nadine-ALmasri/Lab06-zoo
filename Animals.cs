using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public abstract class Animals
    {  public virtual string Name { get; set; }
        public virtual string Type { get; set; }
      
        public virtual string Food { get; set; }
      
        public virtual void Display () { 
            Console.WriteLine($"Name is {Name} ");
            Console.WriteLine ($"Type is {Type} ");
            Console.WriteLine ($"Food is {Food}");
          
        }
        public virtual void Move() { 
        }
        public virtual void Eat()
        {
        }
    }
}
