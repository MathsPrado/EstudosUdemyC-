using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUdemy
{
    class Calculatorcs
    {
        public static int Sum (params int[] numbers)
        {

            //Ambos São considerados "Code smells" (design Ruim) e devem ser evitados!

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            return sum;
        }

        public static void Triple (ref int x)
        {
            x = x * 3;
        }


         // a variavel que vier no segundo parametro, "pega" os valores do result
        public static void TripleOut( int origin, out int result) { 
            result = origin * 3;
        }
    }
}
