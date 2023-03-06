using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day11;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day11
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new MonkeyInTheMiddle(contentParser);
            long result = sut.Run();
            Assert.AreEqual(95472, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new MonkeyInTheMiddle(contentParser);
            long result = sut.Run();
            Assert.AreEqual(10605, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new MonkeyInTheMiddleHard(contentParser, 10000);
            long result = sut.Run();
            Assert.AreEqual(17926061332, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new MonkeyInTheMiddleHard(contentParser, 10000);
            long result = sut.Run();
            Assert.AreEqual(2713310158, result);
        }

        [TestMethod]
        [DataRow(1, new long[] { 2,4,3,6})]
        [DataRow(20, new long[] { 99,97,8,103})]
        [DataRow(1000, new long[] { 5204, 4792, 199, 5192 })]
        [DataRow(2000, new long[] { 10419, 9577, 392, 10391 })]
        [DataRow(3000, new long[] { 15638, 14358, 587, 15593 })]
        [DataRow(4000, new long[] { 20858, 19138, 780, 20797 })]
        [DataRow(5000, new long[] { 26075, 23921, 974, 26000 })]
        [DataRow(6000, new long[] { 31294, 28702, 1165, 31204 })]
        [DataRow(7000, new long[] { 36508, 33488, 1360, 36400 })]
        [DataRow(8000, new long[] { 41728, 38268, 1553, 41606 })]
        [DataRow(9000, new long[] { 46945, 43051, 1746, 46807 })]
        [DataRow(10000, new long[] { 52166, 47830, 1938, 52013 })]
        public void Task2PredefinedParts(int input, long[] expected)
        {
            IContentParser contentParser = new PredefinedContentParser();

            MonkeyInTheMiddleHard sut = new MonkeyInTheMiddleHard(contentParser, input);
            List<long> result = sut.GetPartResults();
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
            Assert.AreEqual(expected[3], result[3]);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "Monkey 0:",
                    "  Starting items: 79, 98",
                    "  Operation: new = old * 19",
                    "  Test: divisible by 23",
                    "    If true: throw to monkey 2",
                    "    If false: throw to monkey 3",
                    "",
                    "Monkey 1:",
                    "  Starting items: 54, 65, 75, 74",
                    "  Operation: new = old + 6",
                    "  Test: divisible by 19",
                    "    If true: throw to monkey 2",
                    "    If false: throw to monkey 0",
                    "",
                    "Monkey 2:",
                    "  Starting items: 79, 60, 97",
                    "  Operation: new = old * old",
                    "  Test: divisible by 13",
                    "    If true: throw to monkey 1",
                    "    If false: throw to monkey 3",
                    "",
                    "Monkey 3:",
                    "  Starting items: 74",
                    "  Operation: new = old + 3",
                    "  Test: divisible by 17",
                    "    If true: throw to monkey 0",
                    "    If false: throw to monkey 1"
                };
            }
        }
    }
}

