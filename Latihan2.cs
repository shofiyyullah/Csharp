using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection.Latihan1
{
    class Latihan2
    {
        public List<string> katas = new List<string>();

        static void Main(string[] args)
        {
            Latihan2 obj = new Latihan2();
            obj.Run();
        }

        public void Run()
        {
            string kalimat = Validation.ReadInputString("Silahkan ketik sebuah kalimat: ", true);

            katas = kalimat.Split(' ').ToList();

            //katas = Split(kalimat, 2);

            if (katas.Count() > 0)
                Tampil();
        }

        public List<string> Split(string str, int chunkSize)
        {
            List<string> output = new List<string>();

            int stringLength = str.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                output.Add(str.Substring(i, chunkSize));
            }

            return output;
        }

        public void Tampil()
        {            
            Console.WriteLine("\nInformasi List : ");
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
