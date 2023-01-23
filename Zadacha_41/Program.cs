// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();
Write("Enter any numbers separated by space: ");

string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)!;
WriteLine();
WriteLine($" Quantity of numbers above zero: {AboveZeroCalculation(array)}");
WriteLine();







int AboveZeroCalculation(string[] MetodArray)
{
    int count = 0;
    foreach (var element in MetodArray)
    {
        if(int.Parse(element) > 0)
        {
            count++;
        }
    }
    return count;
} 