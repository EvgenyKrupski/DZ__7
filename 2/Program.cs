/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и 
    возвращает значение этого элемента или же указание, что такого элемента нет.*/

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс  искомого элемента в строке : ");
int positionString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс  искомого элемента в столбце : ");
int positionColumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (positionColumn >= 0 && positionString >= 0 && positionString == i && positionColumn == j)
        {
            Console.WriteLine($"Искомый элемент равен  {array[positionString,positionColumn]}");
            break;
        }    
    }
 if (positionColumn >= 0 && positionString >= 0 && positionString >= m || positionColumn >= n)
 {
     Console.WriteLine($" элемента с индексом {positionString} строки и индексом  {positionColumn} столбца в массиве нет");
            break;
 }
 Console.WriteLine();
}


//МЕТОД ПЕЧАТИ МАССИВА
void PrintArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}
// МЕТОД ЗАПОЛНЕНИЯ МАССИВА
void FillArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}