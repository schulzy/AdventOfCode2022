namespace Schulteisz.AdventOfCode2022.Day02
{
	internal interface IGameActor
	{
		int Fight(IGameActor enemy);

		IGameActor Draw();
		IGameActor Win();
		IGameActor Lose();
	}
}

