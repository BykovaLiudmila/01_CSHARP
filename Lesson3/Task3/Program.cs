// void ZeroEventElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }

// void PrintArray (int[] arr)
// {
//     foreach(int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] array = {1, 2, 3, 4, 5};
// ZeroEventElements(array);
// PrintArray(array);

//foreach не позволяет менять содержимое массива


// Домашняя работа

// Создать функции FillArray, PrintArray, GetSumOfElements, GetProductOfElements. 
// Добиться работоспособности проведенного кода

int n = 5;
int [] array = new int [n];
int i = 0; 

void FillArray(int[] array)
{
    while (i < n)
    {
        array [i] = i + 1;
    }
}
FillArray(array);

i = 0;
void PrintArray (int[] array)
{
    foreach(int e in array)
    {
        Console.Write($"{e} ");
    }
}
PrintArray(array);