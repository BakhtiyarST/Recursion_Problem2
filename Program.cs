// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

class Program
{
    static void Main()
    {
        int m, n;
        string valueStr;
        Console.WriteLine("The program calculates Ackerman function: Ackermann(m,n)");
        while (true)
        {
            Console.WriteLine("Enter the M-value or press Q to Quit");
            valueStr = Console.ReadLine();
            if (IsQSymbol(valueStr))
                break;
            m = Convert.ToInt32(valueStr);
            Console.WriteLine("Enter the N-value or press Q to Quit");
            valueStr = Console.ReadLine();
            if (IsQSymbol(valueStr))
                break;
            n = Convert.ToInt32(valueStr);
            Console.WriteLine($"The Ackerman({m},{n})={Ackermann(m, n)}");
        }
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static bool IsQSymbol(string valueStr)
    {
        if (valueStr == "q" || valueStr == "Q")
            return true;
        return false;
    }
}