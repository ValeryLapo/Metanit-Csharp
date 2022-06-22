DateOnly now = new DateOnly(2022, 1, 6);
Console.WriteLine(now.Day);         // 6
Console.WriteLine(now.DayNumber);   // 738160
Console.WriteLine(now.DayOfWeek);   // Thursday
Console.WriteLine(now.DayOfYear);   // 6
Console.WriteLine(now.Month);       // 1
Console.WriteLine(now.Year);        // 2022

TimeOnly time = TimeOnly.Parse("06:33:22");
Console.WriteLine(time);        // 6:33
time = time.AddHours(1);        // 7:33
time = time.AddMinutes(-23);   // 7:10

Console.WriteLine(time.ToShortTimeString());  // 7:10
Console.WriteLine(time.ToLongTimeString());   // 7:10:22