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

    public static bool Factorial(int n, out int ans) {
        ans = 1;
        bool ok = true;
        try {
            checked {
                for (int i = 2; i <= n; i++)
                    ans *= i;
            }
        }
        catch (Exception) {
            ans = -1;
            ok = false;
        }
        return ok;
    }
}
class Program {
    static void Main() {

        Console.WriteLine("Number for factorial:");
        int x = int.Parse(Console.ReadLine());
        int f;
        if (Units.Factorial(x, out f))
            Console.WriteLine("Factorial({0}) = {1}", x, f);
        else
            Console.WriteLine("Cannot compute factorial");
    }
}
