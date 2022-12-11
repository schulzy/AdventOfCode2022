namespace Schulteisz.AdventOfCode2022.Day07
{
	internal class File
	{
		public File(string name, long size, IDirectory parent)
		{
            Name = name;
            Size = size;
            Parent = parent;
        }

        public string Name { get; }
        public long Size { get; }
        public IDirectory Parent { get; }
    }
}

