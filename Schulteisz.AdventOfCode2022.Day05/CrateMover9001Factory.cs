namespace Schulteisz.AdventOfCode2022.Day05
{
    public class CrateMover9001Factory : ICraneFactory
    {
        ICrane ICraneFactory.CreateCrane(int index)
        {
            return new CraneCrateMover9001(index);
        }
    }
}

