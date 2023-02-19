namespace Schulteisz.AdventOfCode2022.Day08
{
	public class Forest
	{
		private int[,] _forest;
		private int _size;
		private TreeStatus[,] _forestStatus;
		private bool _isStatusPrepared = false;
		private long[,] _scenicScore;

        public Forest(int[,] forest, int size)
		{
			_forest = forest;
			_size = size;
            _forestStatus = new TreeStatus[size, size];
			_scenicScore = new long[size, size];

            for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					_forestStatus[i, j] = TreeStatus.Unknown;
				}
			}
		}

		public TreeStatus GetStatus(int x, int y)
		{
			if (!_isStatusPrepared)
			{
				PrepareStatus();
				_isStatusPrepared = true;
			}

			return _forestStatus[x, y];
		}

		public long GetScenicScore(int x,int y)
		{
            if (!_isStatusPrepared)
            {
                PrepareStatus();
                _isStatusPrepared = true;
            }

			return _scenicScore[x, y];
        }

		private void PrepareStatus()
		{
			for (int x = 0; x < _size; x++)
			{
				for (int y = 0; y < _size; y++)
				{
					if (_forestStatus[x, y] == TreeStatus.Visible)
						continue;

					if (x == 0 || y == 0 || x == _size - 1 || y == _size - 1)
					{
                        _forestStatus[x, y] = TreeStatus.Visible;
						_scenicScore[x, y] = -1;
						continue;
                    }

					int leftDeep = 0, rightDeep = 0, downDeep = 0, upDeep = 0;

					if (CheckLeft(x, y, _forest[x, y], ref leftDeep) |
						CheckRight(x, y, _forest[x, y], ref rightDeep) |
						CheckUp(x, y, _forest[x, y], ref upDeep) |
						CheckDown(x, y, _forest[x, y], ref downDeep))
						_forestStatus[x, y] = TreeStatus.Visible;
					else
						_forestStatus[x, y] = TreeStatus.Hidden;

					_scenicScore[x, y] = leftDeep * rightDeep * downDeep * upDeep;
                }
			}
		}

        private bool CheckDown(int x, int y, int referenceValue, ref int deep)
        {
            // if it is on the side, than we did not find bigger tree
            if (y + 1 >= _size)
                return true;

            deep++;
            if (_forest[x, y + 1] >= referenceValue)
                return false;
            else
                return CheckDown(x, y + 1, referenceValue, ref deep);
        }

        private bool CheckUp(int x, int y, int referenceValue, ref int deep)
		{
            // if it is on the side, than we did not find bigger tree
            if (y - 1 < 0)
				return true;

            deep++;
            if (_forest[x, y - 1] >= referenceValue)
				return false;
			else
				return CheckUp(x, y - 1, referenceValue, ref deep);
		}

        private bool CheckRight(int x, int y, int referenceValue, ref int deep)
        {
            // if it is on the side, than we did not find bigger tree
            if (x + 1 >= _size)
                return true;

			deep++;
            if (_forest[x + 1, y] >= referenceValue)
                return false;
            else
                return CheckRight(x + 1, y, referenceValue, ref deep);
        }

        private bool CheckLeft(int x, int y, int referenceValue, ref int deep)
        {
            // if it is on the side, than we did not find bigger tree
            if (x - 1 < 0)
				return true;

            deep++;
            if (_forest[x - 1, y] >= referenceValue)
				return false;
			else
				return CheckLeft(x - 1, y, referenceValue, ref deep);
        }
    }
}