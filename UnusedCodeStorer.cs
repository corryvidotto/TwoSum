using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class UnusedCodeStorer
    {

        ///*BEST MOST EFFICIENT - CODE CALLS: CallList()----------------------------------------------------------------------*/
        ////    INDEX       0  1  2  3  4  5  6  
        //int[] numbers = { 1, 2, 3, 4, 8, 5, 9 };
        //Console.WriteLine("This is the list of numbers we are working with:");
        //foreach (var item in numbers)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("--");
        //Console.Write("Enter a value: ");
        //string? userInput = Console.ReadLine();
        //int sendTarget = int.Parse(userInput);
        //CallList(numbers, sendTarget);


        //    /* Call to Bruteforce Solution (nested loop solution - least efficient)---------------------------------------------*/
        //    int[]? ReturnedIndicesBruteForce = DoSumBruteForce(sendTarget);
        //    if (ReturnedIndicesBruteForce != null)
        //    {
        //        Console.WriteLine("ReturnedIndicesBruteForce of: " + ReturnedIndicesBruteForce[0] + " + " + ReturnedIndicesBruteForce[1] + " which equals " + sendTarget + " is: index:" + ReturnedIndicesBruteForce[2] + " and index:" + ReturnedIndicesBruteForce[3]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nothing in the array returns " + sendTarget);
        //    }


        //    /* Call to Dictionary Solution (2nd best)---------------------------------------------------------------------------*/
        //    int[]? ReturnedIndicesDictionaryHashMap = DoSumDictionaryHashMap([1, 2, 3, 4, 8, 5, 9], sendTarget);
        //    if (ReturnedIndicesDictionaryHashMap != null)
        //    {
        //        Console.WriteLine( "HashMap/Dictionary Solution: " + ReturnedIndicesDictionaryHashMap[0] + ", " + ReturnedIndicesDictionaryHashMap[1]);
        //        //Console.WriteLine("ReturnedIndicesDictionaryHashMap of: " + ReturnedIndicesDictionaryHashMap[0] + " + " + ReturnedIndicesDictionaryHashMap[1] + " which equals " + sendTarget + " is: index:" + ReturnedIndicesDictionaryHashMap[2] + " and index:" + ReturnedIndicesDictionaryHashMap[3]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nothing in the array returns " + sendTarget);
        //    }
    }

    //private static void HashMapTwoSum()
    //{
    //    throw new NotImplementedException();
    //}

    //public static void CallList(int[] numbers, int target)
    //{
    //    var result = ReturnIndices(numbers, target);

    //    foreach (var pair in result)
    //    {
    //        Console.WriteLine($"Index {pair.Item1} + Index {pair.Item2} = the value of {target} ({numbers[pair.Item1]} + {numbers[pair.Item2]})");
    //    }
    //}

    //public static List<(int, int)> ReturnIndices(int[] numbers, int target)
    //{
    //    // Dictionary to map 1 key to a List of multiple values.
    //    Dictionary<int, List<int>> valueToIndices = new Dictionary<int, List<int>>();

    //    /*Declare a List called result, of ValueTuple containing 2 integers, and instantiate it.
    //     ValueTuple is a value type introduced in C# 7.0 that represents a tuple 
    //    — an ordered set of elements — where each element can be of a different type. 
    //    It is defined in the System namespace and implemented 
    //    as a generic struct (System.ValueTuple<T1, T2, ..., T7>).

    //    This list will be used to store the return values: i.e. all the pairs of numbers that add up to the target
    //   */
    //    List<(int, int)> result = new List<(int, int)>();
    //    /* can also be declared as follows: List<ValueTuple<int, int>> */


    //    /* Declare a HashSet of tuples called seenPairs, containing two integers, and initialize it as an empty HashSet." 
    //    */
    //    HashSet<(int, int)> seenPairs = new HashSet<(int, int)>();

    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        int num = numbers[i]; //num is each number item
    //        int complement = target - num; //complement is the particular loop's number item, that when retrieved in the loop, is subtracted from the target to get the other numbers value needed to add up to the value of the target

    //        if (valueToIndices.ContainsKey(complement))
    //        {
    //            foreach (int j in valueToIndices[complement])
    //            {
    //                // Min selects which between i and j is the smaller.
    //                // Max selects which of i and j is the larger
    //                // - the result is that the assignment to pair always orders the pair with the smaller value 1st)
    //                var pair = (Math.Min(i, j), Math.Max(i, j));
    //                if (!seenPairs.Contains(pair))
    //                {
    //                    result.Add(pair);
    //                    seenPairs.Add(pair);
    //                }
    //            }
    //        }

    //        // Add current number to dictionary
    //        if (!valueToIndices.ContainsKey(num))
    //        {
    //            valueToIndices[num] = new List<int>();
    //        }
    //        valueToIndices[num].Add(i);
    //    }
    //    return result;
    //}



    ///// <summary>
    ///// [1, 2, 3, 4, 8, 5, 9 ]
    ///// Bruteforce solution using nested loops - LESS EFFICIENT O(n2)
    ///// GIVES DIFFERENT INDICIES FOR 13 THAN HASHMAP [2,5]
    ///// </summary>
    ///// <param name="target"></param>
    ///// <returns></returns>
    ////public static int[]? DoSumBruteForce(int target)
    ////{
    ////    int sum;
    ////    int[] indicesOfSum;
    ////    int[] myNums = [1, 2, 3, 4, 8, 5, 9];
    ////    int item;
    ////    for (int i = 0; i <= myNums.Length-1; i++)
    ////    {
    ////        item = myNums[i];
    ////        for (int y = 0; y <= myNums.Length-1; y++)
    ////        {
    ////            if ((y + 1) <= myNums.Length - 1)
    ////            {
    ////                sum = item + myNums[y + 1];
    ////                if (sum == target && y != 0)
    ////                {
    ////                    indicesOfSum = [myNums[i], myNums[y + 1], i, y + 1];
    ////                    return indicesOfSum;
    ////                }
    ////            }

    ////        }
    ////    }
    ////    return null;
    ////}

    ///// <summary>
    ///// [1, 2, 3, 4, 8, 5, 9 ]
    ///// HashMap/C# Dictionary solution - more efficient O(n1)
    ///// GIVES DIFFERENT INDICIES FOR 13 THAN BRUTEFORCE [3,4]
    ///// </summary>
    ///// <param name="myNums"></param>
    ///// <param name="trgt2"></param>
    ///// <returns></returns>
    ////public static int[]? DoSumDictionaryHashMap(int[] myNums, int trgt2)
    ////{
    ////    int addend;
    ////    Dictionary<int, int> hMap = new Dictionary<int, int>();

    ////    for (int i = 0; i <= myNums.Length-1; i++)
    ////    {
    ////        //int addend;
    ////        int eachitem = myNums[i]; //get each item of the array

    ////        if(trgt2 > eachitem) //check to ensure we are subtracting a lower number from a greater number
    ////        {
    ////            addend = trgt2 - eachitem; //get the difference value
    ////            if (hMap.ContainsKey(addend)) //if the difference value is a value in the myNums array them we have found a number (b) that the current array item (a) needs to reach target (c)
    ////            {
    ////                return new int[] { hMap[addend], i }; //create a new array to hold the indicies of (b) and (a) - which added together give (c)
    ////            }
    ////        }
    ////        else if(eachitem > trgt2)//check to ensure we are subtracting a lower number from a greater number
    ////        {
    ////            addend = eachitem -trgt2; //get the difference value
    ////            if (hMap.ContainsKey(addend)) //if the difference value is a value in the myNums array them we have found a number (b) that the current array item (a) needs to reach target (c)
    ////            {
    ////                return new int[] { hMap[addend], i }; //create a new array to hold the indicies of (b) and (a) - which added together give (c)
    ////            }
    ////        }
    ////        hMap[myNums[i]] = i;
    ////    }
    ////    return null; // throw new ArgumentException("No two sum solution");
    ////}

}
