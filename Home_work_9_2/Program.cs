Console.Clear();
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int ShowNumbersMN(int M, int N){
    if (Math.Min(M, N) != Math.Max(M, N))
    {
        return ShowNumbersMN(Math.Min(M, N) + 1, Math.Max(M, N)) + Math.Min(M, N);
    }
    return M;
}
int numberM = Prompt("Введете натуральное число : M = ");
int numberN = Prompt("Введете натуральное число: N = ");
int result = ShowNumbersMN(numberM, numberN);
Console.Write("Sum =  " + result);