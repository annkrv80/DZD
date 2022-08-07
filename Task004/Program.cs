Console.WriteLine("Введите перое число...");
string numberFirst=Console.ReadLine()??"";
int a; 
int b;
int c;
int max=0;

if(int.TryParse(numberFirst,out a))
{ max=a;
  Console.WriteLine("Введите второе число...");
  string numberSecond=Console.ReadLine()??"";
    if(int.TryParse(numberSecond, out b))
    {Console.WriteLine("Введите третье число");
     string numberThird=Console.ReadLine()??"";
     if (int.TryParse(numberThird, out c))
      {if (a<b)
      {max=b;}

      if (b<c)
      {max=c;}
        
      Console.Write("max");
      Console.WriteLine (max);

    


      }
      else
      {
        Console.WriteLine ("Ошибка! Введите число!");
      }




    }
    else
    {
      Console.WriteLine("Ошибка!Введите число!");
    }




}
else
{
 Console.WriteLine ("Ошибка! Введите число!");
}
