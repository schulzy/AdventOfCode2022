namespace Schulteisz.AdventOfCode2022.Day05
{
    internal class CommandParser
    {
        internal static void Create(List<string> content, ICommandSystem commandSystem)
        {
            bool isCommand = false;
            int commandCounter = -1;
            foreach (var item in content)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    isCommand = true;
                    continue;
                }

                if (isCommand)
                {
                    commandCounter++;
                    string[] movements = item.Split(" ");
                    commandSystem.AddCommand(commandCounter, movements[1], movements[3], movements[5]);
                }
            }
        }
    }
}