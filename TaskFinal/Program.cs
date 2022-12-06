string[] array1 = new string[5] {"hello", "384", "world", "!", ":)"};
string[] array2 = new string[array1.Length];
void ArrayCreation(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayCreation(array1, array2);
Console.WriteLine("Имеющийся массив:");
PrintArray(array1);
Console.WriteLine("Получившийся массив:");
PrintArray(array2);