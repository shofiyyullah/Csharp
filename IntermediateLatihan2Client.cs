using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.Utils;
using Intermediate.Models;

namespace Intermediate
{
    class IntermediateLatihan2Client
    {
        static void Main(string[] args)
        {
            IntermediateLatihan2Client obj = new IntermediateLatihan2Client();
            obj.Start();
        }

        private void Start()
        {
            ICourse semesterCourse = new SemesterCourse();

            int jmlPelajaran = ReadInputUtil.ReadInputInt("Masukkan jumlah pelajaran : ");

            int i = 0;
            do
            {
                string nama = ReadInputUtil.ReadInputStringMandatory("Nama pelajaran : ");
                double nilai = ReadInputUtil.ReadInputDoubleMandatory("Nilai pelajaran : ");

                Course course = new Course(nama, nilai);
                semesterCourse.addCourse(course);

                i++;
            }
            while (i < jmlPelajaran);

            double avg = semesterCourse.calcAverage();
            Console.Write("\nRata-rata : " + avg.ToString());
            Console.ReadKey();
        }
    }
}
