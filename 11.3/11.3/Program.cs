//string name = "Tom";
//int age = 23;

//Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);
// консольный вывод
// Имя: Tom  Возраст: 23

//double number = 23.7;
//string result = string.Format("{0:C0}", number);
//Console.WriteLine(result); // 24 р.
//string result2 = string.Format("{0:C2}", number);
//Console.WriteLine(result2); // 23,70 р.

//int number = 23;
//string result = string.Format("{0:d}", number);
//Console.WriteLine(result); // 23
//string result2 = string.Format("{0:d4}", number);
//Console.WriteLine(result2); // 0023

//int number = 23;
//string result = string.Format("{0:f}", number);
//Console.WriteLine(result); // 23,00

//double number2 = 45.08;
//string result2 = string.Format("{0:f4}", number2);
//Console.WriteLine(result2); // 45,0800

//double number3 = 25.07;
//string result3 = string.Format("{0:f1}", number3);
//Console.WriteLine(result3); // 25,1

//decimal number = 0.15345M;
//Console.WriteLine("{0:P1}", number);// 15,3%

//long number = 1987654321000;
//string result = string.Format("{0:+# (###) ###-##-##}", number);
//Console.WriteLine(result); // +1 (987) 654-32-10


//long number = 19876543210;
//Console.WriteLine(number.ToString("+# (###) ###-##-##"));// +1 (987) 654-32-10

//double money = 24.8;
//Console.WriteLine(money.ToString("C2")); // 24,80 р.

/////////////////интерполяция
//int x = 8;
//int y = 7;
//string result = $"{x} + {y} = {x + y}";
//Console.WriteLine(result); // 8 + 7 = 15

//string name = "Tom";
//int age = 23;

//Console.WriteLine($"Имя: {name,-5} Возраст: {age}"); // пробелы после
//Console.WriteLine($"Имя: {name,5} Возраст: {age}"); // пробелы до

