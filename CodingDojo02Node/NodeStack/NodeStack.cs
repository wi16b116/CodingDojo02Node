using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo02Node.NodeStack
{
    class NodeStack<T>
    {
        private NodeElement<T> currentNode;

        public void Push(T item)
        {
            if (currentNode == null)
            {
                currentNode = new NodeElement<T> { ValueOfNode = item, NextNode = null };
            }
            else
            {
                NodeElement<T> temp = new NodeElement<T> { ValueOfNode = item, NextNode = currentNode };
                currentNode = temp;
            }
        }
    }
}
