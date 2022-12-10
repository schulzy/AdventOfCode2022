using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day05
{
	public class SupplyStacks : IDailyTask<string>
    {
        private readonly IContentParser _contentParser;

        public SupplyStacks(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Supply Stacks Hard";

        public string Run()
        {
            var content = _contentParser.GetLines("Task.txt");
            ICommandSystem commands = new CommandSystem();
            ICraneSystem craneSystem = new CraneSystem(commands);
            ICraneFactory craneFactory = new CrateMover9000Factory();
            CraneParser.Create(content, craneSystem, craneFactory);
            CommandParser.Create(content, commands);
            string result = craneSystem.RunCommands();
            return result;
        }
    }
}

