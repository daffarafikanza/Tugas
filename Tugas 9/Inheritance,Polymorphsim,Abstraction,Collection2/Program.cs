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
         
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
           
            int noUrut = 1;
            
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:NO}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}