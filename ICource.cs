using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Intermediate.Models;

namespace Intermediate.Utils
{
    interface ICourse
    {
        void addCourse(Course course);
        double calcAverage();
    }
}
