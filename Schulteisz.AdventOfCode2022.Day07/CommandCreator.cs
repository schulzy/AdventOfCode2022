namespace Schulteisz.AdventOfCode2022.Day07
{
    internal class CommandCreator : ICommandCreator
    {
        public ICommand Do(string line)
        {
            string[] chunks = line.Split(" ");
            switch (chunks[1])
            {
                case "cd":
                    return new CdCommand(line);
                case "ls":
                    return new LsCommand(line);
                default:
                    throw new ArgumentOutOfRangeException($"There is no {chunks[1]} command");
            }
        }
    }

    internal interface ICommandCreator
    {
        ICommand Do(string line);
    }
}