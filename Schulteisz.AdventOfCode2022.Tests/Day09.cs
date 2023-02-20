using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day09;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day09
    {
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new RopeBridge(contentParser);
            long result = sut.Run();
            Assert.AreEqual(5907, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new RopeBridge(contentParser);
            long result = sut.Run();
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new RopeBridgeHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParserHard();

            IDailyTask<long> sut = new RopeBridgeHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(36, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "R 4",
                    "U 4",
                    "L 3",
                    "D 1",
                    "R 4",
                    "D 1",
                    "L 5",
                    "R 2"
                };
            }
        }

        internal class PredefinedContentParserHard : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "R 5",
                    "U 8",
                    "L 8",
                    "D 3",
                    "R 17",
                    "D 10",
                    "L 25",
                    "U 20"
                };
            }
        }
    }
}

