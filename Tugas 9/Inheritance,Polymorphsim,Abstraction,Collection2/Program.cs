using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance_Polymorphsim_Abstraction_Collection.ClassAnak;
using Inheritance_Polymorphsim_Abstraction_Collection.ClassInduk;

namespace Inheritance_Polymorphsim_Abstraction_Collection
{
    class Program
    {
         static void Main (string[] args)
        {
            List<Karyawan> karyawan = new List<Karyawan>();

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-456-789";
            karyawanTetap.Nama = "Udin";
            karyawanTetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-012-345";
            karyawanHarian.Nama = "Panji";
            karyawanHarian.JumlahJamKerja = 10;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "123-678-901";
            sales.Nama = "Tommy";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 50000;
         
            Karyawan.Add(karyawanTetap);
            Karyawan.Add(karyawanHarian);
            Karyawan.Add(sales);
        }

         static void Menu(List<Karyawan> karyawan)
         {
             bool status = true;
             do
             {
                 Console.Clear();
                 Console.WriteLine("==============================");
                 Console.WriteLine("\tDATA KARYAWAN");
                 Console.WriteLine("==============================");
                 Console.WriteLine("Silahkan Pilih: ");
                 Console.WriteLine("1. Tambahkan Data");
                 Console.WriteLine("2. Tampilkan Data");
                 Console.WriteLine("3. Hapus Data");
                 Console.WriteLine("4. KELUAR");

             getOption:
                 string opsi;
                 Console.Write("Input Pilihan [1..4]: ");
                 opsi = Console.ReadLine();

                 if (opsi == "1")
                 {
                     InputData(karyawan);
                     Kembali();
                 }
                 else if (opsi == "2")
                 {
                     ReadData(karyawan);
                     Kembali();
                 }
                 else if (opsi == "3")
                 {
                     ReadData(karyawan);
                     DeleteData(karyawan);
                     Kembali();
                 }
                 else if (opsi == "4")
                 {
                     status = false;
                 }
                 else
                 {
                     Console.WriteLine("Pilihan Tidak Sesuai [1..4] !");
                     goto getOption;
                 }

             } while (status);
         }

         static void InputData(List<Karyawan> karyawan)
         {
             Console.Clear();
             Console.WriteLine("==============================");
             Console.WriteLine("\tINPUT KARYAWAN");
             Console.WriteLine("==============================");
             Console.WriteLine("Pilih Jenis Karyawan : ");
             Console.WriteLine("1. Karyawan Tetap");
             Console.WriteLine("2. Karyawan Harian");
             Console.WriteLine("3. Sales");

         getOption:
             string opsi;
             Console.Write("Input Pilihan [1..3]: ");
             opsi = Console.ReadLine();
             Console.WriteLine();

             if (opsi == "1")
             {
                 KaryawanTetap karyawanTetap = new KaryawanTetap();

                 Console.WriteLine("Input Karyawan Tetap");

                 Console.Write("Input Nik \t\t: ");
                 karyawanTetap.Nik = Console.ReadLine();

                 Console.Write("Input Nama \t\t: ");
                 karyawanTetap.Nama = Console.ReadLine();

                 Console.Write("Input Gaji Bulanan \t: ");
                 karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                 karyawan.Add(karyawanTetap);

             }
             else if (opsi == "2")
             {
                 KaryawanHarian karyawanHarian = new KaryawanHarian();
                 Console.WriteLine("Input Karyawan Harian");

                 Console.Write("Input Nik \t\t: ");
                 karyawanHarian.Nik = Console.ReadLine();

                 Console.Write("Input Nama \t\t: ");
                 karyawanHarian.Nama = Console.ReadLine();

                 Console.Write("Input Upah per Jam \t: ");
                 karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());

                 Console.Write("Input Jam Kerja \t: ");
                 karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());

                 karyawan.Add(karyawanHarian);

             }
             else if (opsi == "3")
             {
                 Sales sales = new Sales();
                 Console.WriteLine("Input Karyawan Harian");

                 Console.Write("Input Nik \t\t: ");
                 sales.Nik = Console.ReadLine();

                 Console.Write("Input Nama \t\t: ");
                 sales.Nama = Console.ReadLine();

                 Console.Write("Input Jumlah Penjualan \t: ");
                 sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());

                 Console.Write("Input Komisi \t\t: ");
                 sales.Komisi = Convert.ToDouble(Console.ReadLine());

                 karyawan.Add(sales);
             }
             else
             {
                 Console.WriteLine("Pilihan Tidak Sesuai [1..3] !");
                 goto getOption;
             }
         }

         static void ReadData(List<Karyawan> karyawan)
         {
             Console.Clear();
             Console.WriteLine("==================================================");
             Console.WriteLine(" NO | Nik \t | NAMA\t\t | Gaji\t\t |");
             Console.WriteLine("==================================================");
             for (int i = 0; i < karyawan.Count; i++)
             {
                 Console.WriteLine(" {0}. | {1} \t | {2} \t | {3} \t |", i + 1, karyawan[i].Nik, karyawan[i].Nama, karyawan[i].Gaji());
             }
         }

         static void DeleteData(List<Karyawan> karyawan)
         {
             Console.WriteLine("\n==============================");
             Console.WriteLine("\tHAPUS KARYAWAN");
             Console.WriteLine("==============================");

             bool found = true;
             string Nik;
             Console.Write("Input Nik Karyawan: ");
             Nik = Console.ReadLine();

             for (int i = 0; i < karyawan.Count; i++)
             {
                 if (karyawan[i].Nik == Nik)
                 {
                     karyawan.Remove(karyawan[i]);
                     found = true;
                     break;
                 }
                 else
                 {
                     found = false;
                 }
             }

             if (!found)
             {
                 Console.WriteLine("Data dengan Nik = {0} tidak ditemukan", Nik);
             }
             else
             {
                 Console.WriteLine("Data dengan Nik = {0} berhasil diDelete", Nik);
             }
         }

         static void Kembali()
         {
             Console.WriteLine("\nTekan Sembarang Tombol untuk kembali ke Menu");
             Console.ReadKey();
         }
    }
}