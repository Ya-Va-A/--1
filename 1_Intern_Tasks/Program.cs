// 0. Вывести квадрат числа
// int number = 3;
// int result = number * number; 
// Console.WriteLine(result);

// ------------------------------

// 1.По двум заданным числам 
// проверять является ли первое квадратом второго
// int numberA = 3
// int numberB = 9
// if 

// ------------------------------

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

// ------------------------------

// 3.По заданному номеру дня недели вывести его название

// Console.WriteLine ("Enter day number");
// string daynumber = Console.ReadLine();
// if (daynumber.ToLower() == "1")
// {
//     Console.WriteLine("Monday");
// }
// if (daynumber.ToLower() == "2")
// {
//     Console.WriteLine("Tuesday");
// }
// if (daynumber.ToLower() == "3")
// {
//     Console.WriteLine("Wednesday");
// }
// if (daynumber.ToLower() == "4")
// {
//     Console.WriteLine("Thursday");
// }
// if (daynumber.ToLower() == "5")
// {
//     Console.WriteLine("Friday");
// }
// if (daynumber.ToLower() == "6")
// {
//     Console.WriteLine("Suterday");
// }
// if (daynumber.ToLower() == "7")
// {
//     Console.WriteLine("Sunday");
// }

// Var 1
// Console.WriteLine("Enter number from 1 to 7");
//   string DayName (int daynumber)
// {
//        string[] dayname = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
//        return dayname[daynumber - 1];
// } 
// int daynumber = new Random().Next(1,8);
// Console.WriteLine($"{daynumber} = {DayName(daynumber)}");

// ------------------------------

// 4. Найти максимальное из трех чисел

// int a = 5;
// int b = 9;
// int c = 2;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine("max = ");
// Console.WriteLine (max);

// 5. Написать программу вычисления значения функции y = f(a)
// Console.WriteLine ("Enter number");
// int a = new Random().Next (1, 10);
// int y = a;
// Console.WriteLine ($"y=f({a})");

// ------------------------------

// 6. Выяснить является ли число чётным

// int a = new Random().Next (1,10);
// bool NUM (int a)
// {
//     if (a % 2 == 0) return true;
//     else return false;
// }
// Console.WriteLine($"Проверяемое число {a}");
// if (NUM (a) == true)
// Console.WriteLine ($"{a} - число четное");
// if (NUM (a) == false)
// Console.WriteLine ($"{a} - число нечетное");

// ------------------------------

// 7. Показать числа от -N до N


// ------------------------------

// 8. Показать четные числа от 1 до N

// ------------------------------

// 9. Показать последнюю цифру трёхзначного числа

// ------------------------------

// 10. Показать вторую цифру трёхзначного числа

// ------------------------------

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// ------------------------------

// 12. Удалить вторую цифру трёхзначного числа

// ------------------------------

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// ------------------------------

// 14. Найти третью цифру числа или сообщить, что её нет