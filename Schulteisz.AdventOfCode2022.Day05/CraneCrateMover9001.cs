namespace Schulteisz.AdventOfCode2022.Day05
{
	internal class CraneCrateMover9001 : Crane
	{
        public CraneCrateMover9001(int index) : base(index)
        {
        }

        public override IEnumerable<string> Take(int number)
        {
            Stack<string> result = new Stack<string>();
            for (int i = 0; i < number; i++)
                result.Push(_containers.Pop());

            return result;
        }
    }
}

