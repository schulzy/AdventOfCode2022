using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day07;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day07
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new NoSpaceLeftOnDevice(contentParser);
            long result = sut.Run();
            Assert.AreEqual(1141028, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new NoSpaceLeftOnDevice(contentParser);
            long result = sut.Run();
            Assert.AreEqual(95437, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new NoSpaceLeftOnDeviceHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(8278005, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new NoSpaceLeftOnDeviceHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(24933642, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "$ cd /",
                    "$ ls",
                    "dir a",
                    "14848514 b.txt",
                    "8504156 c.dat",
                    "dir d",
                    "$ cd a",
                    "$ ls",
                    "dir e",
                    "29116 f",
                    "2557 g",
                    "62596 h.lst",
                    "$ cd e",
                    "$ ls",
                    "584 i",
                    "$ cd ..",
                    "$ cd ..",
                    "$ cd d",
                    "$ ls",
                    "4060174 j",
                    "8033020 d.log",
                    "5626152 d.ext",
                    "7214296 k"
                };
            }
        }
    }
}

