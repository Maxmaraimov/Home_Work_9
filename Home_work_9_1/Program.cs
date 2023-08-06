Console.Clear();
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void ShowNumber(int numberN)
{
    if (numberN < 0)
    {
        Prompt("Введете натуральное число: ");
    }
    else
    {
        Console.Write(numberN + " ");
        if (numberN > 1)
        {
            ShowNumber(numberN - 1);
        }
    }
}

int number = Prompt("Введете натуральное число: ");
ShowNumber(number);