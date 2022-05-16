using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadenaVowels
{
    /*
       Encontrar la cadena de vocales en una cadena de letras:
       ejemplo: asrdrdaaeeiooouuesys
       Si existen varias regresar la más larga y sino existe regresar 0
     */

    /*Varidar Expresiones regulares.
     * https://www.ocpsoft.org/tutorials/regular-expressions/java-visual-regex-tester/
     * 
     * Tutorial expresiones regulares: https://www.adictosaltrabajo.com/2015/01/29/regexsam/
     */



    internal class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            string cadenaVowels = "asaaeeioouuesysaeioummertetaaaaeeeeeeiouuuuuu";
            StringBuilder sb = new StringBuilder();
            bool bandera = true;
            int count = 0;
            List<string> listCadena = new List<string>();

            Regex regex = new Regex("a+e+i+o+u+");

            var ocurrencias = regex.Matches(cadenaVowels);

            foreach (Match match in ocurrencias)
            {
                listCadena.Add(match.Value);

            }

            var result = listCadena.Max(x => x.Length);
            var result2 = listCadena.Where(x => x.Length >= result).FirstOrDefault();


            Console.WriteLine("La cadena de vocales mas grande es: " + result2);
            Console.ReadLine();

            //FIN



            //PRIMERA VERSIÓN PARA RECUPERAR VOCALES, NO FUNCIONÓ
            //for (int i = 0; i < cadenaVowels.Length; i++)
            //{

            //    while(bandera)
            //    {
            //        if(count == 4) 
            //        {
            //            if ('u' == cadenaVowels[i]) 
            //            {
            //                sb.Append(cadenaVowels[i]);
            //                break;
            //            }
            //            else 
            //            {
            //                listCadena.Add(sb.ToString());
            //                sb.Clear();
            //                count = 0;
            //                break;
            //            }
                    
            //        }
            //        if(vowels[count] == cadenaVowels[i]) 
            //        {
            //            bandera = true;
            //            sb.Append(cadenaVowels[i]);
            //            break;
            //        }
            //        else 
            //        {
            //            bandera = true;
            //            //sb.Append(cadenaVowels[i]);
            //            count++;
            //            //break;
            //        }


            //        else 
            //        {
            //            bandera = true;
            //            sb.Clear();
            //            count = 0;
            //            break;
            //        }
            //    }

            //}


        }
    }
}
