// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string mes)
{
    Console.WriteLine(mes);
    int arg = Convert.ToInt32(Console.ReadLine());
    return arg;
}

void PrintEvenNatureNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        return;
    }
    if (num1 % 2 == 0)
    {
        System.Console.Write(num1 + "  ");
        PrintEvenNatureNumbers(num1 + 2, num2);
    }
    else
    {
        num1 += 1;
        System.Console.Write(num1 + "  ");
        PrintEvenNatureNumbers(num1 + 2, num2);
    }
}
System.Console.WriteLine();

int minvalue = Prompt("Введите начальное значение промежутка -->   ");
int maxvalue = Prompt("Введите конечное значение промежутка -->   ");
PrintEvenNatureNumbers(minvalue, maxvalue);
