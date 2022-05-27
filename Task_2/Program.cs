// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. 
//Задачу решить без использования строк (string).


    Console.WriteLine("Введите Натуральное число = ");
    int num = int.Parse(Console.ReadLine());
    int dig = 0;
    for (int i = 1; i < num; i = i * 10)
    {
        dig++;
    }
    Console.WriteLine($"Количество цифр в строке {num} = {dig}");

    int sum = 0;
    for (int i = 0; i < dig; i++)
    {
        int num1 = num % 10;
        num = num / 10;
        sum = num1 + sum;
    }
Console.WriteLine(sum);




