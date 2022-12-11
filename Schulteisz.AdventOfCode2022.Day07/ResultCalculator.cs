namespace Schulteisz.AdventOfCode2022.Day07
{
    internal class ResultCalculator : IResultCalculator
    {
        private const long MAX_VALUE = 100000;
        private IFileSystem _fileSystem;
        private Dictionary<IDirectory, long> _dirSize = new Dictionary<IDirectory, long>();
        private Dictionary<long, IList<IDirectory>> maxValue = new Dictionary<long, IList<IDirectory>>();

        public ResultCalculator(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public long CalculateSum()
        {
            CollectDirSize(_fileSystem.Root, MAX_VALUE);
            return _dirSize.Sum(item => item.Value);
        }

        public long CalculateDeleteSum()
        {
            CollectDirSize(_fileSystem.Root, long.MaxValue);
            long freeSpace = 30000000 - (70000000 - _fileSystem.Root.Size);
            return _dirSize.Where(item => item.Value > freeSpace).Min(item => item.Value);
        }

        private void CalculateDirSize(List<IDirectory> dirs)
        {
            foreach (var dir in _dirSize.Keys)
            {
                if (dirs.Contains(dir))
                    continue;

                long sum = dirs.Sum(item => item.Size) + dir.Size;
                if (sum <= MAX_VALUE)
                {
                    dirs.Add(dir);
                    maxValue.TryAdd(sum, dirs);
                    CalculateDirSize(dirs);
                    dirs.Remove(dir);
                } 

            }
        }

        private void CollectDirSize(IDirectory directory, long maxValue)
        {
            foreach (IDirectory dir in directory.Children)
            {
                if (dir.Size <= maxValue)
                    _dirSize.Add(dir, dir.Size);

                CollectDirSize(dir, maxValue);
            }
        }
    }

    internal interface IResultCalculator
    {
        long CalculateSum();
        long CalculateDeleteSum();
    }
}