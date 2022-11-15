// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintEvenNatureNumbers(int minvalue, int maxvalue)
{
    if (minvalue >= maxvalue)
    {
        return;
    }
    System.Console.Write(minvalue + 1 + "  ");
    PrintEvenNatureNumbers(minvalue + 1, maxvalue);
    System.Console.WriteLine();
}

PrintEvenNatureNumbers(0, 10);
