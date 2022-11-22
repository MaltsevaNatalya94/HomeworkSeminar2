/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int num=  Convert.ToInt32(Console.ReadLine());
int count = num.ToString().Length;

int result = 0;
if (count < 3)
{
    Console.Write("Третьей цифры нет");
}
else
{
    int c = 1;
    for (int i = count; i > 3; i--)
    {
        c = c * 10;
    }

    result = (num / c) % 10;
    Console.WriteLine(result);
}


