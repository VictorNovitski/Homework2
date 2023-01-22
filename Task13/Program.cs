// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());
int Length = Number.ToString().Length;
if (Length>= 3) 
{
	while (Number > 999)
	{
		Number = Number / 10;
	}
	int result = Number % 10;
	Console.WriteLine("Третья цифра числа: " + result);
} 
else 
{
	Console.WriteLine("В числле нет третьей цифры");
}