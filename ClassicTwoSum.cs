using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class ClassicTwoSum
    {
        public ClassicTwoSum() 
        {

            int[] numbers = { 1, 2, 3, 4, 8, 5, 9 };
            int target = 11;
            var resultList = ReturnIndicesOptimized(numbers, target);
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Result From ClassicTwoSum class with Time Complexity = O(n) below:");
            foreach (var result in resultList)
            {
                Console.WriteLine(result);
            }
        }

        public static List<(int, int)> ReturnIndicesOptimized(int[] numbers, int target)
        {
            var result = new List<(int, int)>();
            var seen = new Dictionary<int, int>(); // maps value → index

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
                int complement = target - num;

                if (seen.ContainsKey(complement))
                {
                    // We found a valid pair
                    result.Add((seen[complement], i));
                }

                // Store current number and its index (only one per number)
                // If duplicates are allowed, you might want to skip this line if the number is already in the dictionary
                if (!seen.ContainsKey(num)) // prevents overwriting earlier index
                {
                    seen[num] = i;
                }
            }

            return result;
        }
    }
}
