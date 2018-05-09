using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student:Person
    {
        #region DataMembers
        private string _program;
        private int _year;
        private double _fee;
        #endregion

        #region Properties
        public string Program
        {
            set
            {
                _program = value;
            }
            get
            {
                return _program;
            }
        }
        public int Year
        {
            set
            {
                _year = value;
            }
            get
            {
                return _year;
            }
            
        }
        public double Fee
        {
            set
            {
                _fee = value;
            }
            get
            {
                return _fee;
            }
        }
        #endregion

        #region Constructors
        public Student()
        {

        }

        public Student(string nm, string add, string gram, int yr, double f):base(nm,add)
        {
            Program = gram;
            Year = yr;
            Fee = f;
        }
        #endregion
        public override string ToString()
        {
            return ($"{Name} {Address} {Program} {Year} {Fee}");
        }


    }
}
