// int[,] matrix = new int [3, 5];

// Random rnd = new Random();

// for (int i = 0; i < matrix.GetLength(0); i++)  
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rnd.Next(1,11);
//     }
// }

// for (int i=0; i < matrix.GetLength(0); i++)  
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }

// ФУНКЦИЯ
// 1. что делает ФУНКЦИЯ
// 2. какие данные для этого ей нужны?
// 3. что будет результатом ее работы?

int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int [rowCount,columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
     {
          matrix[i,j] = rnd.Next(1,11);
     }
    }
    return matrix;
}

void ShowMatrix (int [,] matrix)
{
   for (int i=0; i < matrix.GetLength(0); i++)  
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
} 
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);