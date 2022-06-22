using System.Text;

//StringBuilder sb = new StringBuilder("Привет мир");
//Console.WriteLine($"Длина: {sb.Length}");       // Длина: 10
//Console.WriteLine($"Емкость: {sb.Capacity}");   // Емкость: 16

var sb = new StringBuilder("Название: ");
Console.WriteLine(sb);   // Название: 
Console.WriteLine($"Длина: {sb.Length}"); // 10
Console.WriteLine($"Емкость: {sb.Capacity}"); // 16

sb.Append(" Руководство");
Console.WriteLine(sb);   // Название: Руководство
Console.WriteLine($"Длина: {sb.Length}"); // 22
Console.WriteLine($"Емкость: {sb.Capacity}"); // 32

sb.Append(" по C#");
Console.WriteLine(sb);   // Название: Руководство по C#
Console.WriteLine($"Длина: {sb.Length}"); // 28
Console.WriteLine($"Емкость: {sb.Capacity}"); // 32