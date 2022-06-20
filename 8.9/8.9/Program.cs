//var person1 = new Person("Tom");
//var person2 = new Person("Tom");
//Console.WriteLine(person1.Equals(person2)); // true

//var user1 = new User("Tom");
//var user2 = new User("Tom");
//Console.WriteLine(user1.Equals(user2));     // false

//var person1 = new Person("Tom");
//var person2 = new Person("Tom");
//Console.WriteLine(person1 == person2); // true

//var user1 = new User("Tom");
//var user2 = new User("Tom");
//Console.WriteLine(user1 == user2);     // false


//var tom = new Person("Tom", 37);
//var sam = tom with { Name = "Sam" };
//Console.WriteLine($"{sam.Name} - {sam.Age}"); // Sam - 37

var person = new Person("Tom", 37);
Console.WriteLine(person.Name); // Tom


Console.WriteLine(person); // Уже отформатированный вид
