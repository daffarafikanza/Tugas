using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance_Polymorphsim_Abstraction_Collection.ClassInduk;

namespace Inheritance_Polymorphsim_Abstraction_Collection.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}