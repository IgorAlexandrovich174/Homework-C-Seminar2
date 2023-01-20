//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//645 -> 5
//
//78 -> третьей цифры нет
//
//32679 -> 6

System.Console.Write("Введите число: ");

string inputValue = System.Console.ReadLine();

if (inputValue.Length < 3 ) {
    System.Console.WriteLine("Третья цифра отсутствует!");
} else {
    System.Console.WriteLine(inputValue[2]);
}
