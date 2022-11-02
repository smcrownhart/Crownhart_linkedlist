using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_linkedlist
{
    internal class Node
    {
        public Node next;
        public Node previous;
        public string Data;

        public Node(string data)
        {
            Data = data;
            next = null;
            previous = null;
        }
    }
}
