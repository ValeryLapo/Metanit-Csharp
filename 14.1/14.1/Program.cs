using System.Threading;

//// получаем текущий поток
//Thread currentThread = Thread.CurrentThread;

////получаем имя потока
//Console.WriteLine($"Имя потока: {currentThread.Name}");
//currentThread.Name = "Метод Main";
//Console.WriteLine($"Имя потока: {currentThread.Name}");

//Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
//Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
//Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
//Console.WriteLine($"Статус потока: {currentThread.ThreadState}");

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(500);      // задержка выполнения на 500 миллисекунд
    Console.WriteLine(i);
}