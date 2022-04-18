// See https://aka.ms/new-console-template for more information
var rand = new Random();
int nombrerechercher = rand.Next(1, 10);
int i = 0;
int essai = 3;
Console.WriteLine("Trouver le nombre magique:\n");
while (i < 3)
{
    
    Console.WriteLine("vous avez" +essai+ "  essai!\n");
    Console.WriteLine("saisir le nombre:\n");
    string nb = Console.ReadLine();
    int nombre = int.Parse(nb);
    if(nombrerechercher > nombre && essai != 0)
    {
        Console.WriteLine("le nombre magique  est plus grand!!!\n");
        i++;
        essai = essai - 1;
    }
    else if(nombrerechercher < nombre && essai != 0)
    {
        Console.WriteLine("le nombre magique  est plus petit!!!\n");
        i++;
        essai = essai - 1;
    }
    else if (nombrerechercher == nombre && essai != 0)
    {
        Console.WriteLine("BRAVO!!! Vous avez trouver le nombre magique!!!!!!\n");
        i = 3;

    }
    
    
    if (essai == 0)
    {
        Console.WriteLine("PERDU!!! Vous avez PERDU!!!!!!\n");
        i = 3;
    }
    
    


}
