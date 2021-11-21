using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://ru.wikipedia.org/wiki/%D0%92%D0%B8%D0%BA%D0%B8%D0%BF%D0%B5%D0%B4%D0%B8%D1%8F";
            string urlExample = "https://ru.wikipedia.org/wiki/Википедия The best website";

            string exampleResult = Uri.EscapeDataString(urlExample);
            string result = Uri.UnescapeDataString(url);

            Console.WriteLine(exampleResult);
            Console.ReadKey();
        }
    }
}
