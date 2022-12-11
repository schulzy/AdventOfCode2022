namespace Schulteisz.AdventOfCode2022.Day07
{
	internal class Console
	{
        private List<ICommand> _commands = new List<ICommand>();

        internal void AddCommand(ICommand actualCommand)
        {
            _commands.Add(actualCommand);
        }

        internal void PrepareFileSystem(IFileSystem fileSystem)
        {
            foreach (var command in _commands)
            {
                switch (command)
                {
                    case ILsCommand cmd:
                        ProcessLs(fileSystem, cmd);
                        break;
                    case ICdCommand cmd:
                        ProcessCd(fileSystem, cmd);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(command));
                }
            }
        }

        private void ProcessCd(IFileSystem fileSystem, ICdCommand command)
        {
            switch (command.ChangeDirectoryType)
            {
                case ChangeDirectoryType.Folder:
                    fileSystem.NavigateTo(command.FolderName);
                    break;
                case ChangeDirectoryType.Root:
                    fileSystem.SetRoot();
                    break;
                case ChangeDirectoryType.Parent:
                    fileSystem.NavigateUp();
                    break;
                default:    
                    break;
            }
        }

        private void ProcessLs(IFileSystem fileSystem, ILsCommand command)
        {
            foreach (var dir in command.Dirs)
            {
                fileSystem.AddDir(dir);
            }   

            foreach (var file in command.Files)
            {
                fileSystem.AddFile(file.name, file.size);
            }
        }

        
    }
}

