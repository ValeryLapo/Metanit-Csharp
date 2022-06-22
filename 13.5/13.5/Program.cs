//string[] people = new string[] { "Tom", "Alice", "Bob" };
//Span<string> peopleSpan = people;
//peopleSpan[1] = "Ann";              // переустановка значения элемента
//Console.WriteLine(peopleSpan[2]);   // получение элемента
//Console.WriteLine(peopleSpan.Length);   // получение длины Span

//// перебор Span
//foreach (var s in peopleSpan)
//{
//    Console.WriteLine(s);
//}

string text = "hello, world";
string worldString = text.Substring(startIndex: 7, length: 5);           // есть выделение памяти под символы
ReadOnlySpan<char> worldSpan = text.AsSpan().Slice(start: 7, length: 5); // нет выделения памяти под символы
//worldSpan[0] = 'a'; // Нельзя изменить
Console.WriteLine(worldSpan[0]); // выводим первый символ

// перебор символов
foreach (var c in worldSpan)
{
    Console.Write(c);
}