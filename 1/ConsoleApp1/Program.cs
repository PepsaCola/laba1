namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "привіт мій друж3. Сідай поговоримо, ро3кажеш, як в тебе справи 13аі ";
            Console.WriteLine(text);
            Dictionary<int, string> dic = new Dictionary<int, string>();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                dic.Add(i, words[i]);
            }
            Console.WriteLine(dic.Count);
            Console.WriteLine("Введіть число від 0 до {0} ",words.Length-1);
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("Оберіть напрям руху (верх чи низ)");
            string upOrDown = Console.ReadLine();
            if (upOrDown == "верх")
            {
                for (int i = choise; i >= 0; i--)
                {
                    Console.WriteLine(dic[i]);
                }
            }
            else
            {
                for (int i = choise;i<dic.Count; i++)
                {
                    Console.WriteLine(dic[i]);
                }
            }


        }
    }
}
