﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day12;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day12
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new HillClimbingAlgorithm(contentParser);
            long result = sut.Run();
            Assert.AreEqual(420, result);
        }

        [TestMethod]
        public void Task1Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new HillClimbingAlgorithm(contentParser);
            long result = sut.Run();
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new HillClimbingAlgorithmHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(414, result);
        }

        [TestMethod]
        public void Task2Predefined()
        {
            IContentParser contentParser = new PredefinedContentParser();

            IDailyTask<long> sut = new HillClimbingAlgorithmHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(29, result);
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    "Sabqponm",
                    "abcryxxl",
                    "accszExk",
                    "acctuvwj",
                    "abdefghi"
                 };
            }
        }
    }
}

