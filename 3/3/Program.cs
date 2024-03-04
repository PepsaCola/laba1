namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 13, -1, -45, 2, 0, -2, 3, 4,125, 5,23,12,15, 6,56, 7,111,123 };
            List<int> newlist = new List<int>();
            var positive = list.Where(i=>i>9&&i<100).OrderBy(i=>i);
            foreach(int i in positive)
            {
                Console.WriteLine(i);
            }
            


        }
    }
}
