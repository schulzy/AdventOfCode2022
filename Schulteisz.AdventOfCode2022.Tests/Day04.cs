using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day04;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day04
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask sut = new CampCleanup(contentParser);
            long result = sut.Run();
            Assert.AreEqual(538, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask sut = new CampCleanup(contentParser);
            long result = sut.Run();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask sut = new CampCleanupHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(792, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask sut = new CampCleanupHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(4, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "2-4,6-8",
                    "2-3,4-5",
                    "5-7,7-9",
                    "2-8,3-7",
                    "6-6,4-6",
                    "2-6,4-8"
                };
            }
        }
    }
}

