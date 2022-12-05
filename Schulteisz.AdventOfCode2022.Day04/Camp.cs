namespace Schulteisz.AdventOfCode2022.Day04
{
	internal class Camp
	{
		List<Pair> _pairs = new List<Pair>();
		public Camp(List<string> list)
		{
			CreatePairs(list);
		}

		public long NumberOfOverlappingElements()
		{
			return _pairs.Count(pair => pair.OverlapSections());
		}

        public long NumberOfSimpleOverlappingElements()
        {
            return _pairs.Count(pair => pair.OverlapSimple());
        }

        private void CreatePairs(List<string> list)
        {
			foreach (var pair in list)
			{
				_pairs.Add(new Pair(pair));
			}
        }
    }
}

