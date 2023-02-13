// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a != b)
{
    if (a < b)
        Console.Write("{0} больше {1}", b, a);
    else
        Console.Write("{0} больше {1}", a, b);
}
else
    Console.Write("Числа равны");
