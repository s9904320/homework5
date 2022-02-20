using Microsoft.VisualStudio.TestTools.UnitTesting;
using twosum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void TwoSumForEmptyOrNull()
        {
            int[] actual = { 0, 0 };
            int[] testNum = new int[0];
            int[] expected = Solution.TwoSum(testNum, 9);
            Assert.IsTrue(expected.SequenceEqual(actual));

            int[] testNum1 = null;
            expected = Solution.TwoSum(testNum1, -1);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod()]
        public void TwoSumForTestLengthShort()
        {
            int[] testNum = new int[1];
            int[] expected = Solution.TwoSum(testNum, 9);
            Assert.IsTrue(expected.SequenceEqual(new[] { 0, 0 }));

            expected = Solution.TwoSum(null, -1);
            Assert.IsTrue(expected.SequenceEqual(new[] { 0, 0 }));
        }
        [TestMethod()]
        public void TwoSumForNormal()
        {
            int[] expected = Solution.TwoSum(new[] { 7, 2, 11, 15 }, 9);
            Assert.IsTrue(expected.SequenceEqual(new[] { 0, 1 }));


            expected = Solution.TwoSum(new[] { 3, 2, 4 }, 6);
            Assert.IsTrue(expected.SequenceEqual(new[] { 1, 2 }));

            expected = Solution.TwoSum(new[] { 3, 3 }, 6);
            Assert.IsTrue(expected.SequenceEqual(new[] { 0, 1 }));

        }
    }
}