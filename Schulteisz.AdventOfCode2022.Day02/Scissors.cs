namespace Schulteisz.AdventOfCode2022.Day02
{
	internal class Scissors : IGameActor
	{
        public IGameActor Draw()
        {
            return new Scissors();
        }

        public int Fight(IGameActor enemy)
        {
            int handicap = 3;
            switch (enemy)
            {
                case Rock:
                    return 0 + handicap;
                case Paper:
                    return 6 + handicap;
                case Scissors:
                    return 3 + handicap;
                default:
                    throw new ArgumentOutOfRangeException($"Argument does not exist: {nameof(enemy)}");
            }
        }

        public IGameActor Lose()
        {
            return new Rock();
        }

        public IGameActor Win()
        {
            return new Paper();
        }
    }
}

