using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CreatingLinkedList<M>
    {
        public int count = 0;

        public Node<M> head;
        public void AddToFirst(M data)
        {
            Node<M> node = new Node<M>(data);
            node.next = head;
            head = node;
            count++;
        }
        public void AddToLast(M Value)
        {
            Node<M> temp = new Node<M>(Value);

            temp.data = Value;
            temp.next = null;
       
            if (head == null)
            {
                head = temp;
            }
            else
            {
                Node<M> temp1 = new Node<M>(Value);
                temp1 = head;
                while (temp1.next != null)
                    temp1 = temp1.next;

                temp1.next = temp;
            }
            count++;
        }

        public void display()
        {
            Node<M> temp1 = head;
            while (temp1 != null)
            {
                Console.Write("->{0}", temp1.data);
                temp1 = temp1.next;
            }
        }
    }
}
   
