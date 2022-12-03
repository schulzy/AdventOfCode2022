using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day01;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day01
    {
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask sut = new CalorieCounting(contentParser);
            long result = sut.Run();
            Assert.AreEqual(69836, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask sut = new CalorieCounting(contentParser);
            long result = sut.Run();
            Assert.AreEqual(24000, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask sut = new CalorieCountingHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(207968, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask sut = new CalorieCountingHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(45000, result);
        }
    }

    internal class PredefinedContentParser : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "1000",
"2000",
"3000",
"",
"4000",
"",
"5000",
"6000",
"",
"7000",
"8000",
"9000",
"",
"10000"
            };
        }
    }
}