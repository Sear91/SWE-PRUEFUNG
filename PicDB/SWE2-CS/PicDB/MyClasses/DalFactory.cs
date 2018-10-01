using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;

namespace PicDB
{
    class DalFactory
    {
        private bool _isFAKE = false;

        public bool IsFake { get {
                return _isFAKE;
            }
                set
            {
                _isFAKE = value;
            }
            }

        protected DalFactory()
        {

        }
        private static DalFactory _instance;
        public static DalFactory Single
        {
            get
            {
                //if (_instance == null)
                //{
                //    _instance = new DalFactory();
                //} same with 
                return _instance ?? (_instance = new DalFactory());
            }
        }

        public IMoneyDAL GetDAL()
        {
            if (_isFAKE)
            {
                return new MockDAL();
            }
            else
            {
                return new DataAccessLayer();
            }
        }
    }
}
