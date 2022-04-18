// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
//Class Pizz
class Pizza
{
    public string nom;
    public int prix;
    public List<string> ingredients;

    public Pizza(string nom, int prix, List<string> ingredients)
    {
        this.nom = nom;
        this.prix = prix;
        this.ingredients = ingredients;
    }

    public void AffichagePizza()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(nom+" ( "+String.Join(",", ingredients)+" ) / "+prix+"€");
    }
}
//Class du program
class Program
{
    static void Main(string[] arg)
    {
        string filename = "pizzas.json";
        string url = "https://codeavecjonathan.com/res/pizzas2.json";

       GetPizzasFormFile(filename);
        GetPizzaFormUrl(url);


    }
    //Créer une liste de pizzas
    static void GetPizzaFormCode()
    {

        //creation des pizzas
         var Pizzas = new List<Pizza> {
             new Pizza("La 4 Fromage", 13, new List<string>{"sauce tomate","comte","boursin","gorgonzola","mozzarella","pesto","olive"}),
             new Pizza("L'italienne", 12, new List<string>{"sauce tomate","basilic","boursin","jambon de pays","mozzarella","pesto"}),
             new Pizza("La Reine", 13, new List<string>{"sauce tomate","jambon blanc ","champignons frais de Paris","oeuf","comte"}),
             new Pizza("La Chorizo", 12, new List<string>{"sauce tomate","chorizo","emmental","olives","cheddar"}),
             new Pizza("La Kebab", 13, new List<string>{"sauce tomate","kebab","oignons","potatoes","sauce blanche" })
         };

         foreach (var Pizza in Pizzas)
         {
             Pizza.AffichagePizza();
         }

         
    }
    //recuperer les données d'un fichier json
   static List <Pizza> GetPizzasFormFile(string filename)
    {
        string json = null;
        List<Pizza> pizzaList = new List<Pizza>();
        //recuperation des donnée  pizza et gestion erreur 
        try
        {
            json = File.ReadAllText(filename);

        }
        catch (Exception ex)
        {
            Console.WriteLine("ERREUR nom de fichier : " + filename);
            return null;
            
        }

        try
        {
            pizzaList = JsonConvert.DeserializeObject<List<Pizza>>(json);
            foreach (Pizza pizza in pizzaList)
            {
                pizza.AffichagePizza();
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Le" + filename + " ne contient pas des données en json!! ");
            return null;
            
        }
        return pizzaList;

    }

    //gerenere le fichier les insert dans le fichier 
    static void GenereteJsonFile(List<Pizza> Pizzas, string filename)
    {
        //serealisation des données
        
        string json = JsonConvert.SerializeObject(Pizzas);
        Console.WriteLine(json);
        File.WriteAllText(filename, json);
    }

    //Recuperer des informations depuis Internet
    static List<Pizza> GetPizzaFormUrl(string url)
    {
        var webclient = new WebClient();
        string json = null;
        try
        {
            json = webclient.DownloadString(url);
            Console.WriteLine(json);
        }
        catch(WebException ex)
        {
            if (ex.Response != null)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                if (statusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("ERREUR RESEAU: Non trouvé");
                    return null ;
                }
                else
                {

                    Console.WriteLine("ERREUR RESEAU:" + statusCode);
                    return null;
                }
            }
            else
            {
                Console.WriteLine("ERREUR RESEAU:" + ex.Message);
                return null;
            }
        }
        
        return JsonConvert.DeserializeObject<List<Pizza>>(json);
    }


}
