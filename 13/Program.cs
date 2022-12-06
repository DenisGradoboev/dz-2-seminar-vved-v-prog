//Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    } ;
    if (num >= 1000)
    
    {
         while (num >= 1000)
         num/=10;
      
    } 
    if (num < 1000 && num >= 100)
    {
       int result = num % 10;
       Console.WriteLine($"{num} -> {result}");
    }