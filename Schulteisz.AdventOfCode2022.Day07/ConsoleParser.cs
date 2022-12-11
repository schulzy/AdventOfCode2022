namespace Schulteisz.AdventOfCode2022.Day07
{
	internal class ConsoleParser
	{
		private readonly IEnumerable<string> _lines;
		public ConsoleParser(IEnumerable<string> lines)
		{
			_lines = lines;
		}

		internal Console Create(ICommandCreator commandCreator)
		{
			Console console = new Console();
            ICommand? actualCommand = null;
            foreach (var line in _lines)
			{
				if(line.StartsWith("$"))
				{
                    actualCommand = commandCreator.Do(line);
                    console.AddCommand(actualCommand);
                    continue;
                }

				if(actualCommand is null)
					throw new NullReferenceException("actualCommand is null");
				if (actualCommand is ILsCommand)
					((ILsCommand)actualCommand).AddOutput(line);
				else
					throw new ArgumentOutOfRangeException("The command type is not proper");
            }
			

			return console;
		}
	}
}

