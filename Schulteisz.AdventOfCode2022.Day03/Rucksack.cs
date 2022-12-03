namespace Schulteisz.AdventOfCode2022.Day03
{
	internal class Rucksack
	{
        private List<char> _firstCompartment = new List<char>();
        private List<char> _secondCompartment = new List<char>();
        public List<char> FullRucksack { get; }

        public Rucksack(string code)
		{
			CreateCompartments(code);
            FullRucksack = code.ToList();
        }

        public long CommonItemValue()
        {
            long sum = 0;
            foreach (var item in FindCommonItems())
            {
                sum += CharValueCalculator.Calculate(item);
            }

            return sum;
        }

        private IEnumerable<char> FindCommonItems()
        {
            return _firstCompartment.Intersect(_secondCompartment);
        }

        private void CreateCompartments(string code)
        {
            int length = code.Count();
            _firstCompartment.AddRange(code.Take(length / 2));
            _secondCompartment.AddRange(code.TakeLast(length / 2));
        }
    }
}