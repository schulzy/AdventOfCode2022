using System.Text;

namespace Schulteisz.AdventOfCode2022.Day05
{
	internal class CraneSystem : ICraneSystem
    {
		private readonly List<ICrane> _cranes = new List<ICrane>();
        private ICommandSystem _commands;

        public CraneSystem(ICommandSystem commands)
        {
            _commands = commands;
        }

        public int Length => _cranes.Count;

        public void AddCrane(ICrane crane)
		{
			_cranes.Add(crane);
        }

        public string RunCommands()
        {
            _cranes.ForEach(crane => crane.Init());

            foreach (var command in _commands)
                ApplyCommand(command);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var crane in _cranes)
            {
                stringBuilder.Append(crane.Take(1).First());
            }

            return stringBuilder.ToString();
        }

        private void ApplyCommand(Command command)
        {
            ICrane fromCrane = this[command.From - 1];
            ICrane toCrane = this[command.To - 1];
            toCrane.Push(fromCrane.Take(command.Number));
        }

        public ICrane this[int i]
		{
			get { return _cranes[i]; }
		}
	}

	internal interface ICraneSystem
	{
		void AddCrane(ICrane crane);
        string RunCommands();

        int Length { get; }

		ICrane this[int i] {get;}
    }
}

