//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.Write("{0} максимальное", a);
    }
    else
        Console.Write("{0} максимальное", c);
}
else
{
    if (b > c)
    {
        Console.Write("{0} максимальное", b);
    }
    else
        Console.Write("{0} максимальное", c);
}
