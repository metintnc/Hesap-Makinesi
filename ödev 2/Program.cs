Console.Write("1.Oyuncunun adı:");
oyuncu bir = new oyuncu(Convert.ToString(Console.ReadLine()));
bir.zarat();

Console.Write("\n2.Oyuncunun adı:");
oyuncu iki = new oyuncu(Convert.ToString(Console.ReadLine()));
iki.zarat();

Console.Write("\n3.Oyuncunun adı:");
oyuncu uc = new oyuncu(Convert.ToString(Console.ReadLine()));
uc.zarat();

Console.Write("\n4.Oyuncunun adı:");
oyuncu dort = new oyuncu(Convert.ToString(Console.ReadLine()));
dort.zarat();

Console.Write("\n5.Oyuncunun adı:");
oyuncu bes = new oyuncu(Convert.ToString(Console.ReadLine()));
bes.zarat();

Console.Write("\n6.Oyuncunun adı:");
oyuncu alti = new oyuncu(Convert.ToString(Console.ReadLine()));
alti.zarat();

Console.Write("\n7.Oyuncunun adı:");
oyuncu yedi = new oyuncu(Convert.ToString(Console.ReadLine()));
yedi.zarat();

Console.WriteLine("\n{0} adlı oyuncunun puanı: {1}",bir.adi,bir.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",iki.adi,iki.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",uc.adi,uc.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",dort.adi,dort.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",bes.adi,bes.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",alti.adi,alti.sonpuan);
Console.WriteLine("{0} adlı oyuncunun puanı: {1}",yedi.adi,yedi.sonpuan);

int[] zarlar = new int[7];
zarlar[0] = bir.sonpuan;
zarlar[1] = iki.sonpuan;
zarlar[2] = uc.sonpuan;
zarlar[3] = dort.sonpuan;
zarlar[4] = bes.sonpuan;
zarlar[5] = alti.sonpuan;
zarlar[6] = yedi.sonpuan;

int kazanan=0;
int ı=0;

for(int i = 0; i < 7; i++)
{
        if (zarlar[i] > kazanan)
        {
            kazanan = zarlar[i];
            ı = i;
        }
}

string[] oyuncular = new string[7];
oyuncular[0] = bir.adi;
oyuncular[1] = iki.adi;
oyuncular[2] = uc.adi;
oyuncular[3] = dort.adi;
oyuncular[4] = bes.adi;
oyuncular[5] = alti.adi;
oyuncular[6] = yedi.adi;

Console.WriteLine("\n{0} puan ile kazanan {1} oluyor.", kazanan, oyuncular[ı]);


public class oyuncu
{
    public string adi;
    public int sonpuan;
    public oyuncu(string adi)
    {
        this.adi = adi;
    }
    public void zarat()
    {
        zar a = new zar(adi);
        a.zarat();
        sonpuan = a.puan;
    }
}

public class zar
{
    public string adi;
    public int puan;
    public zar(string adi)
    {
        this.adi = adi;
        this.puan = 0;
    }

    public void zarat()
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 100);
        Console.Write("{0} zar attı. {1} elde etti. ", adi, sayi);
        
        int bolum = 0;
        puan = sayi;

        for (int i = 2; i * i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                bolum = 1;
            }
        }
        if (bolum == 0 && sayi > 1)
        {
            puan = puan * puan;
            Console.WriteLine("Gelen sayı asal olduğu için karesi kadar puan kazandı.");
        }
        if (sayi % 2 == 0)
        {
            puan = puan / 2;
            Console.WriteLine("Gelen sayı 2'nin katı olduğu için yarısı kadar puan kazandı.");
        }
        if (sayi % 3 == 0)
        {
            puan = puan / 3;
            Console.WriteLine("Gelen sayı 3'ün katı olduğu için 1/3 kadar puan kazandı.");
        }
        Console.WriteLine("Toplam Puanı: {0}", puan);
    }
}