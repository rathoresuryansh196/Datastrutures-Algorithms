using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrutures_Algorithms_CSharp.Sorting
{
    public class SortingAlogrithms
    {
        private static readonly string TAG = "SortingAlogrithms ";

        #region BUBBLE SORT
        public static void bubbleSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected bubble sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();

                for (int i=0; i < numbersToBeSorted.Length; i++)
                {
                    Console.WriteLine("Iterating loop number: " + i );
                    for (int j = 0 ;j< numbersToBeSorted.Length-i-1; j++)
                    {
                        Console.WriteLine("Comparing " + numbersToBeSorted[j] + " with "+ numbersToBeSorted[j+1]);
                        if (numbersToBeSorted[j] > numbersToBeSorted[j+1])
                        {
                            Console.WriteLine("Swapping " + numbersToBeSorted[j] + " with " + numbersToBeSorted[j+1]);
                            int temp = numbersToBeSorted[j];
                            numbersToBeSorted[j] = numbersToBeSorted[j+1];
                            numbersToBeSorted[j+1] = temp;
                            Common.Utils.PrintIntArray(numbersToBeSorted);
                        }
                    }
                }
                Console.WriteLine("Numbers after sorting with bubble sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);
               

            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG,"Excpetion handled when trying to sort using bubble sort",e);
            }
        }
        #endregion

        #region SELECTION SORT
        public static void SelectionSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected selection sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();
                int lowestNum;

                for (int i = 0; i < numbersToBeSorted.Length; i++)
                {
                    lowestNum = i;
                    Console.WriteLine("Array length: " + numbersToBeSorted.Length);
                    Console.WriteLine("Iterating loop number: " + i);
                    for (int j = 0; j < numbersToBeSorted.Length-1 ; j++)
                    {
                        Console.WriteLine("Comparing " + numbersToBeSorted[j] + " with " + numbersToBeSorted[j + 1]);
                        if (numbersToBeSorted[j] > numbersToBeSorted[lowestNum])
                        {
                            lowestNum = j;
                            Console.WriteLine("New minimum is " + numbersToBeSorted[j]);
                        }
                        int temp = numbersToBeSorted[lowestNum];
                        numbersToBeSorted[lowestNum] = numbersToBeSorted[i];
                        numbersToBeSorted[i] = temp;
                        Common.Utils.PrintIntArray(numbersToBeSorted);
                    }
                }
                Console.WriteLine("Numbers after sorting with selection sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG, "Excpetion handled when trying to sort using selection sort" , e);
            }
        }
        #endregion

        #region INSERTION SORT
        public static void InsertionSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected insertion sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();


                Console.WriteLine("Numbers after sorting with insertion sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG, "Excpetion handled when trying to sort using insertion sort" , e);
            }
        }
        #endregion

        #region MERGE SORT
        public static void MergeSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected merge sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();


                Console.WriteLine("Numbers after sorting with merge sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG, "Excpetion handled when trying to sort using merge sort", e);
            }
        }
        #endregion
        #region QUICK SORT
        public static void QuickSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected quick sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();


                Console.WriteLine("Numbers after sorting with quick sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG, "Excpetion handled when trying to sort using quick sort", e);
            }
        }
        #endregion
        #region HEAP SORT
        public static void HeapSort()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Selected heap sort.");
                int[] numbersToBeSorted = Common.Utils.Sort();


                Console.WriteLine("Numbers after sorting with heap sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


            }
            catch (Exception e)
            {
                Common.Utils.ExceptionHandleMsg(TAG, "Excpetion handled when trying to sort using heap sort", e);
            }
        }
        #endregion
        
    }
}
