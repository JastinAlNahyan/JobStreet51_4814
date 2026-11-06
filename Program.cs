Console.WriteLine("Masukkan nama pelanggan");
string NamaPelanggan = Console.ReadLine()!;

Console.WriteLine("Masukkan Jumlah Halaman");
int JumlahHalaman = int.Parse(Console.ReadLine()!);

Console.WriteLine("Masukkan Harga Per Halaman");
int HargaPerHalaman = int.Parse(Console.ReadLine()!);

int subtotal = JumlahHalaman * HargaPerHalaman;

Console.WriteLine($"Sub Total = {subtotal}");