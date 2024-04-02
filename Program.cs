using System;
                                                
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите x в диапазоне |x|<1:");
        double x = double.Parse(Console.ReadLine());
        if (Math.Abs(x) >= 1)
        {
            Console.WriteLine("Введите число меньше 1");
        }
        else
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double verh = 1;
                double niz = 1;
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        niz *= (2 * j);
                    }
                    else
                    {
                        verh *= (2 * j - 1);
                    }
                }
                sum += (verh * Math.Pow(x, (2 * i + 1))) / (niz * (2 * i) * (2 * i + 1));
            }
            Console.WriteLine(Math.PI / 2 - sum);
        }
    }
}
