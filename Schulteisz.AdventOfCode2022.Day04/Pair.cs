namespace Schulteisz.AdventOfCode2022.Day04
{
    internal class Pair
    {
        private List<int> _firstElf = new List<int>();
        private List<int> _secondElf = new List<int>();

        public Pair(string rawText)
        {
            string[] rawPairs = rawText.Split(",");
            CreateElementList(rawPairs[0], _firstElf);
            CreateElementList(rawPairs[1], _secondElf);
        }

        /// <summary>
        /// Check the two elves, if one of the elf's job is fully overlapped
        /// </summary>
        /// <returns>true if there is overlaping section, otherwise false</returns>
        public bool OverlapSections()
        {
            int intersectCount = _firstElf.Intersect(_secondElf).Count();
            if (intersectCount == _firstElf.Count || intersectCount == _secondElf.Count)
            {
                return true;
            }

            return false;
        }

        public bool OverlapSimple()
        {
            return _firstElf.Intersect(_secondElf).Count() > 0 ? true : false;
        }

        private void CreateElementList(string rawData, List<int> elfList)
        {
            string[] range = rawData.Split("-");
            int first = int.Parse(range[0]);
            int second = int.Parse(range[1]);
            elfList.AddRange(Enumerable.Range(first, second - first + 1));
        }
    }
}