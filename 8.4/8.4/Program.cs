int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
numberRef = 9; // заменяем 4 на 9
Console.WriteLine(numbers[3]); // 9

ref int Find(int number, int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
        {
            return ref numbers[i]; // возвращаем ссылку на адрес, а не само значение
        }
    }
    throw new IndexOutOfRangeException("число не найдено");
}