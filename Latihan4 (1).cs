using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Collection.Models;

namespace Collection.Latihan1
{
    class Latihan4
    {
        private List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Latihan4 obj = new Latihan4();
            obj.Run();
        }

        private void Run()
        {
            Console.WriteLine("Aplikasi Registrasi Mahasiswa");
            Console.WriteLine("=============================");

            int? jml = Validation.ReadInputInt("Masukkan jumlah mahasiswa: ", true);

            Student stu;
            for (int x = 0; x < jml; x++)
            { 
                stu = new Student();

                stu.No = Validation.ReadInputString("\nNomor induk mahasiswa: ", true);
                stu.Name = Validation.ReadInputString("Nama: ", true);
                stu.BirthPlace = Validation.ReadInputString("Tempat lahir: ", true);
                stu.BirthDate = Validation.ReadInputDateTime("Tanggal lahir: ", true, "dd-MM-yyyy");
                stu.Gender = Validation.ReadInputString("Jenis kelamin: ", true);
                stu.Address = Validation.ReadInputString("Alamat: ", true);
                stu.TelpNo = Validation.ReadInputString("Nomor telepon: ", true);
                stu.Faculty = Validation.ReadInputString("Jurusan: ", true);

                students.Add(stu);
            }

            if (students.Count() > 0)
                Tampil();
        }

        public void Tampil() {

            Console.WriteLine("\nInformasi mahasiswa: ");
            Console.WriteLine("Jumlah mahasiswa -> {0}", students.Count());

            foreach (Student s in students)
            {
                Console.WriteLine("\nNomor induk mahasiswa = {0}", s.No);
                Console.WriteLine("Nama mahasiswa = {0}", s.Name);
                Console.WriteLine("Tempat lahir = {0}", s.BirthPlace);
                Console.WriteLine("Tanggal lahir = {0}", s.BirthDate);
                Console.WriteLine("Jenis kelamin = {0}", s.Gender);
                Console.WriteLine("Alamat = {0}", s.Address);
                Console.WriteLine("No telepon = {0}", s.TelpNo);
                Console.WriteLine("Jurusan = {0}", s.Faculty);
            }
        }

    }
}
