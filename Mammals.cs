using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_zoo
{
   public abstract class Mammals : Animals
    {
        public virtual int NumberOfLegs { get; set; }
    }
}
