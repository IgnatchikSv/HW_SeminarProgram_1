// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear ();

Console.Write ("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int b = 2;

if ( numberA > 1)
{
  while (b <= numberA)
  { Console.Write ( b + " ");
  b = b + 2;
  }
}