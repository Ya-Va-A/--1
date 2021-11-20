// МАССИВЫ



int Max(int arg1, int arg2, int arg3) // описываем аргумент метода[функции]
//тело метода - ищет максимум из трех чисел
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//  индексы от 0 до 8
int[] array =  { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
//для обращния к элементу массивы указывае индекс
//array[0] = 12; //обращаемся к массиву и записываем в него значение
//Console.WriteLine(array[4]); //обращаемся к массиву и получитьзначение

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);






// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
//  //              0    1   2   3   4   5   6   7   8
// int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);