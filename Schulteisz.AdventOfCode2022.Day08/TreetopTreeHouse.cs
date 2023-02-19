using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day08
{
	public class TreetopTreeHouse : IDailyTask<long>
    {
        private readonly IContentParser _contentParser;

        public TreetopTreeHouse(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Treetop Tree House";

        public long Run()
        {
            ForestManager forestManager = new ForestManager(_contentParser.GetLines("Task.txt"));
            return forestManager.GetVisibleTreeCount();
        }
    }
}

