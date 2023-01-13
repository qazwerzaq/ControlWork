// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 


string[] array1 = new string[9] { "Hello", "2", "world", ":-)", "Hello", "2", "world", ":-)", "111" };
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    
    for (int i = 0; i < array1.Length; i++)
    {
    if(count <= 2)
        {
            Random rnd = new Random();
            int value = rnd.Next(0,9);
            array2[count] = array1[value];
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
SecondArrayWithIF(array1, array2);
PrintArray(array1);
PrintArray(array2);

