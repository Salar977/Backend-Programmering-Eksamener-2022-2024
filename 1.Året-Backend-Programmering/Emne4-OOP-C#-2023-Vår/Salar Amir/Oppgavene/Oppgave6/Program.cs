using System.Diagnostics;
using System.Threading.Channels;
using Oppgave6;

const string csvFile = "Products.csv";

;
var products = ProductService.ReadProductsFromCsv(csvFile);


Console.WriteLine("\nOppgave 6C");
Console.WriteLine("1)\n");

var produkterMedQuantityMindreEnn20 = products.Where(q => q.Quantity < 20);

foreach(var produkt in produkterMedQuantityMindreEnn20)
    Console.WriteLine(produkt);

Console.WriteLine("\nOppgave 6C");
Console.WriteLine("2)\n");
    
var produkterMedPrisMindreEnn20 = products.Where(p => p.Price < 20);

foreach(var produkt in produkterMedPrisMindreEnn20)
    Console.WriteLine(produkt);

Console.WriteLine("\nOppgave 6C");
Console.WriteLine("3)\n");
    
var produktMedProduktnavnSomStarterMedS = products.Where(n => n.Name.StartsWith("S"));

foreach(var produkt in produktMedProduktnavnSomStarterMedS)
    Console.WriteLine(produkt);