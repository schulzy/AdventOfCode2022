namespace Schulteisz.AdventOfCode2022.Day07
{
    internal class CdCommand : ICdCommand
    {
        private string _line;
        public string FolderName { get; }
        public ChangeDirectoryType ChangeDirectoryType { get; }

        public CdCommand(string line)
        {
            _line = line;
            FolderName = line.Split(" ")[2].Trim();
            switch (FolderName)
            {
                case "/":
                    ChangeDirectoryType = ChangeDirectoryType.Root;
                    break;
                case "..":
                    ChangeDirectoryType = ChangeDirectoryType.Parent;
                    break;
                default:
                    ChangeDirectoryType = ChangeDirectoryType.Folder;
                    break;
            }
        }
    }

    internal enum ChangeDirectoryType
    {
        Root,
        Folder,
        Parent
    }
}