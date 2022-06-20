using _8._3;

var microsoft = new Company(new[]
{
    new Person("Tom"), new Person("Bob"), new Person("Sam"), new Person("Alice")
});
// получаем объект из индексатора
Person firstPerson = microsoft[0];
Console.WriteLine(firstPerson.Name);  // Tom
// переустанавливаем объект
microsoft[0] = new Person("Mike");
Console.WriteLine(microsoft[0].Name);  // Mike