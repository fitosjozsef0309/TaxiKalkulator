Console.WriteLine("Kérem a nevet: ");
string Nev = Console.ReadLine();

Console.WriteLine("Kérem a megtett távot (km): ");
double Tav = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Északai volt(igen=1/nem=0): ");
int Eszaka = Convert.ToInt32(Console.ReadLine());

double Alapdij = 1100;

double kilometerdij = 400;

double Eszakaidij = 1.20;

var eszakai = false;

double Fizetendo = Alapdij + (Tav * kilometerdij) ;

if (Eszaka == 1)
{
    eszakai = true;
}

if (eszakai==true)
{
    Fizetendo *= Eszakaidij;
};


Console.WriteLine($"A fizetendő összeg: {Fizetendo} Ft");