using _9._2;

//Person tom = new Person { Language = "english", Status = "user", Name = "Tom" };
//Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };

//SayHello(tom);      // Hello
//SayHello(pierre);   // Salut

//void SayHello(Person person)
//{
//    if (person is Person { Language: "french" })
//    {
//        Console.WriteLine("Salut");
//    }
//    else
//    {
//        Console.WriteLine("Hello");
//    }
//}

//Person tom = new Person { Language = "english", Status = "user", Name = "Tom" };
//Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
//Person admin = new Person { Language = "english", Status = "admin", Name = "Admin" };

//SayHello(admin);    // Hello, admin
//SayHello(tom);      // Hello
//SayHello(pierre);   // Salut

//void SayHello(Person person)
//{
//    if (person is Person { Language: "english", Status: "admin" })
//    {
//        Console.WriteLine("Hello, admin");
//    }
//    else if (person is Person { Language: "french" })
//    {
//        Console.WriteLine("Salut");
//    }
//    else
//    {
//        Console.WriteLine("Hello");
//    }
//}

////Person pierre = new Person { Language = "french", Status = "user", Name = "Pierre" };
////string message = GetMessage(pierre);
////Console.WriteLine(message);     // Salut!

////Person tomas = new Person { Language = "german", Status = "admin", Name = "Tomas" };
////Console.WriteLine(GetMessage(tomas));     // Hallo, admin!

////Person pablo = new Person { Language = "spanish", Status = "user", Name = "Pablo" };
////Console.WriteLine(GetMessage(pablo));     // undefined

////Console.WriteLine(GetMessage(null));     // null

////string GetMessage(Person? p) => p switch
////{
////    { Language: "english" } => "Hello!",
////    { Language: "german", Status: "admin" } => "Hallo, admin!",
////    { Language: "french" } => "Salut!",
////    { } => "undefined",
////    null => "null"       // если Person p = null
////};
///
var microsoft = new Company("Microsoft");
var google = new Company("Google");
var tom = new Employee("Tom", microsoft);
var bob = new Employee("Bob", google);

PrintCompany(tom);    // 
PrintCompany(bob);    // 

void PrintCompany(Employee employee)
{
    if (employee is Employee { Company.Title: "Microsoft" })
    {
        Console.WriteLine($"{employee.Name} works in Microsoft");
    }
    else
    {
        Console.WriteLine($"{employee.Name} works someware");
    }
}