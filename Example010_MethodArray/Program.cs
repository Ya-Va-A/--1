﻿
//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };// определим массив
// для получения элемента
int n = array.Length; //возвращает длину массива
int find = 18;

int index = 0; // устанавливаем счетчик index в позицию 0

//цикл? в котором проверям
while (index < n) // если индекс меньше n
{
    if (array[index] == find) //если array совпал с find
    {
        Console.WriteLine(index);
        break; // для ттого? ючтобы остановиться? как будет найдено искомое число
    }
    //index = index + 1;
    index++; // на каждом этапе знач индекса нужно увеличивать
}

