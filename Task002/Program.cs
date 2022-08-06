Console.WriteLine("Введите первое число: "); 
string numberFirst=Console.ReadLine()??"";

int numberA;
int numberB;

if(int.TryParse(numberFirst, out numberA))  //Проверяем первый введенный символ, если это число, то программа продолжит работу. 

{Console.WriteLine("Введите второе число: ");
string numberSecond=Console.ReadLine()??"";

    if(int.TryParse(numberSecond, out numberB))
    {
     
        if (numberA>numberB)
            {Console.Write("Max");
            Console.WriteLine(numberA);
            }
      
        else 
            {
            Console.Write("Max");
            Console.WriteLine(numberB);
            }

    }
   else
   {
    Console.WriteLine ("Ошибка! Введите число!");
   }
}   
else
{
 Console.WriteLine ("Ошибка! Введите число!");
}

