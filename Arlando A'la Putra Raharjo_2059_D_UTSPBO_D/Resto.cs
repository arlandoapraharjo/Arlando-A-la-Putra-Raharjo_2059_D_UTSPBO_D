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

    public PaketHemat(string namapemesan, int nomormeja, string menuutama, int biayaPerPorsi, int jumlahPorsi ) : base(namapemesan, nomormeja, menuutama)
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

    public PaketPrasmanan( string namapemesan, int nomormeja, string menuutama, int biayaperporsi, int biayaservice, int jumlahporsi) : base (namapemesan, nomormeja, menuutama)
    {
        biayaPerPorsi = biayaperporsi;
        biayaService = biayaservice;
        jumlahPorsi = jumlahporsi;
    }

    public override void hitungTotalBill()
    {

        Console.WriteLine($"Total Bill : {(jumlahPorsi * biayaPerPorsi) + biayaService} ");
    }

}


class RiwayatPesanan
{
    public PesananMakanan Pesanan { get; set; }
    public string KategoriPaket { get; set; }
    public int JumlahPorsi { get; set; }
    public string TanggalPesan { get; set; }

    public RiwayatPesanan(PesananMakanan pesanan, string kategoriPaket, int jumlahPorsi, string tanggalPesan)
    {
        Pesanan = pesanan;
        KategoriPaket = kategoriPaket;
        JumlahPorsi = jumlahPorsi;
        TanggalPesan = tanggalPesan;
    }

    public void tambahPesanan()
    {
        Console.WriteLine($"Pesanan berhasil ditambahkan!");
    }

    public void cetakRiwayat()
    {
        Pesanan.tampilInfo();
        Pesanan.hitungTotalBill();

        Console.WriteLine($"1. {KategoriPaket} | {JumlahPorsi} porsi | {TanggalPesan} "); 
    }
}
