// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saisir votre age:");
string nb = Console.ReadLine();
int age = int.Parse(nb);
if(age < 18 && age >= 11)
{
    Console.WriteLine("Vous etes un adolecent!");

}
else if(age >= 18)
{
    Console.WriteLine("Vous etes un adulte!");
}
else
{
    Console.WriteLine("Vous etes un enfant!");
}