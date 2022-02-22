using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        public static void Main()
        {
            int i;
            bool equal = true;
            Console.WriteLine("Enter First Value : ");
            int[] array1 = new int[5];
                for ( i = 0; i < array1.Length; i++)
            {
                Console.Write("Value : " , i);
                array1 [i] =int.Parse( Console.ReadLine());
            }
            Console.WriteLine("Enter Second Value : ");
            int[] array2 = new int[5];
            for (i = 0; i < array1.Length; i++)
            {
                Console.Write("Value : ", i);
                array1[i] = int.Parse( Console.ReadLine());
            }
            if (array1.Length == array2.Length)
            {

                // Traverse both array and compare
                //each element
                for ( i = 0; i < array2.Length; i++)
                {

                    // set true if each corresponding
                    //elements of arrays are equal
                    if (array2[i] != array1[i])
                    {

                        equal = false;
                    }
                }
            }
            else
            {

                equal = false;
            }

            // print the result if both arrays are equal or not
            if (equal)
            {
                Console.WriteLine("Both arrays are equal");

            }
            else
            {
                Console.WriteLine("Both arrays are not equals");

            }
            Console.ReadKey();
        }
    }
}
