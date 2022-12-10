using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day07
{
	public class NoSpaceLeftOnDevice : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public NoSpaceLeftOnDevice(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "No Space Left On Device";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

