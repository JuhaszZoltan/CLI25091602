public class Barlang
{
    public int Azon { get; set; }
    public string Nev { get; set; }
    public int Hossz { get; set; }
    public int Melyseg { get; set; }
    public string Telepules { get; set; }
    public string Vedettseg { get; set; }

    public override string ToString()
    {
        return $"Név: {Nev}\n" +
            $"Hossz: {Hossz} m\n" +
            $"Mélység: {Melyseg} m\n" +
            $"Település: {Telepules}\n" +
            $"VF: {Vedettseg}";
    }

    public Barlang(string sor)
    {
        var v = sor.Split(';');
        Azon = int.Parse(v[0]);
        Nev = v[1];
        Hossz = int.Parse(v[2]);
        Melyseg = int.Parse(v[3]);
        Telepules = v[4];
        Vedettseg = v[5];
    }
}