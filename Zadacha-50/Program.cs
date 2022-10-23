// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int [,] Fill_array()
{
    Random rnd = new Random();
    int row = rnd.Next(1,10);
    int column = rnd.Next(1,10);
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

void Print_elem(int[,] array)
{
  int n = Convert.ToInt32(Console.ReadLine());
  int m = Convert.ToInt32(Console.ReadLine());
  try
  {
    Console.WriteLine("Элемент по вашему индексу: " + array[n,m]);
  }
  catch(IndexOutOfRangeException e)
  {
    Console.WriteLine("Вас куда-то не туда занесло...");
  }
}



Console.WriteLine("Вот тебе матрица, напиши индекс элемента");
int[,] array = Fill_array();
Print_elem(array);
