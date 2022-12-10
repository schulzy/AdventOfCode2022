namespace Schulteisz.AdventOfCode2022.Day05
{
	public class Command
	{
        private readonly int _index;
        private readonly int _number;
        private readonly int _from;
        private readonly int _to;

        public Command(int index, int number, int from, int to)
		{
			_index = index;
			_number = number;
			_from = from;
			_to = to;
		}

        public int Index => _index;

        public int Number => _number;

        public int From => _from;

        public int To => _to;
    }
}

