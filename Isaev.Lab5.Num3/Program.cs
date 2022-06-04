int byliVarianty = 0;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 20; j++)
    {
        int k = 30 - i - j;
        byliVarianty = 1;

        if (10 * i + 5 * j + 2 * k == 100 && i + j + k == 30)
        {
            Console.WriteLine($"Результат:{i} ручек,{j} карандашей,{k} ластиков");
        }
    }
}
if (byliVarianty == 0)
{ Console.WriteLine($"Нет совпадений"); }



