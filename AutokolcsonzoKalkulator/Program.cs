Console.WriteLine("Hello, World!");
List<double> fizetendo = new List<double> {};
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{i+1}. bérlés adatai:");
    Console.Write("\tBérlő neve: ");
    string nev = Console.ReadLine();
    Console.Write("\tKölcsönzött napok (db): ");
    int knsz = int.Parse(Console.ReadLine());
    Console.Write("\tVIP tag (true/false): ");
    bool vip = bool.Parse(Console.ReadLine());
    Console.WriteLine();
    double napdijoszeg = knsz * 12000;
    if (knsz>=7)
    { 
        napdijoszeg = napdijoszeg * 0.85; 
    }
    else if (vip) {
        napdijoszeg = napdijoszeg * 0.85;
    }
    else if (knsz >= 3)
    {
        napdijoszeg = napdijoszeg * 0.95;
    }
    fizetendo.Add(napdijoszeg);
}