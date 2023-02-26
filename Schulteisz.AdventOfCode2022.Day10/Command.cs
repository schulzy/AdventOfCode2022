namespace Schulteisz.AdventOfCode2022.Day10
{
	public class Command
	{
		public int CycleTime { get; private set; }
		public int Value { get; private set; }

		public Command(int cycleTime, int value = 0)
		{
			CycleTime = cycleTime;
			Value = value;
		}
	}
}

