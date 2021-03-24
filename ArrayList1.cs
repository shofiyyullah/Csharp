using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advance
{
    class ArrayList1
    {
        static void Main(string[] args)
        {
            ArrayList1 obj = new ArrayList1();
            obj.Run();
        }

        private void Run()
        {
            ArrayList words = new ArrayList(); /* words adalah variabel dengan tipe ArrayList 
                                        * dan ArrayList akan berisi sekumpulan data dengan tipe class String */
            //ArrayList words = new ArrayList(10);  /* Menginisialisasi instance baru dari kelas ArrayList yang kosong dan 
                                                    /* memiliki kapasitas awal yang ditentukan */
            int count = 1;

            /* 	instansiasi object dari class HashSet<String> 
                object ditampung di variable dengan tipe interface Set<String>
            */
            words.Add("satu"); /* menambah String "satu" ke dalam ArrayList dengan menggunakan method add */
            words.Add("dua"); /* menambah String "dua" ke dalam ArrayList dengan menggunakan method add */
            words.Add("tiga"); /* menambah String "tiga" ke dalam ArrayList dengan menggunakan method add */
            Console.WriteLine("Jumlah elemen: " + words.Count);
            //Console.WriteLine("Jumlah Kapasitas: " + words.Capacity);
            /* mengakses elemen yang ada dalam ArrayList */
            foreach (string nilaiWord in words)
            {
                Console.WriteLine("Elemen ke-{0}: {1}", count, nilaiWord);
                count++;
            }

            words.Add("empat"); /* menambah String "empat" ke dalam ArrayList dengan menggunakan method add */
            words.Add("lima"); /* menambah String "lima" ke dalam ArrayList dengan menggunakan method add */
            words.Add("enam"); /* menambah String "enam" ke dalam ArrayList dengan menggunakan method add */

            // menghapus element dengan nilai "satu"
            words.Remove("satu");

            words[2] = "Selip angka di array no 2";

            if (words.Contains("lima"))
                Console.WriteLine("Benar, ada pada index " + words.IndexOf("lima"));
            else
                Console.WriteLine("Tidak ada");

            String[] arr = new String[9];

            arr[0] = "C";
            arr[1] = "C++";
            arr[2] = "Java";
            arr[3] = "Python";
            arr[4] = "C#";
            arr[5] = "HTML";
            arr[6] = "CSS";
            arr[7] = "PHP";
            arr[8] = "DBMS";

            Console.WriteLine("\nSebelum CopyTo Method: ");

            //Console.WriteLine("ArrayList adalah: ");

            foreach (Object obj in words)
                Console.WriteLine("{0}", obj);

            Console.WriteLine("\nString Array adalah: ");
            foreach (Object obj1 in arr)
                Console.WriteLine("{0}", obj1);

            Console.WriteLine("\nSetelah CopyTo Method: ");
            words.CopyTo(arr);

            Console.WriteLine("ArrayList adalah: ");
            foreach (Object obj in words)
                Console.WriteLine("{0}", obj);

            Console.WriteLine("\nString Array adalah: ");
            foreach (string obj1 in arr)
                Console.WriteLine("{0}", obj1); 

            // memeriksa ArrayList apakah sama
            Console.WriteLine(words.Equals(words));

            // Inserting 3 elements at random index in the ArrayList 
            words.Insert(1, "Tujuh");
            words.Insert(4, "Delapan");
            words.Insert(5, "Sembilan");
            Console.WriteLine("\nArrayList setelah insert adalah: ");
            foreach (Object obj  in words)
                Console.WriteLine("{0}", obj);

            words.Sort();
            Console.WriteLine("\nArrayList setelah diurutkan adalah: ");
            foreach (Object obj in words)
                Console.WriteLine("{0}", obj);
        }
    }
}