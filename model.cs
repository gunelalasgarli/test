using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinconsoletask
{
    class Model
    {
        public readonly int Id;

        public TypeModel TypeName { get; set; }
        public string Name { get; set; }
        public string Color;
        public static int count;
        public int Count;
        public double Price { get; set; }
        public int Year;


        public Model()
        {
            count++;
            Id = count;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Count} {Color} {Year}";
        }
    }
}
