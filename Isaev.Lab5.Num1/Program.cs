static double Function(double x, double k)
{
    double f = (x * k + 1) / k * k * k;
    return f;
}
Console.WriteLine("Выберите цикл: for,while, do-while ");
string line = Console.ReadLine();

switch (line)
{
    case "for":
        for (int x = -10; x < 11; x++)
        {
            for (int k = 5; k < 11; k++)
            {
                double t = Function(x, k);
                Console.Write($"{Math.Round(t, 3)}\t");

            }
            Console.WriteLine();

        }
        break;

    case "while":
        int y = -10;
        while (y < 11)
        {
            int z = 5;
            while (z < 11)
            {
                double t = Function(y, z);
                Console.Write($"{Math.Round(t, 3)}\t");
                z++;

            }
            Console.WriteLine();
            y++;
        }
        break;

    case "do-while":
        int m = -10;
        do
        {
            int n = 5;
            do
            {
                double t = Function(m, n);
                Console.Write($"{Math.Round(t, 3)}\t");
                n++;
            }

            while (n < 11);
            Console.WriteLine();
            m++;
        }
        while (m < 11);

        break;


}