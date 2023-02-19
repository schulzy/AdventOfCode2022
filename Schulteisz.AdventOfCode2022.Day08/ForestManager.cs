namespace Schulteisz.AdventOfCode2022.Day08
{
	internal class ForestManager
	{
		private readonly Forest _forest;
		private readonly int _size;
		public ForestManager(List<string> list)
		{
            _size = list.Count;
			int[,] matrixForest = new int[_size, _size];
			int lineNumber = -1;
			foreach (var line in list)
			{
				lineNumber++;
				for (int x = 0; x < _size; x++)
				{
					matrixForest[x, lineNumber] = int.Parse(line[x].ToString());
				}
				
			}

			_forest = new Forest(matrixForest, _size);
		}

		public int GetVisibleTreeCount()
		{
			int counter = 0;
			for (int x = 0; x < _size; x++)
			{
				for (int y = 0; y < _size; y++)
				{
					var treeStatus = _forest.GetStatus(x, y);

                    if (treeStatus == TreeStatus.Visible)
						counter++;
					if (treeStatus == TreeStatus.Unknown)
						throw new ArgumentException("Not valid value");
				}
			}

			return counter;
		}

        public long GetBiggestScenicScore()
        {
			long scenicScore = 0;
            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    long score = _forest.GetScenicScore(x, y);

					if (score > scenicScore)
						scenicScore = score;
                }
            }

			return scenicScore;
        }
    }
}