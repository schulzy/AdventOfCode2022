using Microsoft.VisualStudio.TestTools.UnitTesting;
using Schulteisz.AdventOfCode2022.Interfaces;
using System.Collections.Generic;

namespace Schulteisz.AdventOfCode2022.Tests
{
    [TestClass]
    internal class Day13
    {
        [TestMethod]
        public void Task1() 
        {
        }

        [TestMethod]
        public void Task1Predefined()
        {
        }

        [TestMethod]
        public void Task2()
        {
        }

        [TestMethod]
        public void Task2Predefined()
        {
        }

        internal class PredefinedContentParser : IContentParser
        {
            public List<string> GetLines(string manifestName)
            {
                return new List<string>()
                {
                    
                };
            }
        }
    }
}
