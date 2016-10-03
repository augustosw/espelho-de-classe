using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class FisherYatesShuffle
    {
        private static object lockRandom = new object();
        private static Random random = new Random();

        /// <summary>
        /// Algoritmo de embaralhamento: Fisher Yates Shuffle
        //  https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        /// </summary>
        public static void Suffle<T>(T[] array)
        {
            int tamanhoArray = array.Length;
            for (int i = 0; i < tamanhoArray; i++)
            {
                double randomNumber = 0;

                lock (lockRandom)
                {
                    randomNumber = random.NextDouble();                    
                }
                int randomArrayPosition = i + (int)(randomNumber * (tamanhoArray - i));
                T temp = array[randomArrayPosition];
                array[randomArrayPosition] = array[i];
                array[i] = temp;
            }
        }
    }
}
