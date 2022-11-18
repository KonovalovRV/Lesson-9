// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string mes)
{
    Console.WriteLine(mes);
    int arg = Convert.ToInt32(Console.ReadLine());
    return arg;
}

int SumNatureNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        return 0;
    }
    return num1 + SumNatureNumbers(num1 + 1, num2);
}

int minvalue=Prompt("Введите начальное значение промежутка -->   ");
int maxvalue=Prompt("Введите конечное значение промежутка -->   ");

int sum = SumNatureNumbers(minvalue, maxvalue);

System.Console.WriteLine($"Сумма чисел в промежутке от {minvalue} до {maxvalue} равна {sum}");
