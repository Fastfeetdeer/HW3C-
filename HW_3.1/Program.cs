// ДЗ 3.1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Инициализация программы");
Console.Write("Введите число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
    int numberLengh=(int)Math.Log10(Math.Abs(number)) + 1;
    if (numberLengh != 5 ) Console.WriteLine("Число не пятизначное");
    int revNumber=0;
    int doubleNumber=number;

    for(int i=5; i != 0; i--)
    {
        revNumber=revNumber * 10;
        revNumber=revNumber + (doubleNumber % 10);
        doubleNumber=doubleNumber / 10;
    }
    
    if (number != revNumber)
    {
    Console.WriteLine($"The entered {number} is not a palindrome");
    }
    else Console.WriteLine($"The entered  {number} is a palindrome");
}
else Console.WriteLine("Введено не целое число");

Console.WriteLine("Программа завершила работу");