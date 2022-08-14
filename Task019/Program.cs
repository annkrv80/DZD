Console.Clear();
int i=0;

Console.Write("Введите пятизначное число ");
string str = Console.ReadLine()??"";
int[] number = new int[str.Length];
for( i=0; i< str.Length; i++)
{
   number[i] = int.Parse(str[i].ToString());
}
if(number[0]==number[4] && number[1]==number[3])
{
    Console.Write($"{str} палиндром"); 
}
else
{
   Console.Write($"{str} не палиндром");  
}
        









 