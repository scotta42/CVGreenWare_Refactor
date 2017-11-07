using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class User
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private string _userName;
        #endregion

        public User()
        {

        }

        #region Properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Name
        {
            get { return _firstName + " " + _lastName; }
        }
  
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        #endregion
    }
}
