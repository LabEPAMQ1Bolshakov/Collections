using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Александр", 25);
            myDictionary.Add("Петр", 35);
            myDictionary.Add("Иван", 20);
            myDictionary.Add("Семен", 15);
            myDictionary.Add("Андрей", 5);
            var result =
                    // myDictionary.Keys - коллекция ключей, в нашем случае имён
                from int age in myDictionary.Values
                    // здесь по ключу получаем значение, т.е. возраст
                where string name in myDictionary.Keys == "Иван"
                    // сортируем по имени (по ключу)
                orderby name
                select name;

            foreach (string name in result)
                Console.WriteLine(name); // Выйдет Александр, Иван, Петр
            Console.ReadKey();
        }
    }
}
