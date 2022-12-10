using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day09
{
	public class RopeBridge : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public RopeBridge(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Rope Bridge";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

