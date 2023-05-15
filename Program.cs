namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Data Structure");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();
        }
    }
}
