using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advance
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue1 obj = new Queue1();
            obj.Run();
        }

        private void Run()
        {
            Queue words = new Queue(); /* words adalah variabel dengan tipe Queue 
                                        * dan Queue akan berisi sekumpulan data dengan tipe class String */
            int count = 1;

            /* 	instansiasi object dari class Queue<String> 
                object ditampung di variable dengan tipe Queue<String>
            */
            words.Enqueue("satu"); /* menambah String "satu" ke dalam Queue dengan menggunakan method add */
            words.Enqueue("dua"); /* menambah String "dua" ke dalam Queue dengan menggunakan method add */
            words.Enqueue("tiga"); /* menambah String "tiga" ke dalam Queue dengan menggunakan method add */
            Console.WriteLine("Jumlah elemen: " + words.Count);
            /* mengakses elemen yang ada dalam Queue */
            foreach (string nilaiWord in words)
            {
                Console.WriteLine("Elemen ke-{0}: {1}", count, nilaiWord);
                count++;
            }

            words.Enqueue("empat"); /* menambah String "empat" ke dalam Queue dengan menggunakan method add */
            words.Enqueue("lima"); /* menambah String "lima" ke dalam Queue dengan menggunakan method add */
            words.Enqueue("enam"); /* menambah String "enam" ke dalam Queue dengan menggunakan method add */

            // menghapus element dengan nilai "satu"
            words.Dequeue();

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
            Console.WriteLine("Queue adalah: ");
            foreach (Object obj in words)
                Console.WriteLine("{0}", obj);

            Console.WriteLine("\nString Array adalah: ");
            foreach (Object obj1 in arr)
                Console.WriteLine("{0}", obj1);

            Console.WriteLine("\nSetelah CopyTo Method: ");
            words.CopyTo(arr, 4);

            Console.WriteLine("ArrayList adalah: ");
            foreach (Object obj in words)
                Console.WriteLine("{0}", obj);

            Console.WriteLine("\nString Array adalah: ");
            foreach (Object obj1 in arr)
                Console.WriteLine("{0}", obj1); 

            // memeriksa Queue apakah sama
            Console.WriteLine("Apa benar elemen yang sama : " + words.Equals(words));

            Console.WriteLine("\nMemindahkan elemen queue ke tempat yang baru");
            Queue myQueue = new Queue();
            myQueue.Enqueue("Raigor");
            myQueue.Enqueue("Yunero");
            myQueue.Enqueue("Rikimaru");
            myQueue.Enqueue("Kardel");

            // Creating a copy using the  
            // Cara 1 - assignment operator. 
            Queue myQueue2 = myQueue;
            myQueue2.Dequeue();
            PrintValues(myQueue2);

            // Cara 2 - CopyTo 
            string[] arrQueue = new string[myQueue.Count];
            myQueue.CopyTo(arr, 0);
            foreach (string str in arr)
            {
                Console.WriteLine("Queue yg baru di copy adalah : {0}", str);
            }
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            // This method prints all the 
            // elements in the Stack. 
            foreach (Object obj in myCollection)
                Console.WriteLine(obj);
        } 
    }
}