using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<M>
    {

        public M data;

        public Node<M> next;

        public Node(M data)
        {
             this.data = data;
        }
    }
}

