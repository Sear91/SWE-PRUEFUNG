using System;
using System.Collections.Generic;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PhotographerListViewModel : IPhotographerListViewModel
    {
        public IPhotographerViewModel CurrentPhotographer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPhotographerViewModel> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}