using System;

namespace method11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -5, 4, 0, -9, -10, 1 };


            Method(array);
        }
        #region
        static int[] Method(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * (-1);


                }
                Console.Write(arr[i]);
            }
            return arr;



        }
        #endregion

















    }
}
