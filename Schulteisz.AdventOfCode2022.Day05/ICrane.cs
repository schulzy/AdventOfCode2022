namespace Schulteisz.AdventOfCode2022.Day05
{
    internal interface ICrane
    {
        void AddContainer(string container);
        void Init();
        void Push(IEnumerable<string> values);
        IEnumerable<string> Take(int number);
    }
}