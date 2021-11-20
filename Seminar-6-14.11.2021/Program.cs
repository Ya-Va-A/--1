// 31. Задать массив из 8 элементов и ввести их на экран

//char FillArray() // тип данных - символы, на входе еще ничего нет
// {
//     return Convert.ToChar(new Random().Next(100,150));
// }

// char[] array = new char[8];
// массив
// Console.WriteLine("Массив из 8 элементов");
// for (int index = 0; index < array.Length; index++)
// {
//     array[index] = FillArray();
//     Console.Write($"{array[index]}");
// }
// Console.WriteLine();

// method
// string PrintArray(char[] array)
// {
//     string result = string.Empty;
//     for (int index = 0; index < array.Length; index++)
//     {
//         result += $"{Convert.ToChar(new Random().Next(65,90))} ";
//     }
//     return result;
// }

// char[] array = new char[8];

// console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));

// string PrintArray(char[] array)
// {   
//     string result = string.Empty;                                  // Создаем пустую строку 
//     for (int index = 0; index < array.Length; index++)
//     {
//         result += $"{Convert.ToChar(new Random().Next(65,90))} ";  // 65-90 это символы A..Z в таблице кодировок
//     }
//     return result;
// }

// char[] array = new char[8];                                         // создаем массив из 8 символов (по умолчанию пустой)

// Console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));                               // вызываем функцию и выводим на экран массив символов


//

// 32. Задать массив из 8 элементов и ввести их на экран

// string FillArray(int[] array) // тип данных - символы, на входе еще ничего нет
// {
//     string result = string.Empthy;
//     for (int index = 0; index < array.Length; index++)
//     {
//        array[index] = new Random().Next(0, 2);
//        result += $"{array[index]}";
//     }
//     return result;
// }

// int[] array = new int [8];

// Console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));  

//32 Задать м ассив из 12 элементов? заполненных числами [0,9].
// и найти сумму положительных  отрицательных чисел

int Array(int[] array)//[0,1,2,3,4,5,6,7,8,9]
{
    for (int = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 2);
    }
    return array [index];
}

int PrintArray(int[] array)
{
    int index=0;
    for (index < array.Length; index++)
    Console.WriteLine(array[index]);
    return
}

int[]array = new int [12];
PrintArray(array);
Console.WriteLine("Массив из 18 элементов от 0 до 9")ж