using _9._4;

MessageDetails details1 = new MessageDetails { Language = "english", DateTime = "evening", Status = "user" };
string message = GetWelcome(details1);
Console.WriteLine(message);  // Good evening
Console.WriteLine(details1.Language);

MessageDetails details2 = new MessageDetails { Language = "french", DateTime = "morning", Status = "admin" };
message = GetWelcome(details2);
Console.WriteLine(message);  // Hello, Admin

string GetWelcome(MessageDetails details) => details switch
{
    ("english", "morning", _) => "Good morning",
    ("english", "evening", _) => "Good evening",
    ("german", "morning", _) => "Guten Morgen",
    ("german", "evening", _) => "Guten Abend",
    (_, _, "admin") => "Hello, Admin",
    (var lang, var datetime, var status) => $"{lang} not found, {datetime} unknown, {status} undefined",
    _ => "Здрасьть"
};

MessageDetails details3 = new MessageDetails
{
    Language = "chinese",
    DateTime = "night",
    Status = "moderator"
};
string message1 = GetWelcome(details3);
Console.WriteLine(message1);  // chinese not found, night unknown, moderator undefined

Console.ReadKey();