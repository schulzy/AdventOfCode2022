using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day05
{
    internal class CraneParser
    {
        internal static void Create(IList<string> content, ICraneSystem crane, ICraneFactory craneFactory)
        {
            foreach (var item in content)
            {
                if (string.IsNullOrWhiteSpace(item))
                    break;

                ReadData(item, crane, craneFactory);
            }
        }

        private static void ReadData(string item, ICraneSystem craneSystem, ICraneFactory craneFactory)
        {
            int craneNumber = 0;
            for (int i = 0; i < item.Length; i+=4)
            {
                if (craneSystem.Length == craneNumber)
                    craneSystem.AddCrane(craneFactory.CreateCrane(i));
                string subset= item.Substring(i, 3);
                if(subset.Contains('[') && subset.Contains(']'))
                {
                    craneSystem[craneNumber].AddContainer(subset.Replace("[", "").Replace("]", "").Trim());
                }
                craneNumber++;
            }
        }
    }
}