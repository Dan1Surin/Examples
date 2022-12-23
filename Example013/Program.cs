// выводит случайное число из отрезка 10,99 и показывает наибольшую цифру числа.
int number = new Random().Next(10,100);//включает 10 не включает 100
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"Случайное число{number}");
if (firstDigit > secondDigit) Console.WriteLine($"The biggest digit{firstDigit}");
if (firstDigit < secondDigit) Console.WriteLine($"The biggest digit{secondDigit}");
if (firstDigit == secondDigit) Console.WriteLine("Digits equal");
Console.ReadLine();


