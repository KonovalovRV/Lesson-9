// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// A(0,n) = n+1
// A(m,0) = A(m-1,1)
// A(m,n) = (A(m-1,A(m,n-1) --> m>0 & n>0
// int m = 3;
// int n = 2;

int Prompt(string mes)
{
    Console.WriteLine(mes);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

 int FunctionAkkerman(int arg1, int arg2)
{
    if (arg1>5 && arg2>5)
    {
        return -1;
    }
    if (arg1 == 0)
    {
        return arg2 += 1;
    }
    if (arg2 == 0)
    {
        return FunctionAkkerman(arg1 - 1, 1);
    }
    return FunctionAkkerman(arg1 - 1, FunctionAkkerman(arg1, arg2 - 1));
}

int m = Prompt("Введите в качестве примера неотрицательное число (3)-->   ");
int n = Prompt("Введите в качестве примера неотрицательное число (2)-->   ");

int value = FunctionAkkerman(m,n);
System.Console.WriteLine($"Решение функции Аккермана A({m},{n}) = {value}");