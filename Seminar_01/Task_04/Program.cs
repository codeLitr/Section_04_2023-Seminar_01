// Напишите программу, которая на вход принимает трехзначное
// число и на выходе показывает последнюю цифру этого числа.

// int tripleDigitNumb = Convert.ToInt32(Console.ReadLine());
// int lastDigit = tripleDigitNumb % 10;

// System.Console.WriteLine(lastDigit);

// ВАРИАНТ Решения, чтобы вывело второе число:

// int tripleDigitNumb = Convert.ToInt32(Console.ReadLine());
// int delFirstNumb = tripleDigitNumb % 100;
// int secondNumb = delFirstNumb / 10;

// System.Console.WriteLine(secondNumb);

// ВАРИАНТ Решения, чтобы вывело первое число:
int tripleDigitNumb = Convert.ToInt32(Console.ReadLine());
int firstNumb = tripleDigitNumb / 100;

System.Console.WriteLine(firstNumb);
