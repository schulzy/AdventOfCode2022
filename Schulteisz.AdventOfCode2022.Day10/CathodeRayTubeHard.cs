using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CathodeRayTubeHard : IDailyTask<List<string>>
    {
        private IContentParser _contentParser;

        public CathodeRayTubeHard(IContentParser contentParser)
        {
            _contentParser = contentParser;
        }

        public string Name => "Cathode-Ray Tube Hard";

        public List<string> Run()
        {
            CycleManager cycleManager = new CycleManager(_contentParser.GetLines("Task.txt"));
            ICalcuator<List<string>> calcuator = new ComplexCalculator();
            return cycleManager.RunCycle<List<string>>(calcuator);
        }
    }
}

