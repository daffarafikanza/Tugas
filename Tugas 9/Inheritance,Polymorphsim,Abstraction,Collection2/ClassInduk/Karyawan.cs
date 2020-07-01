using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polymorphsim_Abstraction_Collection.ClassInduk
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}
