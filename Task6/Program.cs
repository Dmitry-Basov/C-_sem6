// // Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.



string CharArrayToString(char[,] arr)
{
    string res = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res += arr[i, j];
        }
    }
    return res;
}
char[,] array = new char[,]{{'a', 'b', 'c'}, {'d', 'e', 'f'}};
string result = CharArrayToString(array);
Console.WriteLine(result);