namespace Schulteisz.AdventOfCode2022.Day10
{
    public class SimpleCalculator : ICalcuator<int>
    {
        private int _sumSpecalCycle = 0;

        public int Result => _sumSpecalCycle;

        public void Calculate(int cycleTime, int value)
        {
            if ((cycleTime - 20) % 40 == 0)
                _sumSpecalCycle += cycleTime * value;
        }
    }
}