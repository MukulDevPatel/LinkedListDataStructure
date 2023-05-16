namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Data Structure");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

            int poppedElement = linkedList.PopLast();
            Console.WriteLine("Element removed: {0}", poppedElement);
            linkedList.Display();
        }
    }
}
