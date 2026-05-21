//Arlando A'la Putra Raharjo_2059_D_UTSPBO_D
namespace OOPFood;
//Soal 5 Abstraction 
abstract class PesananMakanan
{
    //Soal 1 Encapsulation 
    private string namaPemesan { get; set; }
    private int nomorMeja { get; set; }
    private string menuUtama { get; set; }

    public PesananMakanan(string namapemesan, int nomormeja, string menuutama)
    {
        namaPemesan = namapemesan;
        nomorMeja = nomormeja;
        menuUtama = menuutama;   
    } 
        
    public void tampilInfo()
    {
        Console.WriteLine($"Pemesan: {namaPemesan} | Meja : {nomorMeja} | Menu : {menuUtama}");
    }

    //Soal 3 Polymorphism
    public abstract void hitungTotalBill();

}

//Soal 2 Inheritance
class PaketHemat : PesananMakanan
{   
    public int biayaPerPorsi { get; set; }
    public int jumlahPorsi { get; set; }

    public PaketHemat(int biayaPerPorsi, int jumlahPorsi )
    {
        this.biayaPerPorsi = biayaPerPorsi;
        this.jumlahPorsi = jumlahPorsi;
    }

    public override void hitungTotalBill()
    {
        Console.WriteLine($"Total Bill : {jumlahPorsi * biayaPerPorsi} ");
    }
}

class PaketPrasmanan : PesananMakanan
{
    public int biayaPerPorsi { get; set; }
    public int jumlahPorsi { get; set; }
    public int biayaService { get; set; }

    public PaketPrasmanan(int biayaperporsi, int biayaservice, int jumlahporsi)
    {
        biayaPerPorsi = biayaperporsi;
        biayaService = biayaservice;
        jumlahPorsi = jumlahporsi;
    }

    public override void hitungTotalBill()
    {
        Console.WriteLine($"Paket Prasmanan : {(jumlahPorsi * biayaPerPorsi) + biayaService} ");
    }

}


class RiwayatPesanan : PesananMakanan
{
    public string kategoriPaket { get; set; }
    public void tambahPesanan()
    {
        Console.WriteLine($"");
    }
}
