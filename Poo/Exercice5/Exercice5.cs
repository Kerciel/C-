
class Personne
{
    public string nom;
    public string prenom;

    public void personne(string n, string p)
    {
        this.nom = n;
        this.prenom = p;
    }
}
class Client:Personne
{
    public string adresse;

    public void GetCoodonees()
    {
        Console.WriteLine("Nom:"+this.nom);
        Console.WriteLine("Prenom:" + this.prenom);
        Console.WriteLine("Adresse:" + this.adresse);
    }
}
class Electeur:Client
{
    public string  bureauvote;
    public bool vote = false;
    public void Setvote()
    {
        vote = true;
    }
    public void isvote()
    {
        if (vote)
        {
            Console.WriteLine("Il a voté , au bureau de"+bureauvote);
        }
        else
        {
            Console.WriteLine("Il a pas voté.");
        }
    }
}

class Exercice5
{
   static void Main(string[]arg)
    {
        Electeur electeur = new Electeur();
        electeur.personne("fazul", "abdou");
        electeur.GetCoodonees();
        electeur.isvote();
        electeur.Setvote();
        electeur.isvote();


    }
}