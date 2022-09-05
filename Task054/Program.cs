//
Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine()??"");
Console.Write("Введите число столбцов в массиве: ");
int columns=int.Parse(Console.ReadLine()?? "");

int[,] array=GetArray(rows, columns,0,100);
PrintArray(array);

DescendingRows(array);
Console.WriteLine();
PrintArray(array);




/////////////////////////////////////////////////
int[,] GetArray(int m, int n,int minValue,int maxValue)
{
    int[,] result= new int [m,n];

    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void DescendingRows (int[,] inArray)
{ 
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      for (int k=0; k< inArray.GetLength(1)-1; k++ )
      if(inArray[i,k]<inArray[i,k+1])
      {
        int temporary=inArray[i,k];
        inArray[i,k]=inArray[i,k+1];
        inArray[i,k+1]=temporary;
      }
    }
    }
}


    


