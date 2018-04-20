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
                int biggestNum;

                for (int i = 0; i < numbersToBeSorted.Length; i++)
                {
                    biggestNum = i;
                    Console.WriteLine("Array length: " + numbersToBeSorted.Length);
                    Console.WriteLine("Iterating loop number: " + i);
                    for (int j = 0; j < numbersToBeSorted.Length ; j++)
                    {
                        Console.WriteLine("Comparing " + numbersToBeSorted[j] + " with " + numbersToBeSorted[biggestNum]);
                        if (numbersToBeSorted[biggestNum]<numbersToBeSorted[j]  )
                        {
                            
                            biggestNum = j;
                            Console.WriteLine("New max is " + numbersToBeSorted[j]);
                        }
                        int temp = numbersToBeSorted[i];
                        numbersToBeSorted[i] = numbersToBeSorted[biggestNum];
                        numbersToBeSorted[biggestNum] = temp;
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

                int N = numbersToBeSorted.Length;
                for (int i = 1; i < N; i++)
                {
                    int value= numbersToBeSorted[i];
                    int holePos = i-1;
                    //int j = i - 1;
                    while ((holePos >= 0) && (numbersToBeSorted[holePos] > value))
                    {
                        numbersToBeSorted[holePos + 1] = numbersToBeSorted[holePos];
                        holePos--;
                    }
                    numbersToBeSorted[holePos + 1] = value;
                    Common.Utils.PrintIntArray(numbersToBeSorted);
                }

                Console.WriteLine("Numbers after sorting with insertion sort");
                Common.Utils.PrintIntArray(numbersToBeSorted);


                //for (int i = 1; i < N; i++)
                //{
                //    int j = i - 1;
                //    int temp = numbersToBeSorted[i];

                //    while (j >= 0 && temp < numbersToBeSorted[j])
                //    {
                //        numbersToBeSorted[j + 1] = numbersToBeSorted[j];
                //        j--; ;
                //    }

                //    numbersToBeSorted[j + 1] = temp;
                //    Console.Write("After pass " + i + "  : ");
                //    //Printing array after pass
                //    Console.WriteLine(String.Join(" ", numbersToBeSorted));
                //}
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
                //int[] numbersToBeSorted = Common.Utils.Sort();
                int[] leftSorted = Common.Utils.Sort();
                int[] rightSorted = Common.Utils.Sort();


                Console.WriteLine("Numbers after sorting with merge sort");
                Common.Utils.PrintIntArray(leftSorted);
                Common.Utils.PrintIntArray(rightSorted);

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
