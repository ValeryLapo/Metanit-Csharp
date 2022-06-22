string s1 = "hello";
string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

Console.WriteLine(s1);  // hello
Console.WriteLine(s2);  // aaaaaaa
Console.WriteLine(s3);  // world
Console.WriteLine(s4);  // orl

string message = "hello";
// получаем символ
char firstChar = message[1]; // символ 'e'
Console.WriteLine(firstChar);   //e

Console.WriteLine(message.Length);  // длина строки  

for (var i = 0; i < message.Length; i++)
{
    Console.WriteLine(message[i]);
}
foreach (var ch in message)
{
    Console.WriteLine(ch);
}