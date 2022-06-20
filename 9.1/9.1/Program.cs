using _9._1;

//Empoyee tom = new Manager();
//UseEmployee(tom);

//void UseEmployee(Empoyee emp)
//{
//    if (emp is Manager manager && manager.IsOnVacation == false)
//    {
//        manager.Work();
//    }
//    else
//    {
//        Console.WriteLine("Преобразование не допустимо");
//    }
//}


//Empoyee bob = new Empoyee();
//Empoyee tom = new Manager();
//UseEmployee(tom);   // Manager works
//UseEmployee(bob);   // Object is not manager

//void UseEmployee(Empoyee? emp)
//{
//    switch (emp)
//    {
//        case Manager manager:
//            manager.Work();
//            break;
//        case null:
//            Console.WriteLine("Object is null");
//            break;
//        default:
//            Console.WriteLine("Object is not manager");
//            break;
//    }
//}


Empoyee bob = new Manager() { IsOnVacation = true };
Empoyee tom = new Manager() { IsOnVacation = false };
UseEmployee(tom);   // Manager works
UseEmployee(bob);   // Employee does not work

void UseEmployee(Empoyee? emp)
{
    switch (emp)
    {
        case Manager manager when !manager.IsOnVacation:
            manager.Work();
            break;
        case null:
            Console.WriteLine("Employee is null");
            break;
        default:
            Console.WriteLine("Employee does not work");
            break;
    }
}