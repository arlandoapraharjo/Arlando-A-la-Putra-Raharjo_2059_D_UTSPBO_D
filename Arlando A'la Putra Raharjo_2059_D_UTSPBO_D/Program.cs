using OOPFood;

PaketHemat pesanan1 = new PaketHemat("Robby", 20, "Ayam Bakar", 20000, 2);
RiwayatPesanan riwayatPesanan1 = new RiwayatPesanan(pesanan1, "Paket Hemat", 2, "2024-06-01");
riwayatPesanan1.cetakRiwayat();

PaketPrasmanan prasmanan1 = new PaketPrasmanan("Anya", 10, "Gurami Bakar", 30000, 15000, 2);
RiwayatPesanan riwayatpesanan2 = new RiwayatPesanan(prasmanan1, "Paket Prasmanan", 2, "2026-07-21");
riwayatpesanan2.cetakRiwayat();