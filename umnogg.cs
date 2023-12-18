using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;

public class Program
{
    static int Multiply(int a, int b) // Код реализует функцию умножения двух чисел a и b.
    {
        int result = 0; // Результат произведения сохраняется в переменной result
        if (a < 0 && b < 0)
            for (int i = 0; i < -a; i++) // Если оба числа a и b отрицательны, производится умножение по модулю и знак минус ставится перед результатом.
            {
                result += -b;
            }
        else if (a > 0 && b > 0)
            for (int i = 0; i < a; i++) // Если оба числа a и b положительны, производится обычное умножение.
            {
                result += b;
            }
        else for (int i = 0; i < Math.Max(a, b); i++)
            {
                result += Math.Min(a, b);
            }
        return result;
    }
    static void Main(string[] args) // В функции main происходит вызов функции multiply с различными аргументами и результаты выводятся на консоль.
    {
        Console.WriteLine(Multiply(5, 8));
        Console.WriteLine(Multiply(-4, -7));
        Console.WriteLine(Multiply(-6, 19));
    }
}
