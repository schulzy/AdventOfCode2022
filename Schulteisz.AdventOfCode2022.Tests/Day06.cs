using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Common;
using Schulteisz.AdventOfCode2022.Day06;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    public class Day06
	{
        [TestMethod]
        public void Task1()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(1155, result);
        }

        [TestMethod]
        public void Task1Predefined_1()
        {
            IContentParser contentParser = new PredefinedContentParser_1();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Task1Predefined_2()
        {
            IContentParser contentParser = new PredefinedContentParser_2();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Task1Predefined_3()
        {
            IContentParser contentParser = new PredefinedContentParser_3();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Task1Predefined_4()
        {
            IContentParser contentParser = new PredefinedContentParser_4();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Task1Predefined_5()
        {
            IContentParser contentParser = new PredefinedContentParser_5();

            IDailyTask<long> sut = new TuningTrouble(contentParser);
            long result = sut.Run();
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void Task2()
        {
            IContentParser contentParser = new ContentParser();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(2789, result);
        }

        [TestMethod]
        public void Task2Predefined_1()
        {
            IContentParser contentParser = new PredefinedContentParser_1();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(19, result);
        }

        

        [TestMethod]
        public void Task2Predefined_2()
        {
            IContentParser contentParser = new PredefinedContentParser_2();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Task2Predefined_3()
        {
            IContentParser contentParser = new PredefinedContentParser_3();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void Task2Predefined_4()
        {
            IContentParser contentParser = new PredefinedContentParser_4();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void Task2Predefined_5()
        {
            IContentParser contentParser = new PredefinedContentParser_5();

            IDailyTask<long> sut = new TuningTroubleHard(contentParser);
            long result = sut.Run();
            Assert.AreEqual(26, result);
        }
    }

    internal class PredefinedContentParser_1 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "mjqjpqmgbljsphdztnvjfqwrcgsmlb"
            };
        }
    }

    internal class PredefinedContentParser_2 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "bvwbjplbgvbhsrlpgdmjqwftvncz"
            };
        }
    }

    internal class PredefinedContentParser_3 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "nppdvjthqldpwncqszvftbrmjlhg"
            };
        }
    }

    internal class PredefinedContentParser_4 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"
            };
        }
    }

    internal class PredefinedContentParser_5 : IContentParser
    {
        public List<string> GetLines(string manifestName)
        {
            return new List<string>()
            {
                "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"
            };
        }
    }
}

