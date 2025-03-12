namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pilih menu:");
                Console.WriteLine("1. KodeProduk");
                Console.WriteLine("2. DoorMachine");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukkan pilihan Anda: ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HandleKodeProduk();
                        break;
                    //case "2":
                    //    HandleDoorMachine();
                    //    break;
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

        //static void HandleDoorMachine()
        //{
        //    Door myDoor = new Door();
        //    while (true)
        //    {
        //        Console.WriteLine("Masukkan perintah (buka/kunci/tutup/buka kunci/keluar): ");
        //        string command = Console.ReadLine().ToLower();

        //        switch (command)
        //        {
        //            case "buka":
        //                myDoor.Open();
        //                break;
        //            case "tutup":
        //                myDoor.Close();
        //                break;
        //            case "kunci":
        //                myDoor.Lock();
        //                break;
        //            case "buka kunci":
        //                myDoor.Unlock();
        //                break;
        //            case "keluar":
        //                return;
        //            default:
        //                Console.WriteLine("Perintah tidak valid. Silakan coba lagi.");
        //                break;
        //        }

        //        myDoor.ShowState();
        //    }
        //}
    }
}