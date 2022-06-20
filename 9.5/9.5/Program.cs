Console.WriteLine(Calculate(-200));     // 0
Console.WriteLine(Calculate(0));        // 0 
Console.WriteLine(Calculate(10000));    // 500
Console.WriteLine(Calculate(60000));    // 6000
Console.WriteLine(Calculate(200000));   // 40000


decimal Calculate(decimal sum)
{
    return sum switch
    {
        <= 0 => 0,              // если sum меньше или равно 0, возвращаем 0
        < 50000 => sum * 0.05m, // если sum меньше 50000, возвращаем sum * 0.05m
        < 100000 => sum * 0.1m, // если sum меньше 100000, возвращаем sum * 0.1m
        _ => sum * 0.2m        // в остальных случаях возвращаем sum * 0.2m
    };
}

Console.WriteLine(CheckAge(200));     // Недействительный возраст
Console.WriteLine(CheckAge(0));      // Недействительный возраст 
Console.WriteLine(CheckAge(17));    // Доступ запрещен
Console.WriteLine(CheckAge(18));   // Доступ разрешен

string CheckAge(int age)
{
    return age switch
    {
        < 1 or > 110 => "Недействительный возраст",   // если age больше 110 и меньше 1
        >= 1 and < 18 => "Доступ запрещен",           // если age равно или больше 1 и меньше 18
        _ => "Доступ разрешен"                      // в остальных случаях
    };
}


Console.WriteLine(CheckAge2(34));    // Доступ запрещен
Console.WriteLine(CheckAge2(33));   // Доступ разрешен

string CheckAge2(int age) => age switch
{
    not 33 => "Обычный возраст",   // если age НЕ равен 33
    _ => "Вам 33 года"             // в остальных случаях, то есть если age = 33
};

