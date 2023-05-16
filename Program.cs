
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
            int newData = 40;
            linkedList.InsertNumAtParticularPosition(targetValue, newData);
            Console.WriteLine("Insert value {1} after {0} value.",targetValue,newData);
            linkedList.Display();
        }
    }
}
