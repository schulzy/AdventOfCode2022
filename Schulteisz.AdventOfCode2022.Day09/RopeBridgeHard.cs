using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day09
{
	public class RopeBridgeHard : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public RopeBridgeHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Rope Bridge Hard";

        public long Run()
        {
            RopeBridgeManager forestManager = new RopeBridgeManager(_contentParser.GetLines("Task.txt"));
            return forestManager.GetTailTouch();
        }
    }
}

