namespace Schulteisz.AdventOfCode2022.Day02
{
	internal class Paper : IGameActor
	{
        public IGameActor Draw()
        {
            return new Paper();
        }

        public int Fight(IGameActor enemy)
        {
            int handicap = 2;
            switch (enemy)
            {
                case Rock:
                    return 6 + handicap;
                case Paper:
                    return 3 + handicap;
                case Scissors:
                    return 0 + handicap;
                default:
                    throw new ArgumentOutOfRangeException($"Argument does not exist: {nameof(enemy)}");
            }
        }

        public IGameActor Lose()
        {
            return new Scissors();
        }

        public IGameActor Win()
        {
            return new Rock();
        }
    }
}

