using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDicionarios
{
    //Solo lo realicé para el manejo de Listas y Diccionarios. Como crear Lista e inicializarla al igual que diccionario.
    //Tambien para hacer queries con LINQ
    class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero();
            List<Numero> listaNumeros = new List<Numero>() { new Numero(){ numero= 1, degree=2},
                                                            new Numero(){numero=2,degree=2},
                                                            new Numero(){numero=3,degree=1}, };
            var result = listaNumeros.GetRange(1, 2);
            regresaBigest(listaNumeros);
            //recorreDiccionary(); //AQUI ES SOLO PARA SABER COMO RECORRER UN DICCIONARIO, NO LO RECORDABA.

        }


        public static void recorreDiccionary()
        {

            Dictionary<int, int> dicnumero = new Dictionary<int, int>();
            dicnumero.Add(1, 2);
            dicnumero.Add(2, 2);
            dicnumero.Add(3, 1);


            var result = dicnumero.Where(x => x.Value == 2).ToList();
            var result2 = dicnumero.Where(x => x.Value == 2).Select(x => x.Key).ToList();

            List<int> listnumeros = new List<int>();
            foreach (var item in dicnumero)
            {
                if (item.Value == 2)
                {
                    listnumeros.Add(item.Key);
                }
            }

        }

        public static void regresaBigest(List<Numero> arr)
        {
            var result = arr.Where(x => x.degree == 2).ToList();

        }


    }


    class Numero
    {
        public int numero { get; set; }
        public int degree { get; set; }

    }
}
