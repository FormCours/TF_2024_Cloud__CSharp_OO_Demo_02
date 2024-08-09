

using Demo_CSharp_OO_02.Models;

Panier panier = new Panier();

Pomme p1 = new Pomme();
p1.Variete = "Bon père";
p1.Poids = 200;

Pomme p2 = new Pomme();
p2.Variete = "Transparente de Bois-Guillaume";
p2.Poids = 152;

Pomme p3 = new Pomme();
p3.Variete = "Granny Smith";
p3.Poids = 263;


panier = panier + p1;
panier += p2;
panier = p3 + panier;

Console.WriteLine("Liste des pommes du panier");
foreach (Pomme p in panier.Pommes)
{
    Console.WriteLine($" - {p.Variete} ({p.Poids}g)");
}
Console.WriteLine();
Console.WriteLine();


Pomme p4 = new Pomme();
p4.Variete = "Granny Smith";
p4.Poids = 193;

Pomme p5 = new Pomme();
p5.Variete = "Granny Smith";
p5.Poids = 263;

Pomme p6 = new Pomme();
p6.Variete = "Merlijn";
p6.Poids = 263;

Pomme p7 = null;

Console.WriteLine("Test des pommes : ");

bool test1 = (p3 == p4);
Console.WriteLine($"p3 == p4 -> {test1}");

bool test2 = (p3 == p5);
Console.WriteLine($"p3 == p5 -> {test2}");

bool test3 = (p3 == p6);
Console.WriteLine($"p3 == p6 -> {test3}");

bool test4 = (p3 == null);
Console.WriteLine($"p3 == null -> {test4}");

bool test5 = (p7 == null);
Console.WriteLine($"p7(null) == null -> {test5}");

