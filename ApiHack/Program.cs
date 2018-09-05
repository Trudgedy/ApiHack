using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiHack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            DictionaryService dict = new DictionaryService();

            dict.CreateDictionary();


            var input = Console.Read();

            //if (input == '')
            //{

            //}
        }
    }
}
