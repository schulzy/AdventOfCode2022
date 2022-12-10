using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day08;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day08
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new TreetopTreeHouse(contentParser);
            long result = sut.Run();
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new TreetopTreeHouse(contentParser);
            long result = sut.Run();
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new TreetopTreeHouseHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new TreetopTreeHouseHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(-1, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "30373",
                    "25512",
                    "65332",
                    "33549",
                    "35390"
                };
            }
        }
    }
}

