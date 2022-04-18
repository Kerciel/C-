// See https://aka.ms/new-console-template for more information
String [,] tableaunombre = 
{
    {"0","1","2" },
    { "3","4","5"},
    { "6","7","8"}
};
Console.WriteLine("Bienvenu dans le jeu de morpion:");
string nombreutilisateur = "";
Random r = new Random();
bool resultat = false;
int nombre = 0;
while (true)
{
     //AFFICHAGE DU MORPION
    for (int i = 0; i < tableaunombre.GetLength(0); i++)
    {
        Console.Write("***********\n");
        for (int j = 0; j < tableaunombre.GetLength(1); j++)
        {

            Console.Write("|" + tableaunombre[i, j] + "|");
        }
        Console.Write("\n");
    }
    if (resultat)
    {
        Console.WriteLine("*************************Felicitation!!!!!!Vous avez gagner!!!*********************");
        break;
    }
    else if (nombre == 9)
    {
        Console.WriteLine("*************************Desole!!!!!Vous avez perdu!!!********"+nombre+"*************");
        break;
    }
    else
    {
        //SAISIE DE L UTILISATEUR 
        Console.WriteLine("Saisir le numero de la case:");
        nombreutilisateur = Console.ReadLine();
        for (int i = 0; i < tableaunombre.GetLength(0); i++)
        {

            for (int j = 0; j < tableaunombre.GetLength(1); j++)
            {

                if (tableaunombre[i, j] == nombreutilisateur)
                {
                    tableaunombre[i, j] = "X";

                }
            }

        }
        //PARTIE DE L ORDINATEUR
        int ordianateur = r.Next(0, 10);
        string nombreordinateur = "" + ordianateur;


        for (int i = 0; i < tableaunombre.GetLength(0); i++)
        {

            for (int j = 0; j < tableaunombre.GetLength(1); j++)
            {

                if (tableaunombre[i, j] == nombreordinateur)
                {
                    tableaunombre[i, j] = "O";

                }
                else
                {
                    ordianateur = r.Next(0, 10);
                    nombreordinateur = "" + ordianateur;

                }


            }


        }
        //VERIFICATION SI L UTILISATEUR A REUSSI
        for (int i = 0; i < tableaunombre.GetLength(0); i++)
        {
            for (int j = 0; j < tableaunombre.GetLength(1); j++)
            {

                if (tableaunombre[i, 0] == "X" && tableaunombre[i, 1] == "X" && tableaunombre[i, 2] == "X")
                {

                    resultat = true;

                }

                else if (tableaunombre[0,i ] == "X" && tableaunombre[1, i] == "X" && tableaunombre[2, i] == "X")
                {

                    resultat = true;

                }
                else if (tableaunombre[0, 0] == "X" && tableaunombre[1, 1] == "X" && tableaunombre[2, 2] == "X")
                {

                    resultat = true;

                }
                else if (tableaunombre[0,2 ] == "X" && tableaunombre[1, 1] == "X" && tableaunombre[2, 0] == "X")
                {

                    resultat = true;

                }
      
            }

        }
    }

   
}
