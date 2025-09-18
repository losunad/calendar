using System;

class Program
{
    static void Main()
    {
        int startDayOfWeek;
        do
        {
            Console.Write("Введите номер дня недели начала месяца (1-понедельник, 7-воскресенье): ");
        } 
        while (!int.TryParse(Console.ReadLine(), out startDayOfWeek) || startDayOfWeek < 1 || startDayOfWeek > 7);
        
        int dayOfMonth;
        do
        {
            Console.Write("Введите номер дня месяца мая (1-31): ");
        } 
        while (!int.TryParse(Console.ReadLine(), out dayOfMonth) || dayOfMonth < 1 || dayOfMonth > 31);

        // Определение дня недели для заданного дня
        int dayOfWeek = (startDayOfWeek + dayOfMonth - 2) % 7 + 1;

        // Проверка типа дня (выходной/рабочий)
        bool isWeekend = false;

        // Проверка выходных дней (суббота и воскресенье)
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            isWeekend = true;
        }

        // Проверка праздничных дней (1-5 и 8-10 мая)
        if ((dayOfMonth >= 1 && dayOfMonth <= 5) || (dayOfMonth >= 8 && dayOfMonth <= 10))
        {
            isWeekend = true;
        }

        // Вывод результата
        Console.WriteLine(isWeekend ? "Выходной день" : "Рабочий день");
    }
}