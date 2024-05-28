using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_DesignPattern
{
    public class Folder : IComponent
    {
        public string Name { get; set; }
        public List<IComponent> Components { get; set; }

        public Folder(string name)
        {
            Name = name;
            Components = new List<IComponent>();
        }

        public double GetSize()
        {
            double toReturn = 0;
            foreach (IComponent leaf in Components)
            {
                toReturn += leaf.GetSize();
            }
            return toReturn;
        }
    }
}