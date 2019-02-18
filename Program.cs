using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 10;
            Array array = new Array(ARRAY_SIZE);

            Console.WriteLine("Длина массива: " + array.Size + "\n");

            Random rnd = new Random();

            try
            {
                for (int i = 0; i < array.Size; i++)
                {
                    array[i] = rnd.Next(1, 10);
                    Console.WriteLine("array[{0}]: {1}", i, array[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
