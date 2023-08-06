Console.Clear();
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int CalculateAckermannFunctions(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return CalculateAckermannFunctions(n - 1, 1);
    else
      return CalculateAckermannFunctions(n - 1, A(n, m - 1));
}
int numberM = Prompt("Введете натуральное число : M = ");
int numberN = Prompt("Введете натуральное число: N = ");
int result = CalculateAckermannFunctions(numberM, numberN);
Console.Write("Ответ: " + result);