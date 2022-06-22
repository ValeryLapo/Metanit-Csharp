//string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
//string selected1 = people[2];    // Sam
//string selected2 = people[^2];    // Kate
//Console.WriteLine(selected1);
//Console.WriteLine(selected2);

//string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
//string[] peopleRange = people[1..4]; // получаем 2, 3 и 4-й элементы из массива
//foreach (var person in peopleRange)
//{
//    Console.WriteLine(person);
//}

string[] people = { "Tom", "Bob", "Sam", "Kate", "Alice" };
Span<string> peopleSpan = people;
Span<string> selectedPeopleSpan = peopleSpan[1..4];
foreach (var person in selectedPeopleSpan)
{
    Console.WriteLine(person);
}