// Программа, которая принимает на вход цыфру, обозначающую день недели,
// проверяет является ли этот день выходным.

Console .Write("Введите цыфру ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    Console.Write("Будний день ");
    break;

    case 2:
    Console.Write("Будний день ");
    break;

    case 3:
    Console.Write("Будний день ");
    break;

    case 4:
    Console.Write("Будний день ");
    break;

    case 5:
    Console.Write("Будний день ");
    break;

    case 6:
    Console.Write("Выходной день ");
    break;

    case 7:
    Console.Write("Выходной день ");
    break;

    default:
    Console.Write("Такого дня недели нет ");
    break;
    
}