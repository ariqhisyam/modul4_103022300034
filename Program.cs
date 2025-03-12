namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pilih menu:");
                Console.WriteLine("1. Kode Produk");
                Console.WriteLine("2. Fan Laptop");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HandleKodeProduk();
                        break;
                    case "2":
                        HandleFanLaptop();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void HandleKodeProduk()
        {
            KodeProduk kodePos = new KodeProduk();
            Console.Write("Masukkan nama produk: ");
            string kodeproduk = Console.ReadLine();
            string kode = kodePos.GetKodeProduk(kodeproduk);
            Console.WriteLine($"Kode produk untuk {kodeproduk} adalah {kode}");
        }

        static void HandleFanLaptop()
        {
            Fan myFan = new Fan();
            while (true)
            {
                Console.WriteLine("Masukkan perintah (quiet/balanced/performance/turbo): ");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "quiet":
                        myFan.Quiet();
                        break;
                    case "balanced":
                        myFan.Balanced();
                        break;
                    case "performance":
                        myFan.Performance();
                        break;
                    case "turbo":
                        myFan.Turbo();
                        break;
                    case "keluar":
                        return;
                    default:
                        Console.WriteLine("Perintah tidak valid. Silakan coba lagi.");
                        break;
                }

                myFan.ShowState();
            }
        }
    }
}