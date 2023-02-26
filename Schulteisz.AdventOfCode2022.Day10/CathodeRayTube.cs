using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CathodeRayTube : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public CathodeRayTube(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Cathode-Ray Tube";

        public long Run()
        {
            CycleManager cycleManager = new CycleManager(_contentParser.GetLines("Task.txt"));
            return cycleManager.RunCycle();
        }
    }
}

