// ДЗ 3.3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Инициализация программы");
Console.WriteLine("Введите число");
if(int.TryParse(Console.ReadLine(), out int a))
{


    int b = 1;
    Console.WriteLine($"Выведение таблицы кубов от {b} до {a}");

    while(b <= a)
    {
        System.Console.WriteLine(Math.Pow(b, 3));
        b++;
    }
}
else
{
    Console.WriteLine("Введено не число");
}
Console.WriteLine("Программа завершила работу");
