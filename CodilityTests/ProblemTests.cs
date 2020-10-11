using NUnit.Framework;
using Codility;

namespace CodilityTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArrayRotateTest()
        {
            var arr = new ArrayProblems();

            int[] testitem = { 3, 8, 9, 7, 6 };

            var testout = arr.Rotate(testitem, 3);

            int[] expected = { 9, 7, 6, 3, 8 };

            Assert.AreEqual(testout, expected);

            int[] empty = { };

            var testempty = arr.Rotate(empty, 3);

            Assert.AreEqual(0, testempty.Length);
        }

        [Test]
        public void OddManOutTest()
        {
            var arr = new ArrayProblems();

            int[] testitem = { 9, 3, 9, 3, 9, 7, 9 };

            var testout = arr.OddManOut(testitem);

            Assert.AreEqual(7, testout);

            int[] testitem2 = { 9, 3, 9, 3, 9, 11, 9 };

            var testout2 = arr.OddManOut(testitem2);

            Assert.AreEqual(11, testout2);

        }

        [Test]
        public void PermMissingElementTest()
        {
            var timeComp = new TimeComplexity();

            int[] test = { 2, 3, 1, 5 };

            int result = timeComp.PermMissingElement(test);

            Assert.AreEqual(4, result);

            int[] test2 = { 3, 2 };

            int result2 = timeComp.PermMissingElement(test2);

            Assert.AreEqual(1, result2);



        }
    }
}