// Напишите метод, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int ThirdNumber(int num)
{
    int num1 = num/10;
    int result = num1%10;
    return result;
    
}
System.Console.Write("Вторая цифра введенного числа: ");
System.Console.WriteLine(ThirdNumber(num));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 
System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int lenght = num.Length;
if (lenght>3)
{
    System.Console.WriteLine("третья цифра введенного числа --> " + num[2]);
}
else
{
    System.Console.WriteLine("такой цифры нет");

}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


using System;
void WeekScan(int numb) 
{
  if (numb>=1 && numb<=5)
  {
    System.Console.WriteLine("день недели будний");
  }
  else
  {
    System.Console.WriteLine("день недели выходной");
  }
}
System.Console.WriteLine("Введите номер дня недели от 1 до 7(включительно):");
int numb = int.Parse(Console.ReadLine());
WeekScan(numb);
