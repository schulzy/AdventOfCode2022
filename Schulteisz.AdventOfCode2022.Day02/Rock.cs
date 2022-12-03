namespace Schulteisz.AdventOfCode2022.Day02
{
	internal class Rock : IGameActor
	{
        public IGameActor Draw()
        {
            return new Rock();
        }

        public int Fight(IGameActor enemy)
        {
            int handicap = 1;
            switch (enemy)
            {
                case Rock:
                    return 3 + handicap;
                case Paper:
                    return 0 + handicap;
                case Scissors:
                    return 6 + handicap;
                default:
                    throw new ArgumentOutOfRangeException($"Argument does not exist: {nameof(enemy)}");
            }
        }

        public IGameActor Lose()
        {
            return new Paper();
        }

        public IGameActor Win()
        {
            return new Scissors();
        }
    }
}

