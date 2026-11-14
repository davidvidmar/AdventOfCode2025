using System.Transactions;

namespace Day02;

class Program
{
    static void Main()
    {
        Console.WriteLine("Advent of Code 2025 - Day 2");
        
        // read and parse input
        var lines = File.ReadAllText("input.txt").Split(",");
        
        // part 1
        Console.WriteLine("Part 1");

		Int64 result = 0;
        foreach (var line in lines)
        {
            Console.WriteLine(line);
            var bor = line.Split('-');
            for (Int64 i = Convert.ToInt64(bor[0]); i <= Convert.ToInt64(bor[1]); i++)
            {
                var s = i.ToString();
                if (s.Length % 2 != 0) continue;
                var l = s.Length / 2;
                if (s[..l] == s[l..])
                {
                    result += i;    
                    Console.WriteLine(" Found: " + s);
				}
			}
        }
        Console.WriteLine($"Result: {result}");
        
        // part 2
        Console.WriteLine("Part 2");

		result = 0;
		foreach (var line in lines)
		{
			Console.WriteLine(line);
			var bor = line.Split('-');
			for (Int64 i = Convert.ToInt64(bor[0]); i <= Convert.ToInt64(bor[1]); i++)
			{
				var s = i.ToString();
                foreach (var d in new[]{ 2, 3, 5, 7, 11 })
                {
					if (s.Length % d == 0)
					{
						var l = s.Length / d;
                        var found = true;
                        for (int j = 1; j < d; j++)
                        {							
                            found &= s[..l] == s.Substring(j * l, l);
						    if (!found) break;
					    }
                        if (found)
                        {
				            result += i;
				            Console.WriteLine(" Found: " + s);
							break;
			            }
					}
				}                
			}
		}
		Console.WriteLine($"Result: {result}");		
    }
}