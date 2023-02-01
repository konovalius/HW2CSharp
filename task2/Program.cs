//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1000 ;
int result = 0;
while (i < number)
{
    i = i * 10;
    
}
if (number<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
   result = number % (i/100)  ;
   result = result / (i/1000) ;
   Console.WriteLine(result);
}