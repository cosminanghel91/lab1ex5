/*
* Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua numere in ordine crescatoare
*/

Console.WriteLine("Introduceti valoarea pentru primul numar:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti valoarea pentru al doilea numar:");
int y = int.Parse(Console.ReadLine());

if (x < y)
{
    Console.WriteLine("Ordonare crescatoare: " + x + " , " + y);
}
else
{
    Console.WriteLine("Ordonare crescatoare: " + y + " , " + x);
}