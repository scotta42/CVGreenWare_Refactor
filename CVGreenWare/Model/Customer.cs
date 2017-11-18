using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class Customer : User
    {
        #region Fields
        private int _age;
        private string _insurance;
        private string _email;
        private DateTime _lastVisit;
        #endregion

        public Customer()
        {

        }

        #region Properties
        public DateTime LastVisit
        {
            get { return _lastVisit; }
            set { _lastVisit = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Insurance
        {
            get { return _insurance; }
            set { _insurance = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        #endregion

    }
}
