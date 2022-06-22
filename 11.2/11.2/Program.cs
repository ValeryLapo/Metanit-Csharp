// Операции со строками

//////ОБЪЕДИНЕНИЕ СТРОК
//string s1 = "hello";
//string s2 = "world";
//string s3 = s1 + " " + s2; // результат: строка "hello world"
//string s4 = string.Concat(s3, "!!!"); // результат: строка "hello world!!!"

//Console.WriteLine(s4);

//string s5 = "apple";
//string s6 = "a day";
//string s7 = "keeps";
//string s8 = "a doctor";
//string s9 = "away";
//string[] values = new string[] { s5, s6, s7, s8, s9 };

//string s10 = string.Join(" ", values);
//Console.WriteLine(s10); // apple a day keeps a doctor away

//////СРАВНЕНИЕ СТРОК
//string s1 = "hello";
//string s2 = "world";

//int result = string.Compare(s1, s2);
//if (result < 0)
//{
//    Console.WriteLine("Строка s1 перед строкой s2");
//}
//else if (result > 0)
//{
//    Console.WriteLine("Строка s1 стоит после строки s2");
//}
//else
//{
//    Console.WriteLine("Строки s1 и s2 идентичны");
//}
//// результатом будет "Строка s1 перед строкой s2"

//////ПОИСК В СТРОКЕ
//string s1 = "hello world";
//char ch = 'o';
//int indexOfChar = s1.IndexOf(ch); // равно 4
//Console.WriteLine(indexOfChar);

//string substring = "wor";
//int indexOfSubstring = s1.IndexOf(substring); // равно 6
//Console.WriteLine(indexOfSubstring);

//var files = new string[]
//{
//    "myapp.exe",
//    "forest.jpg",
//    "main.exe",
//    "book.pdf",
//    "river.png"
//};

//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].EndsWith(".exe"))
//        Console.WriteLine(files[i]);
//}

////РАЗДЕЛЕНИЕ СТРОК
//string text = "И поэтому   все  так произошло";

//string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}

////ОБРЕЗКА СТРОК
//string text = "Хороший день";
//// обрезаем начиная с третьего символа
//text = text.Substring(2);
//// результат "роший день"
//Console.WriteLine(text);
//// обрезаем сначала до последних двух символов
//text = text.Substring(0, text.Length - 2);
//// результат "роший де"
//Console.WriteLine(text);

