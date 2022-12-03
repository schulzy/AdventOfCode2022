using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day02
{
	public class RockPaperScissors : IDailyTask
	{
        private readonly IContentParser _contentParser;

        public RockPaperScissors(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Rock Paper Scissors";

        public long Run()
        {
            GameField game = new GameField(_contentParser.GetLines("Task.txt"));
            Dictionary<string, IGameActor> enemy = new Dictionary<string, IGameActor> {
                { "A", new Rock() },
                { "B", new Paper() },
                { "C", new Scissors() },
            };
            Dictionary<string, Func<IGameActor, IGameActor>> response = new Dictionary<string, Func<IGameActor, IGameActor>> {
                { "Y", (_) => new Paper() },
                { "X", (_) => new Rock() },
                { "Z", (_) => new Scissors() },
            };

            return game.GetPoints(enemy, response);
        }
    }
}

