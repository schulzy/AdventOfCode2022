using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day02;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day02
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new RockPaperScissors(contentParser);
            long result = sut.Run();
            Assert.AreEqual(14163, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new RockPaperScissors(contentParser);
            long result = sut.Run();
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new RockPaperScissorsHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(12091, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new RockPaperScissorsHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(12, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "A Y",
                    "B X",
                    "C Z"
                };
            }
        }
    }
}

