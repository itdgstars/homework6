void numb()
{
Console.WriteLine("Начните вводить числа. Если вы хотите закончить ввод, напишитe число '999'");
int sum = 0;
int B = 0;
while (B != 999)
{
   Console.WriteLine ("Введите число: ");
 
B = Convert.ToInt32(Console.ReadLine());
  if (B > 0)
  {
    sum++;
  } 
}
Console.WriteLine ("Количество чисел больше 0 ранво: " + sum);
}

numb();
