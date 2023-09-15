using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using static System.Math;
int x;



do
{

    Console.WriteLine("Введите операцию");
    Console.WriteLine("1.Сложить 2 числа");
    Console.WriteLine("2.Вычесть первое из второго");
    Console.WriteLine("3.Перемножить два числа");
    Console.WriteLine("4.Разделить первое на второе");
    Console.WriteLine("5.Возвести в степень N первое число");
    Console.WriteLine("6.Найти квадратный корень из числа");
    Console.WriteLine("7.Найти 1 процент от числа");
    Console.WriteLine("8.Найти факториал из числа");
    Console.WriteLine("9.Завершить программу");

    string input = Console.ReadLine();
    x = Convert.ToInt32(input);
    if (x == 1)
    {
        Console.WriteLine("Введите 1 число");
        string u = Console.ReadLine();
        int z = Convert.ToInt32(u);
        Console.WriteLine("Введите 2 число");
        string o = Console.ReadLine();
        int y = Convert.ToInt32(o); ;
        int result = z + y;
        Console.WriteLine(result);
    }
    else if (x == 2)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        int e = Convert.ToInt32(w);
        Console.WriteLine("Введиете 2 число");
        string t = Console.ReadLine();
        int n = Convert.ToInt32(t);
        int f = e - n;
        Console.WriteLine(f);
    }
    else if (x == 3)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        int e = Convert.ToInt32(w);
        Console.WriteLine("Введиете 2 число");
        string t = Console.ReadLine();
        int n = Convert.ToInt32(t);
        int f = e * n;
        Console.WriteLine(f);
    }
    else if (x == 4)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        float e = Convert.ToInt32(w);
        Console.WriteLine("Введиете 2 число");
        string t = Console.ReadLine();
        float n = Convert.ToInt32(t);
        float f = e / n;
        Console.WriteLine(f);
    }
    else if (x == 5)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        int e = Convert.ToInt32(w);
        Console.WriteLine("Введиете 2 число");
        string t = Console.ReadLine();
        int n = Convert.ToInt32(t);
        double f = Pow(e, n);
        Console.WriteLine(f);
    }
    else if (x == 6)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        int e = Convert.ToInt32(w);
        double f = Sqrt(e);
        Console.WriteLine(f);

    }
    else if (x == 7)
    {
        Console.WriteLine("Введите 1 число");
        string w = Console.ReadLine();
        int e = Convert.ToInt32(w);

        Console.WriteLine((double)e / 100);
    }

    else if (x == 8)
    {
        Console.Write("Введите число : ");
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;





        }
        Console.WriteLine(factorial);
    }














} while (x < 9);
