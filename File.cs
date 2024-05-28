using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    public class File : IComponent
    {
        public string Name { get; set; }
        public double Size { get; set; }

        public File(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public double GetSize()
        {
            return Size;
        }
    }
}