using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day07
{
	public class NoSpaceLeftOnDeviceHard : IDailyTask<long>
	{
        private IContentParser _contentParser;

        public NoSpaceLeftOnDeviceHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "No Space Left On Device Hard";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

