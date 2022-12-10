using System;
namespace Schulteisz.AdventOfCode2022.Day05
{
	internal interface ICraneFactory
	{
		ICrane CreateCrane(int index);
	}
}

