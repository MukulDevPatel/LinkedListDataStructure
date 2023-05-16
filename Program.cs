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

            int targetValue = 30;
            Node searchNode = linkedList.Search(targetValue);
            if (searchNode != null)
            {
                Console.WriteLine("Searched element key: {0}", targetValue);
            }else
            {
                Console.WriteLine("Searched element key {0} is not add.", targetValue);
            }
        }
    }
}
