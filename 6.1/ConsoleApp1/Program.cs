
Message mes1 = Hello;
Message mes2 = HowAreYou;
Message mes3 = mes1 + mes2; // объединяем делегаты
mes3(); // вызываются все методы из mes1 и mes2


void Hello() => Console.WriteLine("hello");
void HowAreYou() => Console.WriteLine("HowAreYou");

delegate void Message();