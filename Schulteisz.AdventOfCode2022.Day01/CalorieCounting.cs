using Schulteisz.AdventOfCode2022.Interfaces;

namespace Schulteisz.AdventOfCode2022.Day01;
public class CalorieCounting : IDailyTask<long>
{
    private IContentParser _contentParser;

    public string Name => "Calorie Counting";

    public CalorieCounting(IContentParser contentParser)
    {
        _contentParser = contentParser;
    }

    public long Run()
    {
        Group elfGroup = new Group(_contentParser.GetLines("Task.txt"));

        return elfGroup.BiggestBackpackSum();
    }
}

