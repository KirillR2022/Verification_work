//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма


using static System.Console;
WriteLine("Введите массив через пробел: ");
string[] arr = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine();
Console.WriteLine("[{0}]", string.Join(", ", SelectArr(arr)));

string[] SelectArr(string[] inArr) 
{
    string[] resultArr = new string[NewArrSize(inArr)];
    int count = 0;
    foreach (var item in inArr)
    {
        if (item.Length <= 3)
        {
            resultArr[count] = item;
            count++;
        }
    }
    return resultArr;

}

int NewArrSize(string[] inArr) 
{
    int result = 0;
    foreach (var item in inArr)
    {
        if (item.Length <= 3)
            result++;
    }
    return result;
}

