DateTime now = DateTime.Now;

Console.WriteLine($"D: {now.ToString("D")}");
Console.WriteLine($"d: {now.ToString("d")}");
Console.WriteLine($"F: {now.ToString("F")}");
Console.WriteLine($"f: {now:f}");
Console.WriteLine($"G: {now:G}");
Console.WriteLine($"g: {now:g}");
Console.WriteLine($"M: {now:M}");
Console.WriteLine($"O: {now:O}");
Console.WriteLine($"o: {now:o}");
Console.WriteLine($"R: {now:R}");
Console.WriteLine($"s: {now:s}");
Console.WriteLine($"T: {now:T}");
Console.WriteLine($"t: {now:t}");
Console.WriteLine($"U: {now:U}");
Console.WriteLine($"u: {now:u}");
Console.WriteLine($"Y: {now:Y}");

DateTime noww = DateTime.Now;
Console.WriteLine(noww.ToString("hh:mm:ss"));
Console.WriteLine(noww.ToString("dd.MM.yyyy"));