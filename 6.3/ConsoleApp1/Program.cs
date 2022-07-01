//MessageHandler handler = delegate (string mes)
//{
//    Console.WriteLine(mes);
//};


//handler("hello world!");


ShowMessage("hello!", delegate (string mes)
{
    Console.WriteLine(mes);
});

static void ShowMessage(string message, MessageHandler handler)
{
    handler(message);
}


delegate void MessageHandler(string message);