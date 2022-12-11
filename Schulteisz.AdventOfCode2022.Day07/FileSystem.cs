namespace Schulteisz.AdventOfCode2022.Day07
{
	internal class FileSystem : IFileSystem
    {
        private IDirectory _actualDirectory = NullDirectory.Instance;
        public IDirectory Root { get; } = new Directory("/", NullDirectory.Instance);

        public void NavigateTo(string name)
        {
            _actualDirectory = _actualDirectory.GetChild(name);
        }

        public void SetRoot()
        {
            _actualDirectory = Root;
        }

        public void AddFile(string name, long size)
        {
            _actualDirectory.AddFile(new File(name, size, _actualDirectory));
        }

        public void NavigateUp()
        {
            _actualDirectory = _actualDirectory.Parent;
        }

        public void AddDir(string name)
        {
            _actualDirectory.GetChild(name);    
        }
    }

	internal interface IFileSystem
	{
        IDirectory Root { get; }

        void NavigateTo(string name);
        void NavigateUp();
        void SetRoot();

        void AddFile(string name, long size);
        void AddDir(string name);
	}
}

