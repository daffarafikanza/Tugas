using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inheritance_Polymorphsim_Abstraction_Collection.ClassInduk;

namespace Inheritance_Polymorphsim_Abstraction_Collection.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
