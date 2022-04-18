// See https://aka.ms/new-console-template for more information
using Projet3;
using System;
using System.Collections.Generic;
;
Console.WriteLine("*********************************Jeu du PENDU*****************************************************");
//affiche le mot en majuscule
static bool AfficherMot(string mot, List <char> lettre)
{
    string[] valeur = new string [mot.Length];

    string vide = " _ ";
    bool v = false;
    
    //creation du mot à rechercher 
    for(int i = 0; i < valeur.Length; i++)
    {
        valeur[i] = vide;
    }
        for (int i = 0; i < mot.Length; i++)
        {
            char c = mot[i];

        
        for (int j = 0; j < lettre.Count; j++)
        {
            if (c == lettre[j] && valeur[i] == " _ " )
            {
                valeur[i] = ""+ mot[i]+"";

                
            }
            
           
           
        }
       




        }

    string dernier = "";
    //verification de la lettre entrer par l'utilisateur 
    for (int j = 0; j < lettre.Count; j++)
    {
        dernier = ""+lettre[lettre.Count - 1];
        for (int i = 0; i < valeur.Length; i++)
        {

            if (valeur[i] == dernier)
            {
                v = true;
                break;
            }
            else 
            {
                v = false;
            }


        }
    }

    ///affichage du mot
    for (int i = 0; i < valeur.Length; i++)
    {
        Console.Write(valeur[i]);
           
            
        
    }
    Console.Write("\n");
    return v;
}
//AfficherMot("BONJOUR",new List <char>{'O'});

//Demande à l'utilisateur de rentrer une lettre
static string DemanderUneLettre()
{
    string valeur;
    while (true)
    {
       
        Console.Write("Entrer une lettre:");
         valeur =  Console.ReadLine();
        if (valeur.Length < 2 && valeur != "")
        {
            break;
        }
        else if (valeur.Length >1)
        {
            Console.WriteLine("Erreur vous ne pouvez pas entrer plus d'une seule lettre!!!!");
        }
        else if (valeur == "")
        {
            Console.WriteLine("Erreur vous n'avez pas rentrer de lettre!!!!");
        }
    }
    return valeur.ToUpper() ;
}

/*string lettre = DemanderUneLettre();
Console.WriteLine (lettre);
*/
static int DevinerMot(string mot)
{
    int i = 0;
    List<char> lette = new List<char> {};
    int essais = 7;
    bool gagner = false;
    string verification = mot;
    List<string > lette2 = new List<string>();
    string exlus ;
    char valeur = ':';
    string dernier;
    while (true) {

        //limite de nombre d'essais
        bool resultat = AfficherMot(mot, lette);
        Console.Write("Le mot ne contient pas les lettres:");
        if (!resultat && essais != 0)
        {

            
            
            essais += - 1;
            //affiche les lettres qui ne font pas partie du mot 
            dernier = "" + valeur;
            exlus = string.Join("|",dernier);
            lette2.Add(exlus);
            
           
           
           
        }
        foreach (string c in lette2)
        {
            if (c != ":")
            {
                Console.Write(c + ",");
            }
        }
        Console.Write("\n");
        AsciiArt.pendu(essais);
        Console.WriteLine("Nombre de vie : " + essais);
        if (essais == 0)
        {
            Console.WriteLine("Perdu le mot était : "+mot+"!!!!");
            break;
        }
        /////////////////////////
        gagner = ToutesLettresDevinees(mot, lette);
        if(gagner)
        {
            Console.WriteLine(" BRAVO!!!! Vous avez trouvez le mot!!!!");
            AsciiArt.gagner();
            break;
        }


        valeur = char.Parse(DemanderUneLettre());
       
            
        lette.Add(valeur);
            
        
            
        i++;

        

    }
    return i;

}
//Cette fonction retourne true si toutes les lettres ont été trouvées ->gagné
static bool ToutesLettresDevinees(string mot,List<char> lettres)
{
    string vide = mot;

    string after = mot;


    
       
        for (int i = 0; i < mot.Length; i++)
        {

                char c = mot[i];

            for (int j = 0; j < lettres.Count; j++)
            { 
                
                if (c == lettres[j] )
                    {
                    after = after.Replace(lettres[j], '_');
                        break   ;

                    }

            }
       
        }





    if (after == "_______")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string[] chargerLesMots(string nomFichier)
{
    string[] readText =  new string [12];

    try
    {

        readText = File.ReadAllLines(nomFichier);
        
    }
    catch (Exception e)
    {
        Console.WriteLine("le fichie "+ e.Message+" n'existe pas.");
    }
    
        return readText;  
}

while (true)
{
    string[] MOT = chargerLesMots("mots.txt");
    Random rand = new Random();
    int nombre = rand.Next(MOT.Length);
    DevinerMot(MOT[nombre]);
    Console.WriteLine("Voulez vous rejouer ?(o/n)");
    string jouer = Console.ReadLine();
    if (jouer == "n")
    {
        Console.WriteLine("Vous avez quitter le jeu.Fin du jeu.");
        break;
    }
}