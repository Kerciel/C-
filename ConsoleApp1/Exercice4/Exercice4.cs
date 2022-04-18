// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saisir un nombre :");
string nb = Console.ReadLine();
int nombre = int.Parse(nb);
int i = 0;
/*
while (i < 10 )
    {
    i++;
    Console.WriteLine(nombre +"X"+ i +"="+ (nombre*i));
}*/
/*
do
{
    i++;
    Console.WriteLine(nombre + "X" + i + "=" + (nombre * i));
}
while (i < 10);*/

for(int z = 1; z < 11; z++)
{
    
    Console.WriteLine(nombre + "X" + z + "=" + (nombre * z));
}