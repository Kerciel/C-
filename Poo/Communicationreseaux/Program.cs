// See https://aka.ms/new-console-template for more information
using System.Net;

class Program
{
    static void Main(string [] arg)
    {
        string url = "https://codeavecjonathan.com/res/pizzas1.json";
        string urlpapillon = "https://codeavecjonathan.com/res/papillon.jpg";
        
        Console.WriteLine("Accées au reseaux...");
        var webclient = new WebClient();
        //recuperer le contenu d'un fichier avec WebClient: 
        try
        {
            string reponse = webclient.DownloadString(url);
            Console.WriteLine(reponse);
        }
        catch (WebException ex) 
        {
            if(ex.Response != null)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                if (statusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("ERREUR RESEAU: Non trouvé");
                }
                else
                {

                    Console.WriteLine("ERREUR RESEAU:" + statusCode);
                }
            }
            else
            {
                Console.WriteLine("ERREUR RESEAU:" + ex.Message);
            }
            
            
        }
        Console.WriteLine("Lancement du telechargement...");
        //telecharger un fichier
        try
        {
             webclient.DownloadFile(urlpapillon, "papillon.jpg");
            Console.WriteLine("telechargement terminé");
        }
        catch (WebException ex)
        {
            if (ex.Response != null)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                if (statusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("ERREUR RESEAU: Non trouvé");
                }
                else
                {

                    Console.WriteLine("ERREUR RESEAU:" + statusCode);
                }
            }
            else
            {
                Console.WriteLine("ERREUR RESEAU:" + ex.Message);
            }


        }

    }
}
