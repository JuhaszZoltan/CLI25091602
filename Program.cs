using System.Text;

const string file = "..\\..\\..\\resources\\barlangok.txt";

List<Barlang> barlangok = [];

using StreamReader sr = new(file, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"barlangok szama: {barlangok.Count}");

var mavg = barlangok
    .Where(b => b.Telepules.StartsWith("Miskolc"))
    .Average(b => b.Melyseg);
Console.WriteLine($"miskolci atlag melyseg: {mavg:0.000} m");

Console.Write("írd be a vf-et: ");
var kervsz = Console.ReadLine();
var lhvszb = barlangok
    .Where(b => b.Vedettseg == kervsz)
    .MaxBy(b => b.Hossz);
if (lhvszb is null) Console.WriteLine("nincs ilyen");
else Console.WriteLine(lhvszb);
