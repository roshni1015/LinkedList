// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("Introducing LinkedList!");
while (true)
{
    Console.WriteLine("PLease choose the option :\n1)Creating LinkedList");
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
        default:
            Console.WriteLine("Worng Input!");
            break;
    }
}
