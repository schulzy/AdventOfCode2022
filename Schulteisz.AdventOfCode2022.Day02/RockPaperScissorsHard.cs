using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day02
{
	public class RockPaperScissorsHard : IDailyTask<long>
    {
        private readonly IContentParser _contentParser;

        public RockPaperScissorsHard(IContentParser contentParser)
		{
            _contentParser = contentParser;
        }

        public string Name => "Rock Paper Scissors Hard";

        public long Run()
        {
            GameField game = new GameField(_contentParser.GetLines("Task.txt"));
            Dictionary<string, IGameActor> enemy = new Dictionary<string, IGameActor> {
                { "A", new Rock() },
                { "B", new Paper() },
                { "C", new Scissors() },
            };

            Dictionary<string, Func<IGameActor, IGameActor>> response = new Dictionary<string, Func<IGameActor, IGameActor>> {
                { "Y", (enemy) => enemy.Draw() },
                { "X", (enemy) => enemy.Win() },
                { "Z", (enemy) => enemy.Lose() },
            };

            return game.GetPoints(enemy, response);
        }
    }
}

