using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection.Latihan1
{
    class Latihan3
    {
        private List<string> katas = new List<string>();

        static void Main(string[] args)
        {
            Latihan3 obj = new Latihan3();
            obj.Run();
        }

        private void Run()
        {
            Console.WriteLine("Silahkan ketik kata dan akhiri dengan inputan kosong/enter");

            bool henti = false;
            
            while(!henti)
            {
                string inputan = Console.ReadLine();

                if (string.IsNullOrEmpty(inputan))
                {
                    henti = true;
                }
                else {                    
                    string[] x = inputan.Split(' ').ToArray();

                    for (int i = 0; i < x.Count(); i++)
                    {
                        katas.Add(x[i]);
                    }
                }
            }

            if (katas.Count() > 0)
                Tampil();
        }

        public void Tampil()
        {
            Console.WriteLine();
            Console.WriteLine("Informasi List : ");
            Console.WriteLine("Jumlah elemen dalam List -> {0}", katas.Count());

            int x = 1;
            //menampilkan elemen data menggunakan foreach
            foreach (string kata in katas)
            {
                Console.WriteLine("[Foreach] Elemen ke-{0}: {1}", x, kata);
                x++;
            }

            //menampilkan elemen data menggunakan for
            Console.WriteLine();
            for (int a = 0; a < katas.Count(); a++)
            {
                Console.WriteLine("[For] Elemen ke-{0}: {1}", (a + 1), katas[a]);
            }

            //menampilkan elemen data menggunakan Enumerator
            Console.WriteLine();
            x = 1;
            IEnumerator<string> iterator = katas.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine("[Enumerator] Elemen ke - {0}: {1}", x, iterator.Current);
                x++;
            }
        }
    }
}
