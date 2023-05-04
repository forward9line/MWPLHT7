//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*

Console.Write("Введите количество строк массива: m = ");
int m = CheckNumber();

Console.Write("Введите количество столбцов массива: n = ");
int n = CheckNumber();

double[,] array = Generate2DArray(m, n);
PrintArray(array);


double[,] Generate2DArray(int m, int n)
{

    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(random.Next(-100, 100) * 0.1, 1);

        }
    }
    return array;
}

int CheckNumber()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int d);

    if (!isParsed)
    {
        Console.WriteLine("Введено не число");
              
        return 0;
    }
       return d; 
    

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

}

*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//1, 7 -> такого числа в массиве нет

/*
Console.Write("Введите количество строк массива: m = ");
int m = CheckNumber();

Console.Write("Введите количество столбцов массива: n = ");
int n = CheckNumber();

int[,] array = Generate2DArray(m, n);
PrintArray(array);


Console.Write("Введите номер строки: x = ");
int x = CheckNumber();

Console.Write("Введите номер столбца: y = ");
int y = CheckNumber();

FindPosition(x, y, array);

void FindPosition(int g, int h, int[,] array)
{
    if (g > array.GetLength(0) - 1 | h > array.GetLength(1) - 1)
    {
        Console.WriteLine($"{g}, {h} -> такого числа в массиве нет");
        return;
    }

    Console.WriteLine($"{g}, {h} -> {array[g, h]}");







}

int[,] Generate2DArray(int m, int n)
{

    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 20);

        }
    }
    return array;
}

int CheckNumber()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int d);

    if (!isParsed)
    {
        Console.WriteLine("Введено не число");

        return 0;
    }
    return d;


}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

}


*/










//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: m = ");
int m = CheckNumber();

Console.Write("Введите количество столбцов массива: n = ");
int n = CheckNumber();

int[,] array = Generate2DArray(m, n);
PrintArray(array);


double[] array1 = ArithmeticMean(array);
PrintArray1D(array1);


double[] ArithmeticMean(int[,] arr)
{
    double[] arr1 = new double[arr.GetLength(1)];
    
    double r = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        r = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
           r = r + arr[i, j];  

        }
        arr1[j] = r/arr.GetLength(0);
    }






    return arr1;
}


int[,] Generate2DArray(int m, int n)
{

    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 20);

        }
    }
    return array;
}

int CheckNumber()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int d);

    if (!isParsed)
    {
        Console.WriteLine("Введено не число");

        return 0;
    }
    return d;


}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

}

void PrintArray1D(double[] array)
{
    Console.WriteLine($"{string.Join(", ", array)}");
}









