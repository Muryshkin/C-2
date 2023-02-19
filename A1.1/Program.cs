// Программа,которая на вход принимает трёхзначное число, а на выходе
// показывает его вторую цыфру.  Пример: 456 -> 5

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трёхзначное число ");
if (number <= 100 || number >= 1000)
{
    Console.WriteLine("Это не трёхзначное число ");
    return;
}
Console.WriteLine($"{number} ");
int secontpent = number % 100 / 10;
Console.WriteLine($"{secontpent} ");