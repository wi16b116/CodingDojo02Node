using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo02Node.NodeStack
{
    class NodeElement<T>
    {
        public NodeElement<T> NextNode { get; set; }
        public T ValueOfNode { get; set; }
    }
}
