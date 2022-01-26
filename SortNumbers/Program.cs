using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    //A partir de una lista de string de enteros ordenarla de menor a mayor.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            //List<string> lista = new List<string>() { "6", "3141592", "1", "3", "10", "3", "5" };

            var result = bigSorting(lista);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<string> bigSorting(List<string> unsorted)
        {
            string temporal = string.Empty;
            int tamanioList = unsorted.Count;

            for (int j = 0; j < tamanioList - 1; j++)
            {
                for (int i = j; i < tamanioList - 1; i++)
                {
                    if (Convert.ToDouble(unsorted[j]) > Convert.ToDouble(unsorted[i + 1]))
                    {
                        temporal = unsorted[j];
                        unsorted[j] = unsorted[i + 1];
                        unsorted[i + 1] = temporal;
                    }
                }

            }
            return unsorted;
        }

    }
}
