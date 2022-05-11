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
        public void Insert(M Value, int Position)
        {
            Node<M> newNode = new Node<M>(Value);
            newNode.data = Value;
            newNode.next = null;

            if (Position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (Position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                Node<M> temp = new Node<M>(Value);
                temp = head;
                for (int i = 1; i < Position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }
        public void Insert40(int searchvalue, M newValue)
        {
            Node<M> temp = head;
            int found = 0;
            int i = 0;
            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data.Equals(searchvalue))
                    {
                        found++;
                        Node<M> newNode = new Node<M>(newValue);
                        newNode.data = newValue;
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;

                    }
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }

        }
        public void  DeleteFirst()
        {
            Node<M> tempnode = head;
            if (head != null)
            {
                tempnode = head;
                head = head.next;
                tempnode = null;
            }
            count--;

        }
        public void DeleteLast()
        {
            if (head == null)
                return;

            if (head.next == null)
            {
                return;
            }
            Node<M> second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;
            second_last.next = null;
        }
        public bool Search(int searchposition)
        {
            Node<M> temp = head;
            int i = 0;
            bool status = false;
            int found = 0;
            if (head == null)
            {
                Console.WriteLine("List Underflow");
            }
            else
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data.Equals(searchposition))
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;

                }
                if (found == 1)
                {
                    status = true;
                    Console.WriteLine("Searching Element is " + searchposition);
                    Console.WriteLine(searchposition + " found at position " + i + "\n");
                }
                else
                {
                    Console.WriteLine(searchposition + " Not found");
                }
            }
            return status;
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
   
