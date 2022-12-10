using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CathodeRayTube : IDailyTask<long>
    {
        private IContentParser contentParser;

        public CathodeRayTube(IContentParser contentParser)
        {
            this.contentParser = contentParser;
        }

        public string Name => "Cathode-Ray Tube";

        public long Run()
        {
            throw new NotImplementedException();
        }
    }
}

