namespace Schulteisz.AdventOfCode2022.Day07
{
    internal interface ICommand
    {
        
    }

    internal interface ILsCommand : ICommand
    {
        void AddOutput(string line);
        List<string> Dirs { get; }
        List<(string name, long size)> Files { get; }
    }

    internal interface ICdCommand : ICommand
    {
        ChangeDirectoryType ChangeDirectoryType { get; }
        string FolderName { get; }
    }
}

