using System;
using System.Collections.Generic;
using System.Linq;

namespace twosum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] reAns = new int[2];
            int otherTarget;
            int secAns = -1;
            if (nums == null ||nums.Length < 2)
            {
                reAns[0] = 0;
                reAns[1] = 0;
                return reAns;
            }
            else
            {
                var myDic = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    myDic[nums[i]] = i;
                }

                for (int firAns = 0; firAns < nums.Length; firAns++)
                {
                    otherTarget = target - nums[firAns];

                    if(myDic.TryGetValue(otherTarget, out secAns))
                    {
                        if(firAns != secAns)
                        {
                            reAns[0] = firAns;
                            reAns[1] = secAns;
                            return reAns;
                        }
                    }
                }
                return reAns;
            }       
        }
    }
}
