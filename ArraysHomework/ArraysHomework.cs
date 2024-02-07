using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ArraysHomework
{
    [TestClass]
    public class ArraysHomework
    {
        [TestMethod]
        public void Arrays()
        {
            // Create an array of ints of size 100
            int[] myArray = new int [100];
            Assert.IsTrue(myArray.Length == 100);

            // take the array made above and fill it so these test passes  
            myArray[0] = 21;
            Assert.IsTrue(myArray[0] == 21);

            myArray[50] = 35;
            Assert.IsTrue(myArray[50] == 35);

            myArray[68] = 78;
            Assert.IsTrue(myArray[68] == 78);

            //// fill all of the array values in to make the loop on line 24 pass as is. Do not edit the loop that assert the passing case
            //// hint you need some form of repetition.  
            myArray[0] = 10;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = 10;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Assert.IsTrue(myArray[i] == 10);
            }



            //// what wrong with this array declaration? Fix it and make it compile
            string[] stringArray = new string[0];

            //// What about this one? Fix it and make it compile
            bool[] boolArray = new bool[0];

            //// What about this one? Fix it and make it compile
            bool[] boolArray2 = new bool[0];

            //// Take this array and copy its contents into a new array 
            char[] copyMe = { 'a', 'b', 'c' };
            char[] copiedArray = new char [3];
           
            copyMe.CopyTo(copiedArray,0);
            
            Assert.IsTrue(copiedArray.Length == copyMe.Length);
            Assert.IsTrue(copiedArray[0] == 'a');
            Assert.IsTrue(copiedArray[1] == 'b');
            Assert.IsTrue(copiedArray[2] == 'c');

            //// Swap the last and first value of this array.
            string[] swapMyValues = { "first", "middle", "last" };
            (swapMyValues[0], swapMyValues[2]) = (swapMyValues[2], swapMyValues[0]);
            
            Assert.IsTrue(swapMyValues[0] == "last");
            Assert.IsTrue(swapMyValues[2] == "first");

            ////Combine these two arrays into a 3rd array;
            int[] array1 = new int[25];
        
            int[] array2 = new int[25];


            int[] combined = new int[array1.Length + array2.Length];




            // just a little fun to fill them
            int up = 0;
            int down = 24;
            
            for (; up < array1.Length && down >= 0; up++, down--)
            {
                array1[up] = up;
                array2[down] = down;
            }

            // combine array1 and array 2 into an array named combined
            combined = array1.Concat(array2).ToArray();

            Assert.IsTrue(combined.Length == 50);
        }

        [TestMethod]
        public void Lists()
        {
            //Create a List of ints named my list

            List<int> myList = new List<int>();

            Assert.IsTrue(myList != null); // if you create it right, this will pass

            //take the list made above and fill it so these test passes
            myList.Add(21);
            myList.Add(35);
            myList.Add(78);
            Assert.IsTrue(myList[0] == 21);
            Assert.IsTrue(myList[1] == 35);
            Assert.IsTrue(myList[2] == 78);

            //    what wrong with this list declaration? You can use any type for its content. Fix it and make it compile

            List<string> stringList = new List<string>();

            //    What about this one? You can use any type for its content. Fix it and make it compile

            List<int> list1 = new List<int>();

            //    What about this one? You can use any type for its content. Fix it and make it compile

            List<string> list2 = new List<string>();

            //    What about this one? You can use any type for its content. Fix it and make it compile

            List<char> list3 = new List<char>();

            //    Take this list and copy its contents into a new list
            List<char> copyMe = new List<char>() { 'a', 'b', 'c' };
                        
            List<char> copiedList = copyMe.GetRange(0, copyMe.Count);

            Assert.IsTrue(copiedList.Count == copyMe.Count);
            Assert.IsTrue(copiedList[0] == 'a');
            Assert.IsTrue(copiedList[1] == 'b');
            Assert.IsTrue(copiedList[2] == 'c');

            //    Swap the last and first value of this list.
            List<string> swapMyValues = new List<string> { "first", "middle", "last" };

            (swapMyValues[0], swapMyValues[2]) = (swapMyValues[2], swapMyValues[0]);

            Assert.IsTrue(swapMyValues[0] == "last");
            Assert.IsTrue(swapMyValues[2] == "first");

            //    Combine these two lists by absorbing copy1 into copy2;
            List<int> copy1 = new List<int>();
            List<int> copy2 = new List<int>();

            List<int> copy3 = copy1.Concat(copy2).ToList();


            //    just a little fun to fill them
            int up = 0;
            int down = 24;
            for (; up < 25 && down >= 0; up++, down--)
            {
                copy1.Add(up);
                copy2.Add(down);
            }

            //combine copy1 into copy 2
            copy2 = copy1.Concat(copy2).ToList();
            
            Assert.IsTrue(copy2.Count == 50);


            //    This is just a fun little section to explore the various methods on a list object.
            //     They are not counting against you because we have not yet covered methods.
            //     to access the lists methods use the dot operator similar to Console.WriteLine();

            //    BONUS reverse this list
            //    List<int> reverseMe = new List<int>() { 1, 2, 3, 4, 5 };

            //    BONUS sort this list
            //    List<int> sortMe = new List<int>() { 14, 3, 33, 2, 12 };

            //    BONUS Convert sortMe to an array

            //     BONUS Check if sortMe Contains the value 2.

            //     BONUS Remove all of sort mes values

        }
        }
}

//Test run change to push.