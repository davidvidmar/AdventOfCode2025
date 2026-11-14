namespace Day01;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Advent of Code 2025 - Day 1");
        
        // read and parse input
        var lines = File.ReadAllLines("input.txt");

        // part 1
        
        var dial = 50;
        var result = 0;
        
        // Console.WriteLine(dial + " " + result);
        foreach (var line in lines) {
            
            var num = Convert.ToInt32(line.Substring(1));

            if (line.StartsWith('L'))
            {
                dial -= num;
            } else if (line.StartsWith('R'))
            {
                dial += num;
            }
            
            while (dial < 0) { 
                dial += 100;				
			}
			while (dial > 100)
            {
                dial -= 100;
            }

            if (dial == 0 || dial == 100)
            {
                dial = 0;
                result++;
            }
            // Console.WriteLine(dial + " " + result);
        }
        Console.WriteLine($"Result - part 1: {result}");
        
        // part 2

        dial = 50;
        result = 0;
		var prev = 99;
		
        foreach (var line in lines)
        {
            Console.Write(dial + " + ");
            
            var num = Convert.ToInt32(line.Substring(1));            
            if (line.StartsWith('L'))
            {
                num = -num;
            } else if (line.StartsWith('R'))
            {
				num = +num;
			} else throw new Exception("invalid prefix");

            Console.Write(num);

            //prev = dial;
            //dial += num;
            
            if (num > 0)
            {
                while (num > 0) {
                    dial++;
                    num--;
                    if (dial == 100) { dial = 0; }
					if (dial ==00)
                    {
                        result++;                        
                    }
				}                    
            } else
            if (num < 0)
            {
                while (num < 0)
                {                    
					dial--;
                    num++;
					if (dial == -100) { dial = 0; }
					if (dial == 0)
                    {
                        result++;                        
                    }
				}
            }

			//         while (dial < 0) { 
			//             dial += 100;
			//             if (prev != 0) result++;
			//	//Console.WriteLine("  " + num + " = " + dial + " #" + result);
			//}
			//         while (dial > 100)
			//         {
			//             dial -= 100;
			//             if (prev != 0) result++;
			//	//Console.WriteLine("  " + num + " = " + dial + " #" + result);
			//}
			//         if (dial == 100 || dial == 0)
			//         {
			//             dial = 0;
			//             result++;
			//         }

			Console.WriteLine(" = " + dial + " #" + result);
        }
        Console.WriteLine($"Result - part 2: {result}");
    }
}