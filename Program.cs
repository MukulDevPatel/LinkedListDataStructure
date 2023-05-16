
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

            //For insertion process
            int targetValue = 30;
            int newData = 40;
            linkedList.InsertNumAtParticularPosition(targetValue, newData);
            Console.WriteLine("Insert value {1} after {0} value.",targetValue,newData);
            linkedList.Display();

            //For deletion process
            int deletionVal = 40;
            linkedList.Remove(deletionVal);
            Console.WriteLine("Remove From the list: "+deletionVal);
            linkedList.Display();

            //For check size of list
            int elementSize = linkedList.Size();
            Console.WriteLine("Size of integer value: {0}", elementSize);
        }
    }
}
