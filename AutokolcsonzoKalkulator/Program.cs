double atlag = 0;
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
    atlag = atlag + knsz;
}
double naptelj = 0;
for (int i = 0; i < 4; i++)
{
    naptelj = naptelj + fizetendo[i];
}
atlag = naptelj / 4;
Console.WriteLine($"Napi teljes bevétel: {naptelj} Ft");
Console.WriteLine($"Átlagos kölcsönzési díj: {atlag} Ft");
string ertekeles = "";
if (naptelj >= 200000)
{
    ertekeles = "Kiemelkedő forgalmú nap!";
}
else if (naptelj >= 100000)
{
    ertekeles = "Átlagos forgalmú nap.";
}
else
{
    ertekeles = "Gyenge forgalmú nap.";
}
Console.WriteLine($"Napi értékelés: {atlag} Ft");