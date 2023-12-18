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
    static int Multiply(int a, int b)
    {
        int result = 0;
        if (a < 0 && b < 0)
            for (int i = 0; i < -a; i++)
            {
                result += -b;
            }
        else if (a > 0 && b > 0)
            for (int i = 0; i < a; i++)
            {
                result += b;
            }
        else for (int i = 0; i < Math.Max(a, b); i++)
            {
                result += Math.Min(a, b);
            }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Multiply(5, 8));
        Console.WriteLine(Multiply(-4, -7));
        Console.WriteLine(Multiply(-6, 19));
    }
}
