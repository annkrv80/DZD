Console.WriteLine("Введите число: ");
int N=int.Parse(Console.ReadLine()??"");
int x;
int count = N;
while (N>1)
{x=N-1;
   if((x%2)==0)
   {
    Console.WriteLine(x);
   }
   count=count-1;

}



