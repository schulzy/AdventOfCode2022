using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day06
{
    public class TuningTrouble : IDailyTask<long>
    {
        private IContentParser _contentParser;

        public TuningTrouble(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Tuning Trouble";

        public long Run()
        {
            StreamProcessor streamProcessor = new StreamProcessor(_contentParser.GetLines("Task.txt").First());
            return streamProcessor.FindFirstPosition(4);
        }
    }
}

