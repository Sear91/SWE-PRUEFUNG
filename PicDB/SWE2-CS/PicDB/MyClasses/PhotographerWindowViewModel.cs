using System;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PhotographerWindowViewModel
    {
        

        public PhotographerWindowViewModel()
        {
            
        }

        public IPhotographerListViewModel List
        {
            get
            {
                return new PhotographerListViewModel();
            }
        }

        public PhotographerViewModel CurrentPhotographer { get; set; }

        public void saveList()
        {
            Console.WriteLine("List saved");
        }

    }
}