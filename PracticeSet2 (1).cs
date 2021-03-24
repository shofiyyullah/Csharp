using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advance.Models;

namespace Advance
{
    class PracticeSet2
    {
        static void Main(string[] args)
        {
            PracticeSet2 obj = new PracticeSet2();
            obj.Run();
        }

        private void Run()
        {
            HashSet<Student> words = null; /* words adalah variabel dengan tipe interface Set 
                                         * dan Set akan berisi sekumpulan data dengan tipe class String */
            IEnumerator<Student> wordIterator = null; /* deklarasi variabel dengan tipe Iterator<String> */
            int count = 1;
            Student var1 = new Student();
            var1.No = "1";
            var1.Name = "Ari";
            var1.Gender = "Laki-laki";
            var1.Faculty = "TI";

            Student var2 = new Student();
            var2.No = "2";
            var2.Name = "Budi";
            var2.Gender = "Laki-laki";
            var2.Faculty = "SI";

            Student var3 = new Student();
            var3.No = "3";
            var3.Name = "Choki";
            var3.Gender = "Laki-laki";
            var3.Faculty = "SI";

            Student var4 = new Student();
            var4.No = "4";
            var4.Name = "Endang";
            var4.Gender = "Laki-laki";
            var4.Faculty = "SI";

            Student var5 = new Student();
            var5.No = "5";
            var5.Name = "Arif";
            var5.Gender = "Laki-laki";
            var5.Faculty = "SI";

            Student var6 = new Student();
            var6.No = "6";
            var6.Name = "Fandy";
            var6.Gender = "Laki-laki";
            var6.Faculty = "SI";

            
            /* 	instansiasi object dari class HashSet<String> 
                object ditampung di variable dengan tipe interface Set<String>
            */
            words = new HashSet<Student>();
            words.Add(var1); /* menambah Student ke dalam Set dengan menggunakan method add */
            words.Add(var2); /* menambah Student ke dalam Set dengan menggunakan method add */

            //var2.Faculty = "TI";


            words.Add(var2); /* menambah Student ke dalam Set dengan menggunakan method add */
            words.Add(var3); /* menambah Student ke dalam Set dengan menggunakan method add */
            
            // Cara 1 [start]
		    /* mengakses elemen yang ada dalam Set */
		    wordIterator = words.GetEnumerator();
		    Console.WriteLine("Informasi Set setelah proses pertama");
		    Console.WriteLine("Jumlah elemen dalam Set -> {0}", words.Count);
		    while (wordIterator.MoveNext())
		    {
                Console.WriteLine("Elemen ke-{0} dengan GetEnumerator", count);
                Console.WriteLine("NIK : {0}", wordIterator.Current.No);
                Console.WriteLine("Nama : {0}", wordIterator.Current.Name);
                Console.WriteLine("Jenis Kelamin : {0}", wordIterator.Current.Gender);
                Console.WriteLine("Fakultas : {0}", wordIterator.Current.Faculty);
                Console.WriteLine();
			    count++;
		    }
            // Cara 1 [end]

            // Cara 2 [start]
            /* mengakses elemen yang ada dalam Set */
            count = 1;
            foreach (Student student in words)
            {
                Console.WriteLine("Elemen ke-{0} dengan Foreach", count);
                Console.WriteLine("NIK : {0}", student.No);
                Console.WriteLine("Nama : {0}", student.Name);
                Console.WriteLine("Jenis Kelamin : {0}", student.Gender);
                Console.WriteLine("Fakultas : {0}", student.Faculty);
                Console.WriteLine();
                count++;
            }
            // Cara 2 [end]

            words.Add(var4); /* menambah Student ke dalam Set dengan menggunakan method add */
            words.Add(var5); /* menambah Student ke dalam Set dengan menggunakan method add */
            words.Add(var6); /* menambah Student ke dalam Set dengan menggunakan method add */

		    /* mengakses elemen yang ada dalam Set */
		    wordIterator = words.GetEnumerator();
		    Console.WriteLine("\nInformasi Set setelah proses kedua");
		    Console.WriteLine("Jumlah elemen dalam Set -> {0}", words.Count);
		    count = 1;
		    while (wordIterator.MoveNext())
		    {
                Console.WriteLine("Elemen ke-{0}", count);
                Console.WriteLine("NIK : {0}", wordIterator.Current.No);
                Console.WriteLine("Nama : {0}", wordIterator.Current.Name);
                Console.WriteLine("Jenis Kelamin : {0}", wordIterator.Current.Gender);
                Console.WriteLine("Fakultas : {0}", wordIterator.Current.Faculty);
                Console.WriteLine();
			    count++;
		    }
        }
    }
}