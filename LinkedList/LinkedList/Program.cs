// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("Introducing LinkedList!");
while (true)
{
    Console.WriteLine("PLease choose the option :\n1)Creating LinkedList\n2)Adding Node To First Position\n3)Creating LinkedList By Appending\n4)Inserting Value\n5)Delete First value");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            CreatingLinkedList<int> Lvalue = new();
            Lvalue.AddToLast(56);
            Lvalue.AddToLast(30);
            Lvalue.AddToLast(70);
            int length = Lvalue.count;
            Console.WriteLine("Number of elements in the LinkedList are: {0}", length);
            Lvalue.display();
            Console.WriteLine("\n");
            break;
        case 2:
            CreatingLinkedList<int> Lvalue1 = new();
            Lvalue1.AddToFirst(70);
            Lvalue1.AddToFirst(30);
            Lvalue1.AddToFirst(56);
            int length1 = Lvalue1.count;
            Console.WriteLine("Number of elements in the LinkedList are: {0}", length1);
            Lvalue1.display();
            Console.WriteLine("\n");
            break;
        case 3:
            CreatingLinkedList<int> Lvalue2 = new();
            Lvalue2.head = new Node<int>(56);
            Node<int> temp1 = new Node<int>(30);
            Node<int> temp2 = new Node<int>(70);
            Lvalue2.head.next = temp1;
            temp1.next = temp2;
            temp2.next = null;
            Console.Write("Elements in LinkedList are : ");
            Lvalue2.display();
            Console.WriteLine("\n");
            break;
        case 4:
            CreatingLinkedList<int> Lvalue3 = new();
            Lvalue3.AddToFirst(70);
            Lvalue3.AddToFirst(56);
            Lvalue3.Insert(30, 2);
            Console.Write("Elements in LinkedList are : ");
            Lvalue3.display();
            Console.WriteLine("\n");
            break;
        case 5:
            CreatingLinkedList<int> Lvalue4 = new();
            Lvalue4.AddToFirst(56);
            Lvalue4.AddToFirst(30);
            Lvalue4.AddToFirst(70);
            Console.WriteLine("Number of elements in the LinkedList are: {0}", Lvalue4.count);
            Console.Write("Elements in LinkedList are : ");
            Lvalue4.display();
            Console.WriteLine("\n------------------------------------------------------------------------");
            Lvalue4.DeleteFirst(56);
            Console.WriteLine("Number of elements in the LinkedList are: {0}", Lvalue4.count);
            Console.Write("Elements in LinkedList are : ");
            Lvalue4.display();
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("Worng Input!");
            break;
    }
}
