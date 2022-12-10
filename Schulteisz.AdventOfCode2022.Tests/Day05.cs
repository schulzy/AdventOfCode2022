using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day05;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day05
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<string> sut = new SupplyStacks(contentParser);
            string result = sut.Run();
            Assert.AreEqual("GFTNRBZPF", result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<string> sut = new SupplyStacks(contentParser);
            string result = sut.Run();
            Assert.AreEqual("CMZ", result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<string> sut = new SupplyStacksHard(contentParser);
            string result = sut.Run();
            Assert.AreEqual("VRQWPDSGP", result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<string> sut = new SupplyStacksHard(contentParser);
            string result = sut.Run();
            Assert.AreEqual("MCD", result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "    [D]    ",
                    "[N] [C]    ",
                    "[Z] [M] [P]",
                    " 1   2   3 ",
                    "",
                    "move 1 from 2 to 1",
                    "move 3 from 1 to 3",
                    "move 2 from 2 to 1",
                    "move 1 from 1 to 2"
                };
            }
        }
    }
}

