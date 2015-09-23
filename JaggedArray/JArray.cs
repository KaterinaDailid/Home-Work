using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    public class JArray
    {
        public static int[][] SumBubbleSortIncrease(int[][] MyArray)
        {
            if (MyArray == null)
                throw new System.ArgumentException("Parameter cannot be null");

            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (CountTheSumOfArray(MyArray[j]) > CountTheSumOfArray(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int[][] SumBubbleSortDecrease(int[][] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (CountTheSumOfArray(MyArray[j]) < CountTheSumOfArray(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int[][] MaxElemBubbleSortIncrease(int[][] MyArray)
        {

            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (FindMaxElem(MyArray[j]) < FindMaxElem(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int[][] MaxElemBubbleSortDecrease(int[][] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (FindMaxElem(MyArray[j]) > FindMaxElem(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int[][] MinElemBubbleSortIncrease(int[][] MyArray)
        {

            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {// +1 -1 -10
                    if (FindMinElem(MyArray[j]) > FindMinElem(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int[][] MinElemBubbleSortDecrease(int[][] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (FindMinElem(MyArray[j]) < FindMinElem(MyArray[i]))
                    {
                        var temp = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            return MyArray;
        }

        public static int CountTheSumOfArray(int[] MyArray)
        {
            int SumOfArray = 0;

            for (int i = 0; i < MyArray.Length; i++)
            {
                checked
                {
                    SumOfArray += MyArray[i];
                }
            }

            return SumOfArray;
        }

        public static int FindMaxElem(int[] MyArray)
        {
            int MaxElem = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {

                if (MyArray[i] > MaxElem)
                    MaxElem = MyArray[i];


            }
            return MaxElem;
        }

        public static int FindMinElem(int[] MyArray)
        {
            int MinElem = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MyArray[i] < MinElem)
                    MinElem = MyArray[i];
            }

            return MinElem;
        }
    }
}

