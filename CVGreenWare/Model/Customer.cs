using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class Customer : FormUser
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

        public Customer(string name, int age, string insurance, DateTime lastvisist, string email)
        {
            // TODO: parse name and set first and last
            FirstName = name; LastName = name;
            _age = age; _insurance = insurance; _lastVisit = lastvisist; _email = email;
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
