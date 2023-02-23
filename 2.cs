using System;

class Units {
    public static int Greater(int a, int b) {
        if (a > b)
            return a;
        else
            return b;
    }

    public static void Swap(ref int a, ref int b) {
        int tmp = b;
        b = a;
        a = tmp;
    }
}
class Program {
    static void Main() {

        int x, y;
        Console.WriteLine("Введите первое число:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("До swap: \t" + x + " " + y);
        Units.Swap(ref x, ref y);
        Console.WriteLine("После swap: \t" + x + " " + y);
    }
}
