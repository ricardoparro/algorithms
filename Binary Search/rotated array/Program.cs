using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //var array = new int[7] {4, 5, 6, 7, 1, 2, 3};
            //var array = new int[7] { 6,0,1, 2, 3,4,5 };
            var array = new int[7] { 5, 6, 7, 1, 2, 3, 4 };
            //var array = new int[7] {  0, 1, 2, 3, 4, 5, 6 };
            //var array = new int[7] { 1, 2, 3, 4, 5, 6, 0 };
            var result = FindMin(array);

            System.Console.WriteLine(result);

        }

        //Finds the min value in a rotated array
        public static int FindMin(int[] array)
        {

            var sizeArray = array.Length;

            var middleArray = array.Length/2;

            if (array[0] < array[middleArray])
            {
                for (int i = middleArray; i < sizeArray; i++)
                {
                    if (array[0] > array[i])
                    {
                        return array[i];
                    }
                }
            }
            else
            {

                for (int i = middleArray; i > -1; i--)
                {
                    if (i == 0)
                    {
                        return array[0];
                    }

                    if (array[i] < array[i - 1])
                    {
                        return array[i];
                    }
                }

            }

            //In case the array was not rotated

            if (array[0] > array[sizeArray- 1])
            {
                return array[sizeArray-1];
            }
            return array[0];

        }
    }
}
