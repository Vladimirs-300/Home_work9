﻿// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string messege)
{
    Console.Write(messege);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение не возможно преобразовать в число");
}

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}


int numberM = Prompt("Введите число М: -> ");
int numberN = Prompt("Введите число N: -> "); 
GapNumberSum(numberM, numberN, 0);