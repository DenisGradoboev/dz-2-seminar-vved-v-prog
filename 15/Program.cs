//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет 
Console.Clear();
Console.Write("Введите день недели: ");
int Num = int.Parse(Console.ReadLine());
    if ((Num > 7) || (Num < 1))
    Console.WriteLine ("Ты дурак?");

    if ((Num > 5 ))
     Console.WriteLine("Выходной!");

    else 
     Console.WriteLine("нет");
