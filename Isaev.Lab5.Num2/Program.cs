static double Function(double x, double k)
{

    double f = (x * k + 1) / ((-k) * (-k) * (-k));
    return f;
}


double x = Convert.ToDouble(Console.ReadLine());

double sum = 0;
Console.WriteLine("Сумма ряда:");
for (int k = 1; k < 6; k++)
{
    double f = Function(x, k);
    //Console.WriteLine(f);
    sum += f;

    //Console.WriteLine();


}
Console.WriteLine(sum);
Console.WriteLine("Произведение ряда:");

double sum1 = 1;
for (int k = 1; k < 6; k++)
{
    double f = Function(x, k);
    // Console.WriteLine(f);
    sum1 *= f;

    // Console.WriteLine();


}
Console.WriteLine(sum1);