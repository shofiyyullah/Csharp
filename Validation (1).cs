using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection.Latihan1
{
    class Validation
    {
        public static int? ReadInputInt(string pertanyaan, bool mandatory)
        {
            bool valid = false;
            string inputan;
            int? output = null;

            do
            {
                Console.Write(pertanyaan);

                inputan = Console.ReadLine();

                if (string.IsNullOrEmpty(inputan) && mandatory)
                {
                    Console.WriteLine("Inputan tidak boleh kosong");
                }

                if (!string.IsNullOrEmpty(inputan))
                {
                    try
                    {
                        output = int.Parse(inputan);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Inputan harus berupa angka");
                    }

                    valid = true;
                }
                else
                {
                    output = null;
                    valid = true;
                }
            }
            while (!valid);

            return output;
        }

        public static string ReadInputString(string pertanyaan, bool mandatory)
        {
            bool valid = false;
            string output;

            do
            {
                Console.Write(pertanyaan);

                output = Console.ReadLine();

                if (string.IsNullOrEmpty(output) && mandatory)
                {
                    Console.WriteLine("Inputan tidak boleh kosong");
                }
                if (!string.IsNullOrEmpty(output))
                {
                    valid = true;
                }
                else
                {
                    output = null;
                    valid = true;
                }
            }
            while (!valid);

            return output;
        }

        public static DateTime? ReadInputDateTime(string pertanyaan, bool mandatory, string dateFormat) //dd-MM-yyyy
        {
            bool isValid = false;
            string str = null;
            DateTime? result = null;

            do
            {
                Console.Write(pertanyaan);

                str = Console.ReadLine();

                if (mandatory && string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("Inputan tidak boleh kosong");
                }

                if (!string.IsNullOrEmpty(str))
                {
                    try
                    {
                        result = DateTime.ParseExact(str, dateFormat, null);
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Silahkan masukkan tanggal dengan format {0}!!!", dateFormat);
                    }
                }
                else
                {
                    result = null;
                    isValid = true;
                }
            }
            while (!isValid);

            return result;
        }
    }
}
