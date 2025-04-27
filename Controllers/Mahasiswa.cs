using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul10_103022300030.Controllers
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            Nim = nim;
        }
    }
}
