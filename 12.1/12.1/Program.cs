DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
Console.WriteLine(date1.Subtract(date2)); // 03:00:0015 18:30:25

DateTime date3 = new DateTime(2015, 7, 20, 18, 30, 25);
Console.WriteLine(date3.ToLocalTime()); // 20.07.2015 21:30:25
Console.WriteLine(date3.ToUniversalTime()); // 20.07.2015 15:30:25
Console.WriteLine(date3.ToLongDateString()); // 20 июля 2015 г.
Console.WriteLine(date3.ToShortDateString()); // 20.07.2015
Console.WriteLine(date3.ToLongTimeString()); // 18:30:25
Console.WriteLine(date3.ToShortTimeString()); // 18:30