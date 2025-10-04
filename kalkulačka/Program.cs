Console.WriteLine("Zadaj prve cislo");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo:");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+, -, *, /, %):");
string operacia = Console.ReadLine();

int vysledok = operacia switch
{
    "+" => (cislo1 + cislo2),
    "*" => (cislo1 * cislo2),
    "/" => (cislo1 / cislo2),
    "%" => (cislo1 % cislo2),
};
Console.WriteLine($"Vysledok je: {vysledok}");
Console.WriteLine("Stlac ENTER pre spustenie kalkulacky");
Console.ReadLine();
System.Environment.Exit(0);








