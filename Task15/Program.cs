// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num >= 1 && Num <= 7)
    if (Num >= 6)
    {
    Console.WriteLine("ЭТО ВЫХОДНОЙ");
    }
    else
    {
    Console.WriteLine("Это не выходной");
    }
else 
{
    System.Console.WriteLine("Такого дня в неделе нет! В неделе 7 дней");
}

