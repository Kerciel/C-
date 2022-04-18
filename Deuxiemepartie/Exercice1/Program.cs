// See https://aka.ms/new-console-template for more information

string[] nomtableau = { "jean", "Paul", "pierre", "Lydia", "Ruth", "Esther" };
List<string> nomtables = nomtableau.ToList();

nomtables.Insert(1, "marie");
nomtables.Remove("Esther");
nomtables.Insert(0, "Esther");
nomtables.Add("jaque");
nomtables.Sort();
foreach (string nomTable in nomtables)
{
    Console.WriteLine(nomTable);
}