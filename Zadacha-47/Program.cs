// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] Fill_array(double[,] array)
{
    Random rnd = new Random();
    int row = array.GetLength(1);
    int column = array.GetLength(0);
    for (int i = 0; i < column; i++)
    { 
        for (int j = 0; j < row;j++)        
        {
            array[i,j] = Math.Round( (1 + rnd.NextDouble() * (1 + 998)) ,3);
        }
    }
    return array;
}



Console.WriteLine("Give me n and m");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[n,m];
array = Fill_array(array);
for (int i = 0; i < n; i++)
    {
        Console.WriteLine(); 
        for (int j = 0; j < m; j++)        
        {
            Console.Write(" " +  array[i,j].ToString("000.000") + " ");
        }
    }