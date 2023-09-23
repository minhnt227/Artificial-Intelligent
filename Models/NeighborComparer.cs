using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring.Models
{
    public class NeighborComparer : IComparer<Country>
    {
        public int Compare(Country o1, Country o2)
        {
            return o1.neighbor.Count.CompareTo(o2.neighbor.Count);
        }
    }
}
