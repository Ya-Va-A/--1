int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}


// стихийный код
// процедурный код
// максимум из 9 числес - для этого нужны функции (методы) 
// примеры функций (или методов)  - NExt (1, 10); WriteLine ("Hello!")


 ВозвращаемыйТипДанных ИмяМетода ([nbg])