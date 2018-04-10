using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadeWithLove
{
    class Customer
    {
        #region Properties
       
        public string CustomerName { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime DateNeeded { get; set; }
        public int CakeSize { get; set; }
        public string CakeFlavor { get; set; }
        public decimal CakePrice { get; set; }
        public bool BalancePaid { get; set; }

        #endregion
    }
}
