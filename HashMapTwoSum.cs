using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    /// <summary>
    /// gets all instances of numbers that add up to a 'target' number using HashMap(Dictionary) and HashSet
    /// </summary>
    public class HashMapTwoSum
    {

        public HashMapTwoSum()
        {
            int[] numbers = PrepareArray();
            Console.WriteLine("This is the list of numbers we are working with:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--");
            Console.Write("Enter a value: ");
            string? userInput = Console.ReadLine();
            int sendTarget = int.Parse(userInput);
            CallList(numbers, sendTarget);
        }

        public static int[] PrepareArray()
        {
            //    INDICES     0  1  2  3  4  5  6  
            int[] numbers = { 1, 2, 3, 4, 8, 5, 9 };
            return numbers;
        }

        public static void CallList(int[] numbers, int target)
        {
            var result = ReturnIndices(numbers, target);
        
            foreach (var pair in result)
            {
                Console.WriteLine($"Index {pair.Item1} + Index {pair.Item2} = the value of {target} ({numbers[pair.Item1]} + {numbers[pair.Item2]})");
            }
        }

        public static List<(int, int)> ReturnIndices(int[] numbers, int target)
        {
            // Dictionary/HashMap to map 1 key to a List of multiple values.
            Dictionary<int, List<int>> valueToIndices = new Dictionary<int, List<int>>();

            /*Declare a List called result of ValueTuple containing 2 integers, and instantiate it.
             ValueTuple is a value type introduced in C# 7.0 that represents a tuple 
            — an ordered set of elements — where each element can be of a different type. 
            It is defined in the System namespace and implemented 
            as a generic struct (System.ValueTuple<T1, T2, ..., T7>).

            This list will be used to store the return values: i.e. all the pairs of numbers that add up to the target
           */
            List<(int, int)> result = new List<(int, int)>();
            /* can also be declared as follows: List<ValueTuple<int, int>> */


            /* Declare a HashSet of tuples called seenPairs, containing two integers, and initialize it as an empty HashSet." 
            */
            HashSet<(int, int)> seenPairs = new HashSet<(int, int)>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i]; //num is each number item
                int complement = target - num; //complement is the particular loop-through's  number  item, that when retrieved by the loop, is subtracted from the target to get the other numbers value needed to add up to the value of the target

                if (valueToIndices.ContainsKey(complement))
                {
                    foreach (int j in valueToIndices[complement])
                    {
                        // Min selects which between i and j is the smaller.
                        // Max selects which of i and j is the larger
                        // - the result is that the assignment to pair always orders the pair with the smaller value 1st)
                        var pair = (Math.Min(i, j), Math.Max(i, j));
                        if (!seenPairs.Contains(pair))
                        {
                            result.Add(pair);
                            seenPairs.Add(pair);
                        }
                    }
                }

                // Add current number to dictionary
                if (!valueToIndices.ContainsKey(num))
                {
                    valueToIndices[num] = new List<int>();
                }
                valueToIndices[num].Add(i);
            }
            return result;
        }
    }
}
