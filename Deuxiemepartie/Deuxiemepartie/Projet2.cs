// See https://aka.ms/new-console-template for more information
using Deuxiemepartie;

Console.WriteLine("saisir le nombre de caractere pour le mot de passe:");
string nb = Console.ReadLine();
Console.WriteLine("saisir 1 si vous voulez un mot de passe en majuscule sinon 0:");
string c=Console.ReadLine();
int caractere = int.Parse(nb);
int majus = int.Parse(c);
string password = Class1.password(caractere, majus);
Console.WriteLine("votre mot de passe c'est:"+password);