using System;

namespace method11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -5, 4, 0, -9, -10, 1 };

           
            Console.WriteLine(array);
        }
        #region
        static int Method(int[] arr)
            //task 1

        {
            for (int i = 0; i < arr.Length; i++) 
            
                if (arr[i] < 0) 
                {
                    arr[i] = arr[i] * -1;
                    
                }
                else
                {
                    arr[i] = arr[i];
                    
                }
            return  0;



        }
        #endregion

        //task 2
        
        //{
        //    #region

        //    string word = "School";
        //    string mirror = "";
        //    int length = word.Length - 1;

        //    while (length >= 0)
        //    {
        //        mirror += word[length];
        //        length--;
        //    }

        //    Console.WriteLine(mirror);
        //    #endregion
        //}




    }
}
