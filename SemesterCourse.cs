using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.Utils;

namespace Intermediate.Models
{
    class SemesterCourse : ICourse
    {
        private List<Course> courses;

        // overloading
        public SemesterCourse()
        {
            courses = new List<Course>();
        }

        public SemesterCourse(int i)
        {
            courses = new List<Course>();
        }

        public void addCourse(Course course)
        {
            courses.Add(course);
        }

        // override interface
        public double calcAverage()
        {
            double totalNilai = 0;
            int jmlPelajaran = courses.Count;

            for (int i = 0; i < jmlPelajaran; i++)
            {
                totalNilai += courses[i].nilai;
            }

            return totalNilai / jmlPelajaran;
        }
    }
}
