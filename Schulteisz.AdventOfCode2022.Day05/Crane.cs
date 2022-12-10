namespace Schulteisz.AdventOfCode2022.Day05
{
    internal class Crane : ICrane
    {
        private int _index;
        protected readonly Stack<string> _containers = new Stack<string>();
        private readonly Stack<string> _tempStack = new Stack<string>();

        public Crane(int index)
        {
            _index = index;
        }

        public void AddContainer(string container)
        {
            _tempStack.Push(container);
        }

        public void Init()
        {
            while (_tempStack.Count > 0)
                _containers.Push(_tempStack.Pop());
        }

        public void Push(IEnumerable<string> values)
        {
            foreach (var item in values)
                _containers.Push(item);
        }

        public virtual IEnumerable<string> Take(int number)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < number; i++)
                result.Add(_containers.Pop());

            return result;
        }
    }
}