using System.Collections.Generic;

namespace Schulteisz.AdventOfCode2022.Day07
{
    internal class LsCommand : ILsCommand
    {
        private string _line;
        public List<string> Dirs { get; } = new List<string>();
        public List<(string name, long size)> Files { get; } = new List<(string, long)>();


        public LsCommand(string line)
        {
            _line = line;
        }

        public void AddOutput(string line)
        {
            string[] content = line.Split(" ");
            if (string.Compare( content[0], "dir") == 0)
                Dirs.Add(content[1]);
            else
                Files.Add((content[1], long.Parse(content[0])));
        }
    }

    
}