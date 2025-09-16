using System.Text;

const string file = "..\\..\\..\\resources\\barlangok.txt";

List<Barlang> barlangok = [];

using StreamReader sr = new(file, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"barlangok szama: {barlangok.Count}");

var magvm = barlangok
    .Where(x => x.Telepules.StartsWith("Miskolc"))
    .Average(x => x.Melyseg);
Console.WriteLine($"miskolci avg melyseg: {magvm:0.000} m");

Console.Write("írjad be: ");
string kvsz = Console.ReadLine();
var lhb = barlangok
    .Where(b => b.Vedettseg == kvsz)
    .MaxBy(b => b.Hossz);
if (lhb is null) Console.WriteLine("nincs ilyen vsz");
else Console.WriteLine(lhb);

Console.WriteLine("statisztika:");
var stat = barlangok.GroupBy(b => b.Vedettseg);
foreach (var grp in stat)
    Console.WriteLine($"\t{grp.Key} {grp.Count()} db");

