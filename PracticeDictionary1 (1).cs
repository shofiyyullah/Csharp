using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advance.Collection;

namespace Basic
{
    class PracticeDictionary1
    {
        static void Main(string[] args)
        {
            PracticeDictionary1 obj = new PracticeDictionary1();
            obj.Run();
        }

        private void Run()
        {
            IDictionary<int, string> words = null; /* words adalah variabel dengan tipe interface Dictionary 
                                                    * dan Dictionary akan berisi sekumpulan data dengan tipe class String */
            IEnumerator<KeyValuePair<int, string>> wordIterator = null; /* deklarasi variabel dengan tipe Iterator<String> */

            /* 	instansiasi object dari class Dictionary<String> 
                object ditampung di variable dengan tipe interface Dictionary<String>
            */
            words = new Dictionary<int, string>();
            words.Add(1, "Elemen Ke-1"); /* menambah String "Elemen Ke-1" ke dalam Dictionary dengan menggunakan method add */
            words.Add(2, "Elemen Ke-2"); /* menambah String "Elemen Ke-2" ke dalam Dictionary dengan menggunakan method add */
            words.Add(3, "Elemen Ke-3"); /* menambah String "Elemen Ke-3" ke dalam Dictionary dengan menggunakan method add */

		    /* mengakses elemen yang ada dalam Dictionary */
		    wordIterator = words.GetEnumerator();
		    Console.WriteLine("Informasi Dictionary setelah proses pertama");
		    Console.WriteLine("Jumlah elemen dalam Dictionary -> {0}", words.Count);
		    while (wordIterator.MoveNext())
		    {
                Console.WriteLine("Key = {0}, Value = {1}", wordIterator.Current.Key, wordIterator.Current.Value);
		    }

		    words.Add(4, "Elemen Ke-4"); /* menambah String "Elemen Ke-4" ke dalam Dictionary dengan menggunakan method add */
		    words.Add(5, "Elemen Ke-5"); /* menambah String "Elemen Ke-5" ke dalam Dictionary dengan menggunakan method add */
		    words.Add(6, "Elemen Ke-6"); /* menambah String "Elemen Ke-6" ke dalam Dictionary dengan menggunakan method add */

		    /* mengakses elemen yang ada dalam Dictionary */
		    wordIterator = words.GetEnumerator();
		    Console.WriteLine("\nInformasi Dictionary setelah proses kedua");
		    Console.WriteLine("Jumlah elemen dalam Dictionary -> {0}", words.Count);
		     while (wordIterator.MoveNext())
		    {
                Console.WriteLine("Key = {0}, Value = {1}", wordIterator.Current.Key, wordIterator.Current.Value);
		    }

            IDictionary<string, string> sentences = null; /* sentences adalah variabel dengan tipe interface Dictionary dan 
                                                           * Dictionary akan berisi sekumpulan data dengan tipe class String */
            IEnumerator<KeyValuePair<string, string>> sentenceIterator = null;

            sentences = new Dictionary<string, string>();
            sentences.Add("Satu", "Elemen Ke-1"); /* menambah String "Elemen Ke-1" ke dalam Dictionary dengan menggunakan method add */
            sentences.Add("Dua", "Elemen Ke-2"); /* menambah String "Elemen Ke-2" ke dalam Dictionary dengan menggunakan method add */
            sentences.Add("Tiga", "Elemen Ke-3"); /* menambah String "Elemen Ke-3" ke dalam Dictionary dengan menggunakan method add */

            /* mengakses elemen yang ada dalam Dictionary */
            sentenceIterator = sentences.GetEnumerator();
            Console.WriteLine("\n\nInformasi Dictionary setelah proses pertama");
            Console.WriteLine("Jumlah elemen dalam Dictionary -> {0}", sentences.Count);
            while (sentenceIterator.MoveNext())
            {
                Console.WriteLine("Key = {0}, Value = {1}", sentenceIterator.Current.Key, sentenceIterator.Current.Value);
            }

            sentences.Add("Empat", "Elemen Ke-4"); /* menambah String "Elemen Ke-4" ke dalam Dictionary dengan menggunakan method add */
            sentences.Add("Lima", "Elemen Ke-5"); /* menambah String "Elemen Ke-5" ke dalam Dictionary dengan menggunakan method add */
            sentences.Add("Enam", "Elemen Ke-6"); /* menambah String "Elemen Ke-6" ke dalam Dictionary dengan menggunakan method add */

            /* mengakses elemen yang ada dalam Dictionary */
            sentenceIterator = sentences.GetEnumerator();
            Console.WriteLine("\nInformasi Dictionary setelah proses kedua");
            Console.WriteLine("Jumlah elemen dalam Dictionary -> {0}", sentences.Count);
            while (sentenceIterator.MoveNext())
            {
                Console.WriteLine("Key = {0}, Value = {1}", 
                    sentenceIterator.Current.Key, 
                    sentenceIterator.Current.Value);
            }


            foreach (KeyValuePair<string, string> keyValuePair in sentences)
            {
                Console.WriteLine("Looping Elemen Data: Key = {0}, Value = {1}", keyValuePair.Key, keyValuePair.Value);
            }

            Console.WriteLine("Elemen sentences dengan key '{0}' adalah '{1}'", 
                "Empat", 
                sentences["Empat"]);

            if (sentences.ContainsKey("Empat"))
            {
                sentences["Empat"] = "Elemen Ke-4 yang kedua";
            }
            else
            {
                sentences.Add("Empat", "Elemen Ke-4");
            }

            Console.WriteLine("Elemen sentences dengan key '{0}' adalah '{1}'", "Empat", sentences["Empat"]);
            /*
            Console.WriteLine("\nInformasi Dictionary setelah proses ketiga");
            Console.WriteLine("Jumlah elemen dalam Dictionary -> {0}", sentences.Count);
            while (sentenceIterator.MoveNext())
            {
                Console.WriteLine("Key = {0}, Value = {1}", sentenceIterator.Current.Key, sentenceIterator.Current.Value);
            }
            */

        }
    }
}