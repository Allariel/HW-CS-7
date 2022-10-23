// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Hello, World!");
int [,] Fill_array()
{
    Random rnd = new Random();
    int row = rnd.Next(1,5);
    int column = rnd.Next(1,5);
    int[,] array = new int[row,column];
    for (int i = 0; i < row; i++)
    { 
        for (int j = 0; j < column;j++)        
        {
            array[i,j] = rnd.Next(1,10);
        }
    }

    for (int i = 0; i < row; i++)
    {
        Console.WriteLine(); 
        for (int j = 0; j < column; j++)        
        {
            Console.Write(" " +  array[i,j] + " ");
        }
    }
    Console.WriteLine();
    return array;
}

void Avg_col(int[,] array)
{
     for (int i = 0; i < array.GetLength(1); i++)
    { 
        double average = 0;
        for (int j = 0; j < array.GetLength(0);j++)        
        {
            average +=array[j,i];
        }
        Console.WriteLine("Cреднее арифметическое в " + i +" столбце:" + ( average/ array.GetLength(0)) ) ;
    }
}

int[,] array = Fill_array();
Avg_col(array);