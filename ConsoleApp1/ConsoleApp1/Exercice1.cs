// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//exercuce 1*****************************************************
Console.WriteLine("saisir votre nom!");
string nomutilisateur = Console.ReadLine();
Console.WriteLine("saisir votre prenom!");
string prenomutilisateur = Console.ReadLine();
Console.WriteLine("saisir votre age!");
string nb = Console.ReadLine();
int ageutilisateur = int.Parse(nb);
Console.WriteLine("Etes vous une femme ou  homme ?");
string sexutilisateur = Console.ReadLine();

Console.WriteLine("Nom:" + nomutilisateur);
Console.WriteLine("Prenom : " + prenomutilisateur);
Console.WriteLine("Age : " + ageutilisateur + " ans");
Console.WriteLine("Sexe : " + sexutilisateur);