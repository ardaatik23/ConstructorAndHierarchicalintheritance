using System;

class Çalışan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yaş { get; set; }
    public string Departman { get; set; }

    public Çalışan(string ad, string soyad, int yaş, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Yaş = yaş;
        Departman = departman;
    }

    public void BilgileriGöster()
    {
        Console.WriteLine("Ad: " + Ad);
        Console.WriteLine("Soyad: " + Soyad);
        Console.WriteLine("Yaş: " + Yaş);
        Console.WriteLine("Departman: " + Departman);
    }
}

class İşçi : Çalışan
{
    public İşçi(string ad, string soyad, int yaş, string departman) : base(ad, soyad, yaş, departman)
    {

    }

    public void İşYap()
    {
        Console.WriteLine("İşçi çalışıyor...");
    }
}

class Müdür : Çalışan
{
    public Müdür(string ad, string soyad, int yaş, string departman) : base(ad, soyad, yaş, departman)
    {

    }

    public void ToplantıYap()
    {
        Console.WriteLine("Müdür toplantı yapıyor...");
    }
}

class Yönetici : Çalışan
{
    public Yönetici(string ad, string soyad, int yaş, string departman) : base(ad, soyad, yaş, departman)
    {

    }

    public void PersonelİşlemleriYap()
    {
        Console.WriteLine("Yönetici personel işlemleri yapıyor...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        İşçi işçi = new İşçi("Ahmet", "Yılmaz", 30, "Üretim");
        işçi.BilgileriGöster();
        işçi.İşYap();

        Console.WriteLine();

        Müdür müdür = new Müdür("Ayşe", "Demir", 35, "İnsan Kaynakları");
        müdür.BilgileriGöster();
        müdür.ToplantıYap();

        Console.WriteLine();

        Yönetici yönetici = new Yönetici("Mehmet", "Kara", 40, "Genel Müdür");
        yönetici.BilgileriGöster();
        yönetici.PersonelİşlemleriYap();

        Console.ReadLine();
    }
}