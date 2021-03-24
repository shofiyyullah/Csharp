using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection.Latihan1
{
    class Latihan1
    {
        public List<string> katas = new List<string>();

        public static void Main(string[] args)
        {
            Latihan1 obj = new Latihan1();
            obj.Run();
        }

        public void Run()
        {
            for (int x = 0; x < 6; x++)
            {
                string inputan = Validation.ReadInputString("Masukkan kata ke-"+(x + 1)+": ", true);
                katas.Add(inputan);
            }

            if (katas.Count() > 0)            
                Tampil();            

            Console.ReadKey();
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
                Console.WriteLine("[For] Elemen ke-{0}: {1}", (a+1), katas[a]);                
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
