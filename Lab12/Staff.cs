using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff:Person
    {
        private string _school;
        private double _pay;

        public string School
        {
            set
            {
                _school = value;
            }
            get
            {
                return _school;
            }
        }
        
        public double Pay
        {
            set
            {
                _pay = value;
            }
            get
            {
                return _pay;
            }
        }

        public Staff()
        {

        }
        public Staff(string nm, string add, double p, string sch):base(nm,add)
        {
            School = sch;
            Pay = p;
        }
        public override string ToString()
        {
            return ($"{Name} {Address} {School} {Pay}");
        }


    }
}
