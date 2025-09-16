using System.Text;

const string file = "..\\..\\..\\resources\\barlangok.txt";

List<Barlang> barlangok = [];

using StreamReader sr = new(file, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"barlangok szama: {barlangok.Count}");s
