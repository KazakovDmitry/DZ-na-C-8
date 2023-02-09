/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

Dictionary<int, int> Slovar = new Dictionary<int, int>();
int[,] matrix = InitMatrix(4, 4);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(Slovar.ContainsKey(matrix[i,j]))
            Slovar[matrix[i,j]]++;
        else
            Slovar.Add(matrix[i,j], 1);
    }
}
*/

Dictionary<int, int> UniqueNumbers = new Dictionary<int, int>();
Random rnd = new Random();
int number = rnd.Next(10, 100);
while(UniqueNumbers.Count < 8)
{
    if(UniqueNumbers.ContainsKey(number))
        number = rnd.Next(10, 100);
    else
        UniqueNumbers.Add(number, 1);
}


foreach (var item in UniqueNumbers)
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раз");
}

