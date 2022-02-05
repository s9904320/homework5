using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TwoSumForEmptyOrTargetNegative()
        {
            int[] actual = { 0, 0 };
            int[] testNum = new int[0];
            int[] expected = Solution.TwoSum(testNum, 9);
            Assert.IsTrue(expected.SequenceEqual(actual));
            
            int[] testNum1 = { 1, 2 };
            expected = Solution.TwoSum(testNum1, -1);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod()]
        public void TwoSumForNormal()
        {
            int[] actual = { 0, 1 };
            int[] testNum = { 2, 7, 11, 15 };
            int[] expected = Solution.TwoSum(testNum, 9);
            Assert.IsTrue(expected.SequenceEqual(actual));

            actual[0] = 1;
            actual[1] = 2;
            int[] testNum1 = { 3, 2, 4 };
            expected = Solution.TwoSum(testNum1, 6);
            Assert.IsTrue(expected.SequenceEqual(actual));

            actual[0] = 0;
            actual[1] = 1;
            int[] testNum2 = { 3, 3 };
            expected = Solution.TwoSum(testNum2, 6);
            Assert.IsTrue(expected.SequenceEqual(actual));

        }
    }
}