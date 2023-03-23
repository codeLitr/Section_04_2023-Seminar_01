// Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя).
// 4 -> 16
// -3 -> 9
// -7 -> 49

// int inputNumber = Convert.ToInt32(Console.ReadLine());
// int square = inputNumber * inputNumber;

// System.Console.WriteLine(square);

// Вариант решения для задачи, где требуется возвести число в 10-ю степень:

int inputNumber = Convert.ToInt32(Console.ReadLine());
int square = Convert.ToInt32(Math.Pow(inputNumber, 10)); //Библиотека Math содержит различные математические
//действия. Pow это возведение в степень. Т.к. Math по умолчанию выдает тип значения
//double, то необходимо конвертировать значение в int.

System.Console.WriteLine(square);
