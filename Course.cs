using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate.Models
{
    class Course
    {
        public string nama;
        public double nilai;

        // constructor
        public Course(string nama, double nilai)
        {
            this.nama = nama;
            this.nilai = nilai;
        }
    }
}
