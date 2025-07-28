using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{

    /// <summary>
    /// LeetCode Passed the 3 Cases but with the following stats:
    /// Runtime: 73 ms, Beats 7.54% | Memory: 48.70MB, Beats 57.88%
    /// and Time Complexity: O(N2) , Space Complexity: o(1)
    /// Which aren't very efficient
    /// </summary>
    internal class BruteForceTwoSumSolved
    {
        public BruteForceTwoSumSolved()
        {
            int[] nums = { 3,3 };
            int t = 6;
            int[] returnedA = TwoSum(nums, t);
            if (returnedA != null)
            {
                foreach (int r in returnedA)
                {
                    Console.WriteLine(r);
                }
            }
        }

        public static int[]? TwoSum(int[] nums, int target)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 0; y < nums.Length; y++)
                {
                    int sum;
                    int numsx = nums[x];
                    int numsy = nums[y];
                    if (numsx != numsy || x != y)
                    {
                        sum = numsx + numsy;
                            if (sum == target)
                            {
                                int[] returnArray = { x, y };
                                return returnArray;
                            }
                    }
                }
            }
            return null;
        }
    }
}
