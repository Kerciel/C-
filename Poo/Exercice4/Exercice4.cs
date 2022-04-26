// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
class Vehicule
{
    private string type = "Voiture";
    private int places = 4;

    public void vehicule()
    {

    }
    public string Gettype()
    {
        return type;
    }
    public int Getplaces()
    {
        return places;
    }
    public void Settype(string value)
    {
        type = value;
    }
    public void Setplaces(int value)
    {
        places = value;
    }


}

class Voiture:Vehicule
{
    string marque ;
  int volumecarburant ;

    public void etatcarbutant()
    {
        if(this.volumecarburant == 0)
        {
            Console.WriteLine("il n'y a plus de carburants.");
        }
        else
        {
            Console.WriteLine("Vous avez encoez du carburant.");
        }
    }
}
class Exercice3
{
    static void Main(string[] arg)
    {
        Vehicule vehicule = new Vehicule();
        Console.WriteLine("Type :" + vehicule.Gettype());
        Console.WriteLine("Nombre de place:" + vehicule.Getplaces());
        vehicule.Settype("Camion");
        vehicule.Setplaces(3);
        Console.WriteLine("Type :" + vehicule.Gettype());
        Console.WriteLine("Nombre de place:" + vehicule.Getplaces());
        Voiture voiture = new Voiture();
        voiture.etatcarbutant();
    }
}

