namespace LinkedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("LinkedList Data Structure");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.InserNumBetweenInteger(2, 30);
            linkedList.Display();
        }
    }
}
