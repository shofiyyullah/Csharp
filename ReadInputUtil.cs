using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intermediate.Utils
{
    class ReadInputUtil
    {
        public static int ReadInputInt(string pertanyaan)
        {
            bool sudahValid = false;
            int hasil = 0;

            do
            {
                Console.Write(pertanyaan);
                string str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Inputan tidak boleh kosong...");
                    sudahValid = false;
                }
                else
                {
                    try
                    {
                        hasil = int.Parse(str);
                        if (hasil <= 0)
                        {
                            Console.WriteLine("Inputan harus diatas nol..");
                            sudahValid = false;
                        }
                        else
                        {
                            sudahValid = true;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Inputan harus berupa bilangan bulat...");
                        sudahValid = false;
                    }
                }
            }
            while (!sudahValid);

            return hasil;
        }

        public static double ReadInputDoubleMandatory(string pertanyaan)
        {
            bool isValid = false;
            string str = null;
            float nilai = 0;

            do
            {
                Console.Write(pertanyaan);

                str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Inputan tidak boleh kosong!!!");
                    isValid = false;
                }
                else
                {
                    try
                    {
                        nilai = float.Parse(str);
                        isValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Inputan harus berupa bilangan bulat /decimal!!!");
                        isValid = false;
                    }

                }
            }
            while (!isValid);

            return nilai;
        }

        public static string ReadInputStringMandatory(string pertanyaan)
        {
            bool isValid = false;
            string str = null;

            do
            {
                Console.Write(pertanyaan);

                str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Inputan tidak boleh kosong!!!");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            while (!isValid);

            return str;
        }
    }
}
