using Regn;

double[] tal = new double[7];
for (int i = 0; i < 7; i++)
{
    tal[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine(RegnClass.Avg(tal));
Console.WriteLine(RegnClass.Max(tal));
Console.WriteLine(RegnClass.Min(tal));