namespace Schulteisz.AdventOfCode2022.Day05
{
	public class CrateMover9000Factory : ICraneFactory	
	{
        ICrane ICraneFactory.CreateCrane(int index)
        {
            return new Crane(index);
        }
    }
}

