namespace Schulteisz.AdventOfCode2022.Day09
{
	internal class RopeBridgeManager
	{
		private Dictionary<string, Direction> enumMapping = new Dictionary<string, Direction>()
		{
			{"U", Direction.Up },
			{"D", Direction.Down },
			{"L",Direction.Left },
			{"R",Direction.Right }
		};
		private RopeMap _ropeMap;

        public RopeBridgeManager(List<string> list, int length)
		{
            _ropeMap = new RopeMap(length);

			foreach (var line in list)
			{
				string[] lineParams = line.Split(" ");
                _ropeMap.AddStep(enumMapping[lineParams[0]], int.Parse(lineParams[1]));

            }
		}

		public long GetTailTouch()
		{
			return _ropeMap.Tail.Count;
		}
	}
}

