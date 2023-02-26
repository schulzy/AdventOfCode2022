namespace Schulteisz.AdventOfCode2022.Day10
{
    public interface ICalcuator<T>
    {
        void Calculate(int cycleTime, int value);
        T Result { get; }
    }
}