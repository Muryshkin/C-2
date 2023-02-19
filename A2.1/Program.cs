// Програма, которая выводит третью цыфру заданного числа или сообщает,
// что третьей цыфры нет. ПРИМЕР: 456 - 5   45 - нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirPank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;

}
bool ValidataNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Нет третьей цыфры ");
        return false;
    }
}
int number = Prompt("Введите число ");
if (ValidataNumber(number))
{
    Console.WriteLine(GetThirPank(number));
}