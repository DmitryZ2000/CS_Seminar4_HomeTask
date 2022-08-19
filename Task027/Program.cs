//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
void DigitalSum(int num)
{
    int rezult = 0;
    while (num > 0)
    {
        rezult = rezult + (num % 10);
        num = num / 10;
    }
    Console.WriteLine($"Сумма чмсел числа  = {rezult}.");
}

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
DigitalSum(number);