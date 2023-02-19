// Программа,которая на вход принимает трёхзначное число, а на выходе
// показывает вторую цыфру этого числа   Пример: 456 -> 5

Console.Write("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int tuint = 0;

if (number>99 && number<1000)
{
    tuint = number %100 /10;
    Console.Write($"{tuint} ");
}
else
{
    Console.Write("Неверный ввод ");
}