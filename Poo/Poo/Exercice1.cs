// See https://aka.ms/new-console-template for more information
class Ville
{
   public string nom;
    public string departement;
    public string region;
    public string nombrhabitants ;

    public void Affiche()
    {
        Console.WriteLine("la ville " + nom + "est dans le département " + departement + " de la région " +
        region + " et a " + nombrhabitants + " habitants");
    }

    
}
class Exercice1
{
    static void Main(string[]arg)
    {
        Ville ville = new Ville();
        ville.nom = "X";
        ville.departement = "Y";
        ville.region = "Z";
        ville.nombrhabitants = "N";
        ville.Affiche();

    }
}
