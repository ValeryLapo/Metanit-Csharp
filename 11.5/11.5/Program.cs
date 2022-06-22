using System.Text.RegularExpressions;

//string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
//Regex regex = new Regex(@"туп(\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
//MatchCollection matches = regex.Matches(s);
//if (matches.Count > 0)
//{
//    foreach (Match match in matches)
//        Console.WriteLine(match.Value);
//}
//else
//{
//    Console.WriteLine("Совпадений не найдено");
//}

//string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
//                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
//var data = new string[]
//{
//    "tom@gmail.com",
//    "+12345678999",
//    "bob@yahoo.com",
//    "+13435465566",
//    "sam@yandex.ru",
//    "+43743989393"
//};

//Console.WriteLine("Email List");
//for (int i = 0; i < data.Length; i++)
//{
//    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
//    {
//        Console.WriteLine(data[i]);
//    }
//}

//string text = "Мама  мыла  раму. ";
//string pattern = @"\s+";
//string target = " ";
//Regex regex = new Regex(pattern);
//string result = regex.Replace(text, target);
//Console.WriteLine(result);

string phoneNumber = "+1(876)-234-12-98";
string pattern = @"\D";
string target = "";
Regex regex = new Regex(pattern);
string result = regex.Replace(phoneNumber, target);
Console.WriteLine(result);  // 18762341298