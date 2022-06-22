//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//// находим индекс элемента "Bob"
//int bobIndex = Array.BinarySearch(people, "Bob");
//// находим индекс первого элемента "Tom"
//int tomFirstIndex = Array.IndexOf(people, "Tom");
//// находим индекс последнего элемента "Tom"
//int tomLastIndex = Array.LastIndexOf(people, "Tom");
//// находим индекс первого элемента, у которого длина строки больше 3
//int lengthFirstIndex = Array.FindIndex(people, person => person.Length > 3);
//// находим индекс последнего элемента, у которого длина строки больше 3
//int lengthLastIndex = Array.FindLastIndex(people, person => person.Length > 3);

//Console.WriteLine($"bobIndex: {bobIndex}");                 // 2
//Console.WriteLine($"tomFirstIndex: {tomFirstIndex}");       // 0
//Console.WriteLine($"tomLastIndex: {tomLastIndex}");         // 4
//Console.WriteLine($"lengthFirstIndex: {lengthFirstIndex}"); // 3
//Console.WriteLine($"lengthLastIndex: {lengthLastIndex}");   // 5


//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//// находим первый и последний элементы
//// где длина строки больше 3 символов
//string? first = Array.Find(people, person => person.Length > 3);
//Console.WriteLine(first); // Kate
//string? last = Array.FindLast(people, person => person.Length > 3);
//Console.WriteLine(last); // Alice

//// находим элементы, у которых длина строки равна 3
//string[]? group = Array.FindAll(people, person => person.Length == 3);
//foreach (var person in group) Console.WriteLine(person);
//// Tom Sam Bob Tom

//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//Array.Reverse(people);

//foreach (var person in people)
//    Console.Write($"{person} ");
//// "Alice", "Tom", "Kate", "Bob", "Sam", "Tom"

//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//// изменяем порядок 3 элементов начиная c индекса 1  
//Array.Reverse(people, 1, 3);

//foreach (var person in people)
//    Console.Write($"{person} ");
//// "Tom", "Kate", "Bob", "Sam", "Tom", "Alice"


//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//// уменьшим массив до 4 элементов
//Array.Resize(ref people, 10);
//Console.WriteLine(people.Length);
//foreach (string? person in people)
//    Console.Write($"{person} ");
//// "Tom", "Sam", "Bob", "Kate"
///

//var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

//var employees = new string[3];

//// копируем 3 элемента из массива people c индекса 1  
//// и вставляем их в массив employees начиная с индекса 0
//Array.Copy(people, 1, employees, 0, 3);

//foreach (var person in employees)
//    Console.Write($"{person} ");
//// Sam Bob Kate

var people = new string[] { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

Array.Sort(people);

foreach (var person in people)
    Console.Write($"{person} ");

// Alice Bob Kate Sam Tom Tom