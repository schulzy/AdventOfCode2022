namespace Schulteisz.AdventOfCode2022.Day07
{
	internal class Directory : IDirectory
    {
        private readonly IDirectory _parent;
        private readonly bool _hasParent;
        private Dictionary<string, IDirectory> _children = new Dictionary<string, IDirectory>();
        private List<File> _files = new List<File>();

        public Directory(string name, IDirectory parent)
		{
            Name = name;
            _parent = parent;
            if (parent is NullDirectory)
                _hasParent = false;
            else
                _hasParent = true;
        }

        public string Name { get; }

        public bool HasParent => _hasParent;

        public IDirectory Parent => _parent;

        public long Size
        {
            get
            {
                long sum = 0;
                foreach (var file in _files)
                    sum += file.Size;

                foreach (var child in _children.Values)
                    sum += child.Size;

                return sum;
            }
        }

        public IEnumerable<IDirectory> Children
        {
            get
            {
                return _children.Select(item => item.Value);
            }
        }

        public IDirectory GetChild(string name)
        {
            if(!_children.TryGetValue(name, out IDirectory? childDir))
            {
                childDir = new Directory(name, this);
                _children.Add(name, childDir);
            }
            return childDir;
        }

        public void AddFile(File file)
        {
            _files.Add(file);
        }
    }

    internal class NullDirectory : IDirectory
    {
        private static NullDirectory? _directory = null;
        private NullDirectory()
        {
        }

        public static NullDirectory Instance
        {
            get
            {
                if (_directory is null)
                    _directory = new NullDirectory();
                return _directory;
            }
        }

        public bool HasParent => false;

        public IDirectory Parent => this;

        public long Size => throw new NotImplementedException();

        public IEnumerable<IDirectory> Children => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public void AddFile(File file)
        {
            throw new NotImplementedException();
        }

        public IDirectory GetChild(string name)
        {
            return this;
        }
    }

    internal interface IDirectory
    {
        bool HasParent { get; }
        string Name { get; }
        IDirectory GetChild(string name);
        IDirectory Parent { get; }
        IEnumerable<IDirectory> Children { get; }
        void AddFile(File file);
        long Size { get; }
    }
}

