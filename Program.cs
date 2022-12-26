/*// Задача 47

double[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    double[,] array1 = new double[rows, columns];
    double[,] arrayresult = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
            array1[i,j] = new Random().NextDouble();
            arrayresult[i,j] = array[i,j] + array1[i,j];
        }
return arrayresult;
}
void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2Array();
Show2Array(myArray);*/

/*// Задача 50

int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
return array;
}
void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Found(int[,] array,int frows, int fcolumns)
{
Console.Write(array[frows,fcolumns]);
if(frows > array.GetLength(0)-1)
    Console.Write("Числа с таким индексом в массиве не существует.");
if(fcolumns > array.GetLength(1)-1)
    Console.Write("Числа с таким индексом в массиве не существует.");
}

int[,] myArray = CreateRandom2Array();
Show2Array(myArray);
Console.Write("Input a number of the row in which your number: ");
int frows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the columns in which your number: ");
int fcolumns = Convert.ToInt32(Console.ReadLine());
Found(myArray,fcolumns,frows);*/

// Задача 52.

int[,] CreateRandom2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
return array;
}
void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MathMean(int[,] array)
{
    double sum = 0;
    int js = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; i == array.GetLength(0) - 1; j++)
            sum /= array.GetLength(0)-1;
            Console.Write(sum);
            js++;
        sum += array[i,js];
    }
}

int[,] myArray = CreateRandom2Array();
Show2Array(myArray);
MathMean(myArray);