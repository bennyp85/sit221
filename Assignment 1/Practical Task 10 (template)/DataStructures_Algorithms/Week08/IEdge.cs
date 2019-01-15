using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Week08
{
    public interface IEdge<T,K>
    {
        INode<T> From { get;}
        INode<T> To { get;}
        K Data { get; set; }
    }
}
