﻿//var tuple = (5, 10, 15, 22);
//Console.WriteLine(tuple.Item3); // 5
//Console.WriteLine(tuple.Item2); // 10
//tuple.Item1 += 26;
//Console.WriteLine(tuple.Item1); // 31

//var (name, age) = ("Tom", 23);
//Console.WriteLine(name);    // Tom
//Console.WriteLine(age);     // 23

//string main = "Java";
//string second = "C#";
//(main, second) = (second, main);
//Console.WriteLine(main);    // C#
//Console.WriteLine(second);  // Java

//int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

//// сортировка
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//            (nums[i], nums[j]) = (nums[j], nums[i]);
//    }
//}

//// вывод
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);

//}

//var tuple = GetValuesData(new int[] { 1, 2, 3, 4, 5, 6, 7 });
//Console.WriteLine(tuple.count);
//Console.WriteLine(tuple.sum);

//(int sum, int count) GetValuesData(int[] numbers)
//{
//    var result = (sum: 0, count: numbers.Length);
//    foreach (var n in numbers)
//    {
//        result.sum += n;
//    }
//    return result;
//}

PrintPerson(("Tom", 37));   // Tom - 37
PrintPerson(("Bob", 41));   // Bob - 41


void PrintPerson((string name, int age) person)
{
    Console.WriteLine($"{person.name} - {person.age}");
}