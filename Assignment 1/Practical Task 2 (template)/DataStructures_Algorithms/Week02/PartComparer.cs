using System;
using DataStructures_Algorithms.Week01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week02
{
    public class PartComparer : IComparer<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }

        int IComparer<Part>.Compare(Part x, Part y)
        {
                if (x.PartId < y.PartId) return 1;
                else if (x.PartId > y.PartId) return -1;
                else return 0;
        }
    }
}
