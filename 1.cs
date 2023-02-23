using System;

class Units {
    public static int Greater(int a, int b) {
        if (a > b)
            return a;
        else
            return b;
    }

}
class Program {
    static void Main() {

        int x, y;
        Console.WriteLine("Введите первое число:");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        y = int.Parse(Console.ReadLine());
        int greater = Units.Greater(x, y);
        Console.WriteLine("Большим из чисел {0} и {1} является {2}", x, y, greater);

    }
}
