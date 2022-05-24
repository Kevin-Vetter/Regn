using Regn;

double[] tal = new double[7];

Console.WriteLine("Indtast regn i mm/m² for den sidste uge: ");
for (int i = 0; i < 7; i++)
{
    tal[i] = RegnClass.TryParse();
}
Console.Clear();
bool activeLoop = false;
do
{
    Console.WriteLine("Vælge et af følgende: \n1. Gennemsnitlig nedbør\n2. Maximalt nedbør\n3. Minimalt nedbør\n4. Brugerdefineret intastning\n5. Luk program");
    string? menuInput = Console.ReadLine();
    switch (menuInput)
    {
        case "1":
            Console.WriteLine($"Gennemsnitlig nedbør den seneste uge {RegnClass.Avg(tal)}mm");
            activeLoop = false;
            break;
        case "2":
            Console.WriteLine($"Maximalt nedbør den seneste uge {RegnClass.Max(tal)}mm");
            activeLoop = false;
            break;
        case "3":
            Console.WriteLine($"Minimalt nedbør den seneste uge {RegnClass.Min(tal)}mm");
            activeLoop = false;
            break;
        case "4":
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine($"Måleværdi {i + 1}: {tal[i]}");
            }
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Ugyldig værdi, prøv igen...");
            Thread.Sleep(250);
            Console.Clear();
            activeLoop = true;
            break;
    }
}
while (activeLoop);
Console.WriteLine("Tryk på en knap for at lukke programmet.");
Console.ReadKey();