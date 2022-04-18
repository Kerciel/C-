// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Text.Json;
class Personne
{
    public string nom;
    public int age;

    public Personne(string nom, int age)
    {
        this.nom = nom;
        this.age = age;
    }
    public void Affichage()
    {
        Console.WriteLine("Nom:"+nom+" - "+"Age:"+age+"ans");
    }
}

class Program
{
    static void Main(string[]arg)
    {
        Personne person = new Personne("fazul", 21);
        person.nom = "fazul";
        person.age = 21;
        person.Affichage();

        //serialition
        string filename = "person.json";
        string json = JsonConvert.SerializeObject(person);
        File.WriteAllText(filename, json);
        Console.WriteLine(File.ReadAllText(filename));

        //Deserialisation
        string jsontiti = "{\"nom\":\"TITI\",\"age\":49}";
        Personne persontiti = JsonConvert.DeserializeObject<Personne>(jsontiti);
        persontiti.Affichage();

        //creation d'une liste de personne (3 personnes):
        var PERSONNE = new List<Personne> {
            new Personne("Bertrand",34),
            new Personne("Daniel", 14),
            new Personne("Math", 9)
        };
        //Serealise la liste :
        string filenameLISTE = "personnes.txt";
        string jsonlist = JsonConvert.SerializeObject(PERSONNE);
        File.WriteAllText(filenameLISTE, jsonlist);
        Console.WriteLine(File.ReadAllText(filenameLISTE));

        //lire le fichier créer :
        string readtext =  File.ReadAllText(filenameLISTE);

        //Deserialise pour créer la liste de nos personnes:
        List<Personne> list = JsonConvert.DeserializeObject<List<Personne>>(readtext);

        foreach (Personne perso in list)
        {
            perso.Affichage();
        }

    }
}
