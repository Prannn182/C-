using System;

class function

{
  static void Result(int[] arr,int min)
    {
        int m = arr[0];
        Console.WriteLine("array is :\n");

        for (int i = 0; i < arr.Length; i++)
        {
            //if (min > numbers[i]) min = numbers[i];
             //Console.WriteLine("The minimum is: {0}", min)
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
     // Console.Write("Minimum element = {0}\n\n", min);
   
       
    }
         public static void Main()
    {
       // int min = 0;
        //int[] ar2 = { 2, 4, 6, 8, 0 };
       int[] arr = { 1, 2, 3, 4, 5 };
       // Console.Write("Minimum element = {0}\n\n", min);
   
       

       // Result(arr,min);
        
    }
}