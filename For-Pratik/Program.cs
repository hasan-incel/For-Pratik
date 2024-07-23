// Konsol Ekranına 10 kere Console.Writeline'da ki metini yazdırıyorum.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum,ben bu yazılım işini hallederim!");

}

Console.WriteLine(); // Boşluk

// 1 ile 20 arasındaki sayıları konsol ekranına yazdırıyorum
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine(); // Boşluk

// 1 ile 20 arasındaki çift sayıları konsola yazdırıyorum.
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine(); // Boşluk

// 50 ile 150 arasındaki sayıların toplamını konsola yazdırıyorum.
int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

Console.WriteLine(); // Boşluk

// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı konsola yazdırdım.
int tek = 0;
int cift = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        cift += i;
    }
    else
    {
        tek += i;
    }
}
//tek ve çift sayılar toplamını konsola yazdırıyorum.
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tek);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + cift);
