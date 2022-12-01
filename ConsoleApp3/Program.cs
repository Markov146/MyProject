namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int actions = 10;
            do
            {
                Console.WriteLine("1. Сложить два числа");
                Console.WriteLine("2. Вычесть из первого второе");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");
                actions = Convert.ToInt32(Console.ReadLine());
                {
                    if (actions == 1)
                    {
                        Console.WriteLine("Введите первое число :");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(a + b);
                    }
                    else if (actions == 2)
                    {
                        Console.WriteLine("Введите первое число :");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(a - b);
                    }
                    else if (actions == 3)
                    {
                        Console.WriteLine("Введите первое число :");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(a * b);
                    }
                    else if (actions == 4)
                    {
                        Console.WriteLine("Введите первое число :");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        Double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(a / b);
                    }
                    else if (actions == 5)
                    {
                        Console.WriteLine("введите число ");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите степень N:");
                        Double N = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Pow(a, N));
                    }
                    else if (actions == 6)
                    {
                        Console.WriteLine("введите число ");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(a));
                    }
                    else if (actions == 7)
                    {
                        Console.WriteLine("введите число ");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(a * 0.01);
                    }
                    else if (actions == 8)
                    {
                        Console.WriteLine("введите число ");
                        Double a = Convert.ToDouble(Console.ReadLine());
                        int f = 1;
                        for (int i = 1; i <= a; i++)
                        {
                            f *= i;
                        }
                        Console.WriteLine(a = f);

                    }

                }

            }
            while (actions != 9);
            
        }
    }
}