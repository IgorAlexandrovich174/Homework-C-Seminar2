﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет


System.Console.Write("Введите число: ");

int value = Convert.ToInt32(System.Console.ReadLine());

switch (value) {
    case 1 : 
        System.Console.WriteLine("Нет");
        break;
    case 2 : 
        System.Console.WriteLine("Нет");
        break;
    case 3 : 
        System.Console.WriteLine("Нет");
        break;
    case 4 : 
        System.Console.WriteLine("Нет");
        break;
    case 5 : 
        System.Console.WriteLine("Нет");
        break;
    case 6 : 
        System.Console.WriteLine("Да");
        break;
    case 7 : 
        System.Console.WriteLine("Да");
        break;
    default :
        System.Console.WriteLine("Ввели некорректное число!");
        break;
}

