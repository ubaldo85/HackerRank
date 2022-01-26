using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaLetrasRepetidas
{
    //Dada una cadena de letras revisar cual es la letra que se repite más veces y si hay varias coincidencias regresar la letra 
    //que aparece primero en la cadena de caracteres. 
    class Program
    {
        static void Main(string[] args)
        {
            //string palabra = "helloworld";
            string palabra = "aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyyzz";
            char primerLetraEnOcurrir = maximumOccurringCharacter(palabra);

            Console.WriteLine("Primer letra en aparecer es: {0}", primerLetraEnOcurrir);
            Console.ReadLine();

        }

        public static char maximumOccurringCharacter(string text)
        {

            var listPalabras = text.Distinct();
            Datos dato;
            List<Datos> listDato = new List<Datos>();
            char resultado = 'a';

            //recuperamos el numero de veces que se repite la letra y la guardamos en objeto.
            foreach (var item in listPalabras)
            {
                dato = new Datos();
                dato.letra = item.ToString();
                dato.repeticiones = text.Where(x => x == item).Count();
                listDato.Add(dato);

            }

            int maxNumrep = listDato.Max(x => x.repeticiones);

            //Recuperamos del array las letras con maximo de repeticiones.
            var listaLetrasResult = listDato.Where(x => x.repeticiones == maxNumrep).ToList();

            if (listaLetrasResult.Count == 1)
            {
                resultado = Convert.ToChar(listaLetrasResult[0].letra);

            }
            else
            {
                //Si hay varias letras con el mismo numero de repeticiones, revisamos cual es la que tiene el indice más pequeño de aparición
                foreach (var item in listaLetrasResult)
                {
                    item.indexarr = text.IndexOf(item.letra);

                }


                int firstIndex = listaLetrasResult.Min(x => x.indexarr);
                //Recuperamos la letra con el index más pequeño.
                resultado = Convert.ToChar(listaLetrasResult.Where(x => x.indexarr == firstIndex).Select(x => x.letra).FirstOrDefault());

            }
            return resultado;

        }

        class Datos
        {

            public string letra { get; set; }
            public int repeticiones { get; set; }
            public int indexarr { get; set; }


        }
    }
}
