using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Collection.Models;

namespace Collection.Collections
{
    class PracticeStringDictionary1
    {
        public static void Main(string[] args)
        {
            PracticeStringDictionary1 obj = new PracticeStringDictionary1();
            obj.Run();
        }

        private void Run()
        {
            StringDictionary words = new StringDictionary(); /* words adalah variabel dengan tipe ArrayList 
                                                   * dan ArrayList akan berisi sekumpulan data dengan tipe class String */
            //ArrayList words = new ArrayList(10);  /* Menginisialisasi instance baru dari kelas ArrayList yang kosong dan 
            /* memiliki kapasitas awal yang ditentukan */
            //words = new ArrayList<int, Student>();

            int seq;

            // Cara 1
            string studentName = null;

            for (int i = 1; i <= 6; i++)
            {
                Student s = new Student();
                Console.Write("Masukkan kata ke-{0}: ", i);
                s.Name = Console.ReadLine();

                studentName = s.Name;

                words.Add(i.ToString(), studentName);
            }

            // Cara 2
            //string word1 = null;
            //string word2 = null;
            //string word3 = null;
            //string word4 = null;
            //string word5 = null;
            //string word6 = null;

            //Console.Write("Masukkan kata ke-1: ");
            //word1 = Console.ReadLine();

            //Console.Write("Masukkan kata ke-2: ");
            //word2 = Console.ReadLine();

            //Console.Write("Masukkan kata ke-3: ");
            //word3 = Console.ReadLine();

            //Console.Write("Masukkan kata ke-4: ");
            //word4 = Console.ReadLine();

            //Console.Write("Masukkan kata ke-5: ");
            //word5 = Console.ReadLine();

            //Console.Write("Masukkan kata ke-6: ");
            //word6 = Console.ReadLine();

            //words.Add(1, word1); /* menambah String "satu" ke dalam ArrayList dengan menggunakan method add */
            //words.Add(2, word2); /* menambah String "dua" ke dalam ArrayList dengan menggunakan method add */
            //words.Add(3, word3); /* menambah String "tiga" ke dalam ArrayList dengan menggunakan method add */
            //words.Add(4, word4); /* menambah String "empat" ke dalam ArrayList dengan menggunakan method add */
            //words.Add(5, word5); /* menambah String "lima" ke dalam ArrayList dengan menggunakan method add */
            //words.Add(6, word6); /* menambah String "enam" ke dalam ArrayList dengan menggunakan method add */

            /* mengakses elemen yang ada dalam ArrayList */
            Console.WriteLine("Informasi ArrayList :");
            Console.WriteLine("Jumlah elemen dalam ArrayList -> {0}", words.Count);

            foreach (DictionaryEntry i in words)
            {
                Console.WriteLine("Elemen ke-{0}: {1}", i.Key, i.Value);
            }

            // loop via enumerator directly
            //count = 1;
            //IEnumerator<string> wordIterator = words.GetEnumerator(); /* deklarasi variabel dengan tipe Iterator<String> */
            //while (wordIterator.MoveNext())
            //{
            //    Console.WriteLine("Elemen ke-{0}: {1}", count, wordIterator.Current);
            //    count++;
            //}
        }
    }
}