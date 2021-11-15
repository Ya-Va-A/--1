// 0. Вывести квадрат числа
// int number = 3;
// int result = number * number; 
// Console.WriteLine(result);

// 1.По двум заданным числам 
// проверять является ли первое квадратом второго

// int numberA = 3
// int numberB = 9

// if 

// 2. Даны два числа. Показать большее и меньшее число
//  int a = 3;
//  int b = 9;
//  int max = a;
//  int min = b;

//  if (a > max) max = a; 
//  if (b < max) min =b;
//  if (b > max) max = b;
//  if (a < max) min = a;

// Console.Write("max = ");
// Console.WriteLine(max);
// Console.Write("min = ");
// Console.WriteLine(min);

// 3.По заданному номеру дня недели вывести его название

Console.WriteLine ("Enter day number");
string daynumber = Console.ReadLine();
if (daynumber.ToLower() == "1")
{
    Console.WriteLine("Monday");
}
if (daynumber.ToLower() == "2")
{
    Console.WriteLine("Tuesday");
}
if (daynumber.ToLower() == "3")
{
    Console.WriteLine("Wednesday");
}
if (daynumber.ToLower() == "4")
{
    Console.WriteLine("Thursday");
}
if (daynumber.ToLower() == "5")
{
    Console.WriteLine("Friday");
}
if (daynumber.ToLower() == "6")
{
    Console.WriteLine("Suterday");
}
if (daynumber.ToLower() == "7")
{
    Console.WriteLine("Sunday");
}

// int Monday = 1;
// int Tuesday = 2;
// int Wednesday = 3;
// int Thursday = 4;
// int Friday = 5;
// int Suterday = 6;
// int Sunday = 7;



