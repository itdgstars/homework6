void numbers(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    if (k1 != k2 & b1 != b2)
    {
        if (y1 == y2)
        {
            Console.WriteLine ($"({x}; {y1})");
        }
    
    }
    else Console.WriteLine ("Ваши прямые паралелльны.");
}

Console.WriteLine ("Введите b1 ");
int b1b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите k1 ");
int k1k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите b2 ");
int b2b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите k2 ");
int k2k = Convert.ToInt32(Console.ReadLine());

numbers(b1b,k1k,b2b,k2k);

