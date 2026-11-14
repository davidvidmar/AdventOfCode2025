namespace Day3;

class Program
{
	static void Main()
	{
		Console.WriteLine("Advent of Code 2025 - Day 3");

		// read and parse input

		var lines = File.ReadAllLines("input.txt");

		// part 1
		Console.WriteLine("Part 1");

		Int64 result = 0;
		foreach (var line in lines)
		{
			var max1 = 0;
			var max1i = -1;
			var max2 = 0;
			var max2i = -1;

			var ine = line.Select(c => c - '0').ToArray(); 
			Console.Write($"{line}");
			for (int i = 0; i < ine.Length - 1; i++)
			{
				if (max1 < ine[i])
				{
					max1 = ine[i];
					max1i = i;
				}
			}
			for (int i = max1i + 1; i < ine.Length; i++)
			{
				if (max2 < ine[i])
				{
					max2 = ine[i];
					max2i = i;
				}
			}
			Console.WriteLine($" -> {max1}{max2}");
			result += max1 * 10 + max2;
		}
		Console.WriteLine($"Result: {result}");

		// part 2
		Console.WriteLine("Part 2");
		result = 0;

		foreach (var line in lines)
		{
			const int maxDigits = 12;

			var max = new int[maxDigits];
			var maxj = new int[maxDigits];

			Console.Write($"{line}");

			for (int j = 0; j < maxDigits; j++)
			{
				var ine = line.Select(c => c - '0').ToArray();				
				for (int i = ((j >= 1) ? (maxj[j-1] + 1) : 0); i < ine.Length - (maxDigits - j - 1); i++)
				{
					if (max[j] < ine[i])
					{
						max[j] = ine[i];
						maxj[j] = i;
					}
				}							
			}
			Console.WriteLine($" -> " + string.Join("", max));
			result += Int64.Parse(string.Join("", max));
		}
		
		Console.WriteLine($"Result: {result}");
	}
}