using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day10;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day10
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new CathodeRayTube(contentParser);
            long result = sut.Run();
            Assert.AreEqual(13740, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new CathodeRayTube(contentParser);
            long result = sut.Run();
            Assert.AreEqual(13140, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<List<string>> sut = new CathodeRayTubeHard(contentParser);
            List<string> result = sut.Run();
            Assert.AreEqual("", result[0]);
            Assert.AreEqual("", result[1]);
            Assert.AreEqual("", result[2]);
            Assert.AreEqual("", result[3]);
            Assert.AreEqual("", result[4]);
            Assert.AreEqual("", result[5]);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<List<string>> sut = new CathodeRayTubeHard(contentParser);
            List<string> result = sut.Run();
            Assert.AreEqual("##..##..##..##..##..##..##..##..##..##..", result[0]);
            Assert.AreEqual("###...###...###...###...###...###...###.", result[1]);
            Assert.AreEqual("####....####....####....####....####....", result[2]);
            Assert.AreEqual("#####.....#####.....#####.....#####.....", result[3]);
            Assert.AreEqual("######......######......######......####", result[4]);
            Assert.AreEqual("#######.......#######.......#######.....", result[5]);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "addx 15",
                    "addx -11",
                    "addx 6",
                    "addx -3",
                    "addx 5",
                    "addx -1",
                    "addx -8",
                    "addx 13",
                    "addx 4",
                    "noop",
                    "addx -1",
                    "addx 5",
                    "addx -1",
                    "addx 5",
                    "addx -1",
                    "addx 5",
                    "addx -1",
                    "addx 5",
                    "addx -1",
                    "addx -35",
                    "addx 1",
                    "addx 24",
                    "addx -19",
                    "addx 1",
                    "addx 16",
                    "addx -11",
                    "noop",
                    "noop",
                    "addx 21",
                    "addx -15",
                    "noop",
                    "noop",
                    "addx -3",
                    "addx 9",
                    "addx 1",
                    "addx -3",
                    "addx 8",
                    "addx 1",
                    "addx 5",
                    "noop",
                    "noop",
                    "noop",
                    "noop",
                    "noop",
                    "addx -36",
                    "noop",
                    "addx 1",
                    "addx 7",
                    "noop",
                    "noop",
                    "noop",
                    "addx 2",
                    "addx 6",
                    "noop",
                    "noop",
                    "noop",
                    "noop",
                    "noop",
                    "addx 1",
                    "noop",
                    "noop",
                    "addx 7",
                    "addx 1",
                    "noop",
                    "addx -13",
                    "addx 13",
                    "addx 7",
                    "noop",
                    "addx 1",
                    "addx -33",
                    "noop",
                    "noop",
                    "noop",
                    "addx 2",
                    "noop",
                    "noop",
                    "noop",
                    "addx 8",
                    "noop",
                    "addx -1",
                    "addx 2",
                    "addx 1",
                    "noop",
                    "addx 17",
                    "addx -9",
                    "addx 1",
                    "addx 1",
                    "addx -3",
                    "addx 11",
                    "noop",
                    "noop",
                    "addx 1",
                    "noop",
                    "addx 1",
                    "noop",
                    "noop",
                    "addx -13",
                    "addx -19",
                    "addx 1",
                    "addx 3",
                    "addx 26",
                    "addx -30",
                    "addx 12",
                    "addx -1",
                    "addx 3",
                    "addx 1",
                    "noop",
                    "noop",
                    "noop",
                    "addx -9",
                    "addx 18",
                    "addx 1",
                    "addx 2",
                    "noop",
                    "noop",
                    "addx 9",
                    "noop",
                    "noop",
                    "noop",
                    "addx -1",
                    "addx 2",
                    "addx -37",
                    "addx 1",
                    "addx 3",
                    "noop",
                    "addx 15",
                    "addx -21",
                    "addx 22",
                    "addx -6",
                    "addx 1",
                    "noop",
                    "addx 2",
                    "addx 1",
                    "noop",
                    "addx -10",
                    "noop",
                    "noop",
                    "addx 20",
                    "addx 1",
                    "addx 2",
                    "addx 2",
                    "addx -6",
                    "addx -11",
                    "noop",
                    "noop",
                    "noop"
                };
            }
        }
    }
}

