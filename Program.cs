// See https://aka.ms/new-console-template for more information


public class KodeBuah 
{
    Dictionary<string, string> kodeBuah = new Dictionary<string, string>()
    {
        {"Apel" , "A00"},
        {"Aprikot" , "B00"},
        {"Alpukat" , "C00"},
        {"Pisang" , "D00"},
        {"Paprika" , "E00"},
        {"Blackberry" , "F00"},
        {"Ceri" , "H00"},
        {"Kelapa" , "I00"},
        {"Jagung" , "J00"},
        {"Kurma" , "K00"},
        {"Durian" , "L00"},
        {"Anggur" , "M00"},
        {"Melon" , "N00"},
        {"Semangka" , "O00"}
    };
    public string GetKodeBuah(string buah) 
    {
        if (kodeBuah.ContainsKey(buah))
        {
            return kodeBuah[buah];
        }
        else 
        {
            return "Buah tidak ditemukan";
        }
    }
}

public class PosisiKarakterGame
{
    public enum posisi
    {
        Berdiri,
        Tengkurap
    }

    private posisi statusAwal;
    public PosisiKarakterGame()
    { 
        statusAwal = posisi.Berdiri;
    }

    public void PosisiBerdiri() 
    {
        statusAwal = posisi.Berdiri;
        Console.WriteLine("Posisi Standby");
    }

    public void PosisiTengkurap()
    {
        statusAwal = posisi.Tengkurap;
        Console.WriteLine("Posisi Istirahat");
    }
}
class Program
{
    static void Main(string[] args)
    { 
        KodeBuah kodeBuah = new KodeBuah();
        string buah;
        string kdbuah;
        PosisiKarakterGame posisi = new PosisiKarakterGame();

        buah = "Semangka";
        kdbuah = kodeBuah.GetKodeBuah(buah);
        Console.WriteLine($"Buah {buah} memiliki kode {kdbuah}");
        
        buah = "Apel";
        kdbuah = kodeBuah.GetKodeBuah(buah);
        Console.WriteLine($"Buah {buah} memiliki kode {kdbuah}");

        buah = "Anggur";
        kdbuah = kodeBuah.GetKodeBuah(buah);
        Console.WriteLine($"Buah {buah} memiliki kode {kdbuah}");
        
        posisi.PosisiBerdiri();
        posisi.PosisiBerdiri();
        posisi.PosisiBerdiri();
        Console.WriteLine("Posisi Istirahat:");
        posisi.PosisiTengkurap();
        posisi.PosisiTengkurap();
        posisi.PosisiTengkurap();

    }
}
