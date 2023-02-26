namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CommandFactory
	{
		public static Command CreateNoop()
		{
			return new Command(1, 0);
		}

		public static Command CreateAddx(int value)
		{
			return new Command(2, value);
		}
	}
}

