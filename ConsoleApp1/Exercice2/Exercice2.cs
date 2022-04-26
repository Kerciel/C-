// See https://aka.ms/new-console-template for more information
int maVariable1 = 15;
int maVariable2 = 20;
int intermedierre = maVariable1;
Console.WriteLine("Avant maVariable1 = " + maVariable1 + " et maVariable2= " + maVariable2);
maVariable1 = maVariable2;
maVariable2 = intermedierre;
Console.WriteLine("Avant maVariable1 = " + maVariable1 + " et maVariable2= " + maVariable2);