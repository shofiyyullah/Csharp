using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advance
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack1 obj = new Stack1();
            obj.Run();
        }

        private void Run()
        {
            Stack words = new Stack(); /* words adalah variabel dengan tipe Stack 
                                        * dan Stack akan berisi sekumpulan data dengan tipe class String */
            int count = 1;

            /* 	instansiasi object dari class Stack<String> 
                object ditampung di variable dengan tipe Stack<String>
            */

            words.Push("satu"); /* menambah String "satu" ke dalam Stack dengan menggunakan method add */
            words.Push("dua"); /* menambah String "dua" ke dalam Stack dengan menggunakan method add */
            words.Push("tiga"); /* menambah String "tiga" ke dalam Stack dengan menggunakan method add */
            Console.WriteLine("Jumlah elemen: " + words.Count);
            /* mengakses elemen yang ada dalam Queue */
            foreach (string nilaiWord in words)
            {
                Console.WriteLine("Elemen ke-{0}: {1}", count, nilaiWord);
                count++;
            }

            words.Push("empat"); /* menambah String "empat" ke dalam Stack dengan menggunakan method add */
            words.Push("lima"); /* menambah String "lima" ke dalam Stack dengan menggunakan method add */
            words.Push("enam"); /* menambah String "enam" ke dalam Stack dengan menggunakan method add */

            // menghapus element dengan nilai "enam"
            words.Pop();

            foreach (string nilaiWord in words)
            {
                Console.WriteLine("Elemen ke-{0}: {1}", count, nilaiWord);
                count++;
            }

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
            Console.WriteLine("ArrayList adalah: ");
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

            Console.WriteLine("\nMemindahkan elemen Stack ke tempat yang baru");
            Stack myStack = new Stack();
            myStack.Push("Raigor");
            myStack.Push("Yunero");
            myStack.Push("Rikimaru");
            myStack.Push("Kardel");

            // Creating a copy using the  
            // Cara 1 - assignment operator. 
            //Stack myStack2 = myStack;
            //myStack2.Pop();
            //PrintValues(myStack2);

            // Cara 2 - CopyTo 
            string[] arrStack = new string[myStack.Count];
            myStack.CopyTo(arr, 0);
            foreach (string str in arr)
            {
                Console.WriteLine("Stack yg baru di copy adalah : {0}", str);
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