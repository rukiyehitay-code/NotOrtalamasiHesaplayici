Console.Write("Kaç Ders Girmek İstiyorsunuz: ");
int dersSayisi = Convert.ToInt32(Console.ReadLine());

string[] dersler = new string[dersSayisi];
double[] ortalamalar = new double[dersSayisi];
string[] harfNotlari = new string[dersSayisi];
double toplam = 0;

for (int i =0; i < dersSayisi; i++)
{
    Console.Write($"{i+1}. Dersin Adını Girin: ");
    string dersAdi= Console.ReadLine();
    dersler[i] = dersAdi;

    Console.Write("Vize Notunuzu Girin: ");
    int vizeNotu = Convert.ToInt32(Console.ReadLine());

    Console.Write("Final Notunuzu Girin: ");
    int finalNotu = Convert.ToInt32(Console.ReadLine());

    double ortalama = (vizeNotu * 0.40) + (finalNotu * 0.60);
    ortalamalar[i] = ortalama;

    string harfNotu = "";

    if (ortalama >= 90)
    {
        harfNotu = "AA";
    }
    else if (ortalama >= 85)
    {
        harfNotu = "BA";
    }
    else if (ortalama >= 80)
    {
        harfNotu = "BB";
    }
    else if (ortalama >= 75)
    {
        harfNotu = "CB";
    }
    else if (ortalama >= 70)
    {
        harfNotu = "CC";
    }
    else if (ortalama >= 65)
    {
        harfNotu = "DC";
    }
    else if (ortalama >= 60)
    {
        harfNotu = "DD";
    }
    else
    {
        harfNotu = "FF";
    }
    harfNotlari[i] = harfNotu;
}
for (int i = 0; i < dersSayisi; i++)
{
    toplam = toplam + ortalamalar[i];
}

double gno = toplam / dersSayisi;
Console.WriteLine("Genel Not Ortalamanız: " + gno);

for(int i =0; i < dersSayisi; i++)
{
    Console.WriteLine("Ders : " + dersler[i]);
    Console.WriteLine("Ortalama : " + ortalamalar[i]);
    Console.WriteLine("HarfNotu : " + harfNotlari[i]);

    if (harfNotlari[i] == "FF")
    {
        Console.WriteLine("Kaldınız.");
    }
    else
    {
        Console.WriteLine("Geçtiniz.");
    }
}