using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PhotographerListViewModel : IPhotographerListViewModel
    {

        private IEnumerable<IPhotographerViewModel> _list;

        public PhotographerListViewModel()
        {
            //_list = loadPhotographers();
            //PhotographerViewModel p = new PhotographerViewModel();
            //p.FirstName = "Hans";
            //p.LastName = "Peter";
            //_list.Add(p);

            _list = loadPhotographers();
         }

        private List<PhotographerViewModel> loadPhotographers()
        {
            
            BusinessLayer bl = new BusinessLayer();
            bl.Sync();
            var models = bl.GetPhotographers();
            List<PhotographerViewModel> list = new List<PhotographerViewModel>();

            if (models != null)
            {
                foreach (PhotographerModel model in models)
                {
                    var photographerViewModel = new PhotographerViewModel(model);
                    list.Add(photographerViewModel);
                }
            }
            

            //Testphotograph
            PhotographerModel p = new PhotographerModel();
            p.FirstName = "Hans";
            p.LastName = "Peter";
            PhotographerViewModel pvm = new PhotographerViewModel(p);
            list.Add(pvm);
            //-------------

            return list;
        }

        public IPhotographerViewModel CurrentPhotographer
        {
            get;
            set;
        }

        public IEnumerable<IPhotographerViewModel> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
    }
}