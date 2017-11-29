using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class Perscription
    {
        private int _customerID;
        private int _medicineID;

        public Perscription()
        {

        }

        public Perscription(int cust, int med)
        {
            _customerID = cust;
            _medicineID = med;
        }

        public int MedicineID
        {
            get { return _medicineID; }
            set { _medicineID = value; }
        }

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

    }
}
