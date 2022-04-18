// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using Newtonsoft.Json;
public class Crepe
{
    public  string nom ;
     public int prix;
     public bool sucre;
    public List<string> ingres = new List<string>();

    public  Crepe(string nom, int prix, bool sucre, List<string> ingres)
    {
        
        this.nom = this.FormatAffichage(nom);
        this.prix = prix;
        this.sucre = sucre;
        for (int i = 0; i < ingres.Count; i++)
        {
            this.ingres.Add(FormatAffichage(ingres[i]));
        }
        

    }
    public  string FormatAffichage(string n)
    {
        

        string valeur = "";
        try
        {
            

                for (int i = 0; i < n.Length; i++)
                {
                    if (i == 0)
                    {
                        valeur += n[i].ToString().ToUpper();

                    }
                    else
                    {
                        valeur += n[i].ToString().ToLower();
                    }




                }
            
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Une valeur n'a pas été definie!");
        }
        return valeur;
    }
    public void Affichage()
    {
        string suc;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        if (sucre) { suc = "(sucrés)"; } else { suc = " (non sucrés)"; }
        Console.WriteLine(nom + suc +"-   "+ prix+"€");
        Console.WriteLine(String.Join(",", ingres));
       
    }

}

class Program
{
    static void Main(string[] arg)
    {

        var ingreident = new List<string> { "farine", "oeuf", "lait", "beure", "sucre vanillé" };



        var CREPE = new List<Crepe> {
        new Crepe("crepe-nutella", 9,true, ingreident),
        new Crepe("crepe-vanille", 20, false, ingreident),
        new Crepe("crepe-coco", 4, false, ingreident),
        };

        List<Crepe> CREPE2 = CREPE.OrderBy(c => c.prix).ToList();

        foreach (Crepe c in CREPE)
        {

            c.Affichage();
        }

        Console.WriteLine("********************************Les crepes ranger par leurs prix:");
        //ranger par du plus petit prix au plus grand 
        foreach (Crepe c2 in CREPE2)
        {
            c2.Affichage();
        }
        Console.WriteLine("****************************************Les crepes Salée:");
        foreach (Crepe c in CREPE)
        {
            if (c.sucre == false)
            {

                c.Affichage();
            }


        }
        //serealisation
        Console.WriteLine("****************************************Serealisation:");
        string fileName = "Crepe.json";
        
        //serialition 
        string json = JsonConvert.SerializeObject(CREPE2);
        File.WriteAllText(fileName, json);
        Console.WriteLine(File.ReadAllText(fileName));
        //Desrerialise
        string readText = "{ \"nom\":\"Crepe-coco\",\"prix\":4,\"sucre\":false,\"ingres\":[\"Farine\",\"Oeuf\",\"Lait\",\"Beure\",\"Sucre vanillé\"]}";
        
       List <Crepe> CREPE3 =  JsonConvert.DeserializeObject<List<Crepe>>(File.ReadAllText(fileName));
        
       foreach (Crepe c in CREPE3)
        {
            c.Affichage();
        }



    }
}
