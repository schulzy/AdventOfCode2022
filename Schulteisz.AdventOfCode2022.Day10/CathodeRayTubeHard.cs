using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CathodeRayTubeHard : IDailyTask<List<string>>
    {
        private IContentParser contentParser;

        public CathodeRayTubeHard(IContentParser contentParser)
        {
            this.contentParser = contentParser;
        }

        public string Name => "Cathode-Ray Tube Hard";

        public List<string> Run()
        {
            throw new NotImplementedException();
        }
    }
}

