internal class Program
{
    private static void Main(string[] args)
    {
        // Implicit Conversion (Bilinçsiz Dönüşüm)
        Console.WriteLine("***** Implicit Conversion *****");

        byte a = 5;
        sbyte b = 30;
        short c = 10;
        int d = a+b+c;
        Console.WriteLine("d:" + d); // ("d:" + d) bu şekilde yazma sebebi consolda d:35 yazması içindir.
                                     // Console.WriteLine(d) böyle yazsaydı Consolda sadece 35 yazacaktı
        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e= "sıbgatullah";
        char f= 'k';
        object g = e+f+d;
        Console.WriteLine("g:" + g);

        // Explicit Conversion (Biliçli Dönüşüm)
        Console.WriteLine("***** Explicit Conversion *****");

        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y:" + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" + v);

        // ToString Metodu
        Console.WriteLine("***** ToString Metodu *****");

        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" + zz);

        // System.Convert
        Console.WriteLine("***** System.Convert *****");

        string s1 = "10", s2="20";
        int sayı1, sayı2;
        int Toplam;

        sayı1 = Convert.ToInt32(s1);
        sayı2 = Convert.ToInt32(s2);

        Toplam = sayı1 + sayı2;
        Console.WriteLine("Toplam:" + Toplam);

        // Parse Metodu
        Console.WriteLine("***** Parse Metodu *****");
        ParseMetod();


    }
    public static void ParseMetod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);

        Console.WriteLine("rakam1:" + rakam1);
        Console.WriteLine("double1:" + double1); // bunun sonucu yanlış çıktı 1025 yayzdı virgüle çevirince 10,25 yazyor nedenin anlamadım.


    }
        
    
}   