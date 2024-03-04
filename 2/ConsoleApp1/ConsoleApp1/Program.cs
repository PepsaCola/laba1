using System.Collections.Immutable;
using Newtonsoft.Json;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>()
            {
                {"л",new List<string>{"липень","листя","лопата" }},
                {"К",new List<string>{"кінь","конюшина","квітка" }},
                {"А",new List<string>{"Андрій","алое","алфавіт" }},
                {"Б",new List<string>{"бобер","будинок","будка" }},
                {"В",new List<string>{"ворона","воля","ворота" }},
            };
            List<string> sortedKeys = new List<string>();
            foreach (string key in dic.Keys)
                {
                    sortedKeys.Add(key);
                }
            sortedKeys.Sort();
            string s = JsonConvert.SerializeObject(sortedKeys);
            Console.WriteLine(s);



        }
    }
}
