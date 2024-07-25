

using advanced_1.Bubble_Sort;
using advanced_1.Generic;

namespace advanced_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BubbleSort
            /* int[] array = { 64, 34, 25, 12, 22, 11, 90 };
             BubbleSort.Bubble_Sort(array);

             Console.WriteLine("Sorted array:");
             foreach (int item in array)
             {
                 Console.Write(item + " ");
             }*/
            #endregion


            #region Generics

            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine(intRange.IsInRange(5)); 
            Console.WriteLine(intRange.Length()); 

            Range<double> doubleRange = new Range<double>(1.0, 10.0);
            Console.WriteLine(doubleRange.IsInRange(5.5)); 
            Console.WriteLine(doubleRange.Length()); 
            #endregion

        }

    }
}
