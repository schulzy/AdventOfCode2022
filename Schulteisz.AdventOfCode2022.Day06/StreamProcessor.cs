using System.Linq;

namespace Schulteisz.AdventOfCode2022.Day06
{
	public class StreamProcessor
	{
        private readonly string _stream;

        public StreamProcessor(string stream)
		{
			_stream = stream;
		}

		public int FindFirstPosition(int position)
		{
			Queue<char> data = new Queue<char>();
			_stream.Take(position).ToList().ForEach(item => data.Enqueue(item));

			for (int i = position; i < _stream.Length; i++)
			{
				if (data.Distinct().Count() == position)
					return i;

				data.Dequeue();
				data.Enqueue(_stream[i]);
            }

			throw new ArgumentOutOfRangeException("Result has not been found");
		}
	}
}

