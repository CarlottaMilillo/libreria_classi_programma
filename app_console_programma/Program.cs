using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using clsUtility;
namespace test
{
    class Program
    {
        static List<int> lista = new List<int>();
        public static void Main(string[] args)
        {
            Ran rn = new Ran();
            lista = rn.GetLista(15, 1, 55);

            Console.WriteLine("premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
