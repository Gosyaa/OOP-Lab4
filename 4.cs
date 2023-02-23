using System;


class Operation {

    private static bool Check(double a, double b, double c) {
        if (a + b + c - Math.Min(a, Math.Min(b, c)) <= Math.Max(a, Math.Max(b, c)))
            return false;
        return true;
    }
    public static double Calc_Square(double a, double b, double c) {
        if (Check(a, b, c)) {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        return -1;
    }
    public static double Calc_Square(double a) {
        return (Math.Sqrt(3) * a * a / 4);
    }

}
class Program {
    static void Main() {

        Console.WriteLine("Укажите тип треугольника (1 - равносторонний, 2 - неравносторонний)");
        int type = int.Parse(Console.ReadLine());
        switch (type) {
            case 1:
                Console.WriteLine("Введите сторону равностороннего треугольника");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь треугольника: {0}", Math.Round(Operation.Calc_Square(a), 2));
                break;
            case 2:
                Console.WriteLine("Введите стороны треугольника");
                var input = Console.ReadLine().Split();
                a = double.Parse(input[0]);
                double b = double.Parse(input[1]), c = double.Parse(input[2]);
                double sq = Operation.Calc_Square(a, b, c);
                if (sq > 0)
                    Console.WriteLine("Площадь треугольника: {0}", Math.Round(sq, 2));
                else
                    Console.WriteLine("Вырожденный треугольник");
                break;
            default:
                Console.WriteLine("Неверный входные данные");
                break;
        }
    }
}
