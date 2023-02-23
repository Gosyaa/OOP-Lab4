using System;
class Operation {

    public static int CalcRoots(double a, double b, double c, out double x1, out double x2) {
        x1 = 0;
        x2 = 0;
        double d = b * b - 4 * a * c;
        if (d > 0) {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return 1;
        }
        else if (d < 0)
            return -1;
        else {
            x1 = -b / (2 * a);
            return 0;
        }
    }

}
class Program {
    static void Main() {

        Console.WriteLine("Введите коэффиценты квадратного уравнения");
        var input = Console.ReadLine().Split();
        double a = double.Parse(input[0]), b = double.Parse(input[1]), c = double.Parse(input[2]);
        int op = Operation.CalcRoots(a, b, c, out double x1, out double x2);
        switch (op) {
            case -1:
                Console.WriteLine("Корней уравнения с коэффицентами a = {0}, b = {1}, c = {2} нет", a, b, c);
                break;
            case 0:
                Console.WriteLine("Корни уравнения с коэффицентами a = {0}, b = {1}, c = {2} равны x1 = x2 = {3}", a, b, c, x1);
                break;
            case 1:
                Console.WriteLine("Корни уравнения с коэффицентами a = {0}, b = {1}, c = {2} равны x1 = {3} и x2 = {4}", a, b, c, x2, x1);
                break;
        }

    }
}
