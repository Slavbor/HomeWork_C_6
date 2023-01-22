// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();
Write("Enter any numbers separated by space: ");

string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)!;

WriteLine(AboveZeroCalculation(array));







int AboveZeroCalculation(string[] arrayCalc)
{

    int count = 0;
    foreach (var element in arrayCalc)
    {
        if(int.Parse(element) > 0)
        {
            count++;
        }
    }
    return count;
} 