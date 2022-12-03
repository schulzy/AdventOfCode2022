using System;
using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day03
{
	public class RucksackReorganization : IDailyTask
    {
        private IContentParser contentParser;

        public RucksackReorganization(IContentParser contentParser)
        {
            this.contentParser = contentParser;
        }

        public string Name => "Rucksack Reorganization";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

