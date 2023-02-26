namespace Schulteisz.AdventOfCode2022.Day10
{
	public class CycleManager
	{
		public Queue<Command> Commands { get; private set; } = new Queue<Command>();
		public CycleManager(List<Command> commands)
		{
			commands.ForEach(command => Commands.Enqueue(command));
		}

        public CycleManager(List<string> list)
        {
			foreach (var item in list)
			{
				Command command;
				string[] input = item.Split(" ");
				if (input.Length > 1)
					command = CommandFactory.CreateAddx(int.Parse(input[1]));
				else
					command = CommandFactory.CreateNoop();

				Commands.Enqueue(command);
			}
        }

        public int RunCycle()
		{
			int x = 1;
			int cycleTime = 0;
			int sumSpecalCycle = 0;
			while (true)
			{
				if (!Commands.TryDequeue(out var command))
					break;

				for (int i = 0; i < command.CycleTime; i++)
				{
					cycleTime++;
					if ((cycleTime - 20) % 40 == 0)
                        sumSpecalCycle += cycleTime*x;
                }
				x += command.Value;
			}

			return sumSpecalCycle;
		}
	}
}


