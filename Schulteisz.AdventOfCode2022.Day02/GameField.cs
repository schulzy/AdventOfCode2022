namespace Schulteisz.AdventOfCode2022.Day02
{
	internal class GameField
	{
		private readonly List<string> _stategyGuide;

        public GameField(List<string> list)
		{
			_stategyGuide = list;
        }

		public long GetPoints(Dictionary<string,IGameActor> enemyMap, Dictionary<string, Func<IGameActor, IGameActor>> responseMap)
		{
			List<(IGameActor enemy, IGameActor response)> games = new List<(IGameActor, IGameActor)>();
			foreach (var item in _stategyGuide)
			{
				string[] line = item.Split(" ");
				IGameActor enemy = enemyMap[line[0]];
				IGameActor response = responseMap[line[1]](enemy);

                games.Add((enemy,response));
            }

			return games.Sum(game => game.response.Fight(game.enemy));
		}
	}
}

