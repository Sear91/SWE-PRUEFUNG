using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    public class UEB3 : IUEB3
    {
        

        public void HelloWorld()
        {
        }

        public IBusinessLayer GetBusinessLayer()
        {
            DalFactory.Single.IsFake = true;
            return new BusinessLayer();
        }

        public void TestSetup(string picturePath)
        {
            
        }

        public IDataAccessLayer GetDataAccessLayer()
        {
            DalFactory.Single.IsFake = true;
            return DalFactory.Single.GetDAL();
        }

        public ISearchViewModel GetSearchViewModel()
        {
            return new SearchViewModel();
        }
    }
}
