//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Введите трехзначное число: ");
String value = System.Console.ReadLine();

if(value.Length > 3) {
    System.Console.WriteLine("Некорректный ввод! ВУ числе больше трёх цифр! Вводите трёхзначное число!");
} else {
    System.Console.WriteLine(value[1]);
}
