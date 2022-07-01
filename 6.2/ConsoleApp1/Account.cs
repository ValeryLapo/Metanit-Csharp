public class Account
{

    AccountHandler? taken;
    int sum; // Переменная для хранения суммы
    // через конструктор устанавливается начальная сумма на счете
    public void RegisterHandler(AccountHandler del)
    {
        taken += del;
    }
    public void UnregisterHandler(AccountHandler del)
    {
        taken -= del;
    }
    public Account(int sum) => this.sum = sum;
    // добавить средства на счет
    public void Add(int sum) => this.sum += sum;
    // взять деньги с счета
    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            // вызываем делегат, передавая ему сообщение
            taken?.Invoke($"Со счета списано {sum} у.е.");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
}

public delegate void AccountHandler(string message);