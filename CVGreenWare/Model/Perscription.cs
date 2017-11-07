using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVGreenWare.Model
{
    class Perscription
    {
        private Customer _customer;
        private Medicine medicine;

        public Medicine Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

    }
}
