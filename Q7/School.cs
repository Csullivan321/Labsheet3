using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class School:IComparable
    {
        public string SchoolName { get; set; }
        public int Enrollment { get; set; }

        public int CompareTo(object obj)
        {
            School theOtherSchool = (School)obj;

            School thisSchool = this;

            return thisSchool.Enrollment.CompareTo(theOtherSchool.Enrollment);
        }
    }
}
