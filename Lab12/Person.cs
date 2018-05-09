using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        #region DataMembers
        private string _name;
        private string _address;
        #endregion

        #region Properties
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public string Address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }
        #endregion

        #region Constructors
        public Person()
        {
            _address = "1234 Main St";
        }
        public Person(string nm, string add)
        {
            Name = nm;
            Address = add;
        }
        #endregion
        public override string ToString()
        {
            return ($"{Name} {Address}");
        }
        
            
        

    }
}
