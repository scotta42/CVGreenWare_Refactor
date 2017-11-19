using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class FormUser
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;
        // Type ( 1=Administrator, 2=Pharmacist, 3=Financial Manager )
        private int _type;
        #endregion

        #region Constructors
        public FormUser()
        {

        }

        public FormUser(string fname, string lname, string uname, string password, int type)
        {
            _firstName = fname;
            _lastName = lname;
            _userName = uname;
            _password = password;
            _type = type;
        }
        #endregion

        #region Properties
        // Type ( 1=Administrator, 2=Pharmacist, 3=Financial Manager )
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

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
