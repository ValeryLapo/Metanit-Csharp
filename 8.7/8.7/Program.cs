﻿var user = new { Name = "Tom", Age = 34 };
var student = new { Name = "Alice", Age = 21 };
var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };

Console.WriteLine(user.GetType().Name); // <>f__AnonymousType0'2
Console.WriteLine(student.GetType().Name); // <>f__AnonymousType0'2
Console.WriteLine(manager.GetType().Name); // <>f__AnonymousType1'3