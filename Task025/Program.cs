// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void Exponentiation(double num, double pow)
{
    double rezult = 1;
    if (pow != 0) 
    {
        rezult = num;
        for (int i = 2; i <= pow; i++)
        {
            rezult = rezult * num;
        }
    }
    Console.WriteLine($"Возведение {num} в сетепнь {pow} = {rezult}.");
}

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целый показатель степени числа от 0 и более: ");
int power = Convert.ToInt32(Console.ReadLine());
Exponentiation(number, power);