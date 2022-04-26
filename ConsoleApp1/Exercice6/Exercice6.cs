// See https://aka.ms/new-console-template for more information
static string  inverse(float nombre )
{
     string resultat;
    if (nombre != 0)
    {
        float rnombre = 1 / nombre;
        resultat = "l'inverce de" + nombre +" c'est " + rnombre;
        
    }
    else
    {
         resultat = "On ne peut pas diviser un nombre par 0!";
    }
    return resultat;
}

Console.WriteLine(inverse(10));
Console.WriteLine(inverse(0));
Console.WriteLine(inverse(20));
