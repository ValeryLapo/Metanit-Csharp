using _8._2;

Counter counter1 = new Counter { Seconds = 23 };

int x = (int)counter1;
Console.WriteLine(x);   // 23

Counter counter2 = x;
Console.WriteLine(counter2.Seconds);  // 23


Counter counter3 = new Counter { Seconds = 115 };

_8._2.Timer timer = counter3;
Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}");

Counter counter4 = (Counter)timer;
Console.WriteLine(counter4.Seconds);

