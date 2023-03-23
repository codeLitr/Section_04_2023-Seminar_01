// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

int dayName = Convert.ToInt32(Console.ReadLine());
if (dayName == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (dayName == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (dayName == 3)
{
    System.Console.WriteLine("Среда");
}
else if (dayName == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (dayName == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (dayName == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (dayName == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else 
{
    System.Console.WriteLine("Нет такого дня недели");    
}
