    namespace Schulteisz.AdventOfCode2022.Day10
{
    public class ComplexCalculator : ICalcuator<List<string>>
    {
        private char[] _crtOutput = new char[240];
        public ComplexCalculator()
        {
            for (int i = 0; i < 240; i++)
                _crtOutput[i] = '.';
        }

        public List<string> Result
        {
            get
            {
                List<string> result = new List<string>();
                string output = new string(_crtOutput);

                for (int i = 0; i < 6; i++)
                {
                    int startPoint = i * 40;
                    result.Add(output.Substring(startPoint, 40));
                }

                return result;
            }
        }

        public void Calculate(int cycleTime, int value)
        {
            cycleTime -= 1;
            int linePosition = cycleTime % 40;
            if (linePosition >= value - 1 && linePosition <= value + 1)
                _crtOutput[cycleTime] = '#';

        }
    }
}