using System;

namespace homework5
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] reAns = new int[2];
            if(nums.Length == 0 || target < 0)
            {
                reAns[0] = 0;
                reAns[1] = 0;
                return reAns;
            }
            else
            {
                for(int firstNum = 0; firstNum < nums.Length; firstNum++)
                {
                    if((firstNum + 1) < nums.Length)
                    {
                        for (int secNum = firstNum + 1; secNum < nums.Length; secNum++)
                        {
                            if (target == (nums[firstNum] + nums[secNum]))
                            {
                                reAns[0] = firstNum;
                                reAns[1] = secNum;
                            }
                        }
                    }
                }
                return reAns;
            }       
        }
    }
}
