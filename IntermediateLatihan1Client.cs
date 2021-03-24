using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intermediate.Models;
using Intermediate.Utils;

namespace Intermediate
{
    class IntermediateLatihan1Client
    {
        static void Main(string[] args)
        {
            IntermediateLatihan1Client obj = new IntermediateLatihan1Client();
            obj.Start();
        }

        private void Start()
        {
            IExplodeNumber en = new ExplodeNumber();

            int inputFromScreen = ReadInputUtil.ReadInputInt("Masukkan angka : ");            

            en.explodeNumber(inputFromScreen);

            Console.ReadKey();
        }

    }
}
