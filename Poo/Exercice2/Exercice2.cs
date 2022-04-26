// See https://aka.ms/new-console-template for more information
class Ville
{
    public string nom;
    public string departement;
    public string region;
    public string nombrhabitants;

    public void ville(string nomt, string departementt, string regiont, string nombrehabitans)
    {
        this.nom = nomt;
        this.departement = departementt;
        this.region = regiont;
        this.nombrhabitants = nombrehabitans;
    }
    public void Affiche()
    {
        Console.WriteLine("la ville " + nom + "est dans le département " + departement + " de la région " +
        region + " et a " + nombrhabitants + " habitants");
    }
}
class Exercice2
{
    static void Main(string[] arg)
    {
        Ville ville = new Ville();
        ville.ville("X", "Y", "Z", "N");
        ville.Affiche();
    }
}
