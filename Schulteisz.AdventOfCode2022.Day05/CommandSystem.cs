using System.Collections;

namespace Schulteisz.AdventOfCode2022.Day05
{
    internal class CommandSystem : ICommandSystem
    {
        private IList<Command> _commands = new List<Command>();

        public void AddCommand(int index, string number, string from, string to)
        {
            _commands.Add(new Command(index, int.Parse(number), int.Parse(from), int.Parse(to)));
        }

        public IEnumerator<Command> GetEnumerator()
        {
            return _commands.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal interface ICommandSystem : IEnumerable<Command>
    {
        void AddCommand(int index, string count, string from, string to);
    }
}