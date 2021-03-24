using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Collection.Models;

namespace Collection.Latihan1
{
    class Latihan6
    {
        private List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Latihan6 obj = new Latihan6();
            obj.Run();
        }

        private void Run()
        {
            Console.WriteLine("Aplikasi Registrasi Mahasiswa");
            Console.WriteLine("=============================");

            bool valid = false;
            Student stu;

            while (!valid)
            {
                stu = new Student();

                stu.No = Validation.ReadInputString("\nNomor induk mahasiswa: ", false);

                if (string.IsNullOrEmpty(stu.No))
                {
                    valid = true;
                }
                else
                {
                    stu.Name = Validation.ReadInputString("Nama mahasiswa: ", true);
                    stu.BirthPlace = Validation.ReadInputString("Tempat lahir: ", true);
                    stu.BirthDate = Validation.ReadInputDateTime("Tanggal lahir: ", true, "dd/MM/yyyy");
                    stu.Gender = Validation.ReadInputStringOption("Jenis kelamin [L/P]: ", true, "L", "P");
                    stu.Address = Validation.ReadInputString("Alamat: ", true);
                    stu.TelpNo = Validation.ReadInputInt("Nomor telepon: ", true);
                    stu.Faculty = Validation.ReadInputString("Jurusan: ", true);

                    students.Add(stu);
                }
            }

            if (students.Count() > 0)
                SearchNim();
        }

        public void SearchNim() {

            Console.Clear();
            Console.WriteLine("Cari Nomor induk mahasiswa: ");

            bool valid = false;
            while (!valid)
            {
                string inputan = Validation.ReadInputString("Nomor induk mahasiswa: ", true);
                valid = Tampil(inputan);

                if (!valid)
                {
                    Console.WriteLine("Data tidak di temukan");
                }
            }
        }

        public bool Tampil(string inputan)
        {
            bool valid = false;

            foreach (Student s in students)
            {
                if (s.No.Equals(inputan))
                {
                    Console.WriteLine("\nNomor induk mahasiswa = {0}", s.No);
                    Console.WriteLine("Nama mahasiswa = {0}", s.Name);
                    Console.WriteLine("Tempat lahir = {0}", s.BirthPlace);
                    Console.WriteLine("Tanggal lahir = {0}", s.BirthDate);
                    Console.WriteLine("Jenis kelamin = {0}", s.Gender);
                    Console.WriteLine("Alamat = {0}", s.Address);
                    Console.WriteLine("No telepon = {0}", s.TelpNo);
                    Console.WriteLine("Jurusan = {0}", s.Faculty);

                    valid = true;
                }
            }

            return valid;
        }
    }
}
