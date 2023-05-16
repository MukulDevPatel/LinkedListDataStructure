
namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Data Structure");

            SortedLinkedList<int> linkedList = new SortedLinkedList<int>();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(40);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}
