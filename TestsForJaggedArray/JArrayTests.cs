using System;
using JaggedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestsForJaggedArray
{
    [TestClass]
    public class JaggedArrayTests
    {
        [TestMethod]
        public void CheckingSumSortIncrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[3] { 1, 3, 5 };
            myArray[1] = new int[2] { 2, 4 };
            myArray[2] = new int[4] { 2, 4, 6, 8 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[4] { 2, 4, 6, 8 };
            arrangeArray[1] = new int[3] { 1, 3, 5 };
            arrangeArray[2] = new int[2] { 2, 4 };

            //act
            int[][] actArray = JArray.SumBubbleSortIncrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);

        }

        [TestMethod]
        public void CheckingSumSortDecrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[3] { 1, 3, 5 };
            myArray[1] = new int[2] { 2, 4 };
            myArray[2] = new int[4] { 2, 4, 6, 8 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[2] { 2, 4 };
            arrangeArray[1] = new int[3] { 1, 3, 5 };
            arrangeArray[2] = new int[4] { 2, 4, 6, 8 };

            //act
            int[][] actArray = JArray.SumBubbleSortDecrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckingMaxElemIncrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[3] { 1, 2, 5 };
            myArray[1] = new int[2] { 2, 1 };
            myArray[2] = new int[4] { 2, 4, -10, 8 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[2] { 2, 1 };
            arrangeArray[1] = new int[3] { 1, 2, 5 };
            arrangeArray[2] = new int[4] { 2, 4, -10, 8 };

            //act
            int[][] actArray = JArray.MaxElemBubbleSortIncrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);
        }


        [TestMethod]
        public void CheckingMaxElemDecrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[3] { 1, 2, 5 };
            myArray[1] = new int[2] { 2, 1 };
            myArray[2] = new int[4] { 2, 4, -10, 8 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[4] { 2, 4, -10, 8 };
            arrangeArray[1] = new int[3] { 1, 2, 5 };
            arrangeArray[2] = new int[2] { 2, 1 };

            //act
            int[][] actArray = JArray.MaxElemBubbleSortDecrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckingMinElemIncrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[4] { 2, 4, -10, 8 };
            myArray[1] = new int[2] { -2, 1 };
            myArray[2] = new int[3] { 1, 2, 5 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[3] { 1, 2, 5 };
            arrangeArray[1] = new int[2] { -2, 1 };
            arrangeArray[2] = new int[4] { 2, 4, -10, 8 };

            //act
            int[][] actArray = JArray.MinElemBubbleSortIncrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckingMinElemDecrease()
        {
            //arrange
            int[][] myArray = new int[3][];
            myArray[0] = new int[3] { 1, 2, 5 };
            myArray[1] = new int[4] { 2, 4, -10, 8 };
            myArray[2] = new int[2] { -2, 1 };

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[4] { 2, 4, -10, 8 };
            arrangeArray[1] = new int[2] { -2, 1 };
            arrangeArray[2] = new int[3] { 1, 2, 5 };

            //act
            int[][] actArray = JArray.MinElemBubbleSortDecrease(myArray);

            //assert
            CollectionAssert.AreEqual(arrangeArray[0], actArray[0]);
            CollectionAssert.AreEqual(arrangeArray[1], actArray[1]);
            CollectionAssert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckingCountTheSumOfArray()
        {
            int[] ar = { 2, 3, 4, 20, -2 };
            int arrangSum = 27;

            int actSum = JArray.CountTheSumOfArray(ar);

            Assert.AreEqual(arrangSum, actSum);
        }

        [TestMethod]
        public void CheckingFindMaxElem()
        {
            int[] ar = { 2, 3, 4, 20, -2 };

            int arrangMaxElem = 20;
            int actMaxElem = JArray.FindMaxElem(ar);
            Assert.AreEqual(arrangMaxElem, actMaxElem);

        }

        [TestMethod]
        public void CheckingFindMinElem()
        {
            int[] ar = { 2, 3, 4, 20, -2 };

            int arrangMaxElem = -2;
            int actMaxElem = JArray.FindMinElem(ar);
            Assert.AreEqual(arrangMaxElem, actMaxElem);

        }
    }
}