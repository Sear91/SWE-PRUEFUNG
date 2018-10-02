using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PhotographerListViewModel : IPhotographerListViewModel
    {

        private IEnumerable<IPhotographerViewModel> _list;
        /// <summary>
        /// Constructor: Befüllt die Photographer-Liste
        /// </summary>
        public PhotographerListViewModel()
        {
            //_list = loadPhotographers();
            //PhotographerViewModel p = new PhotographerViewModel();
            //p.FirstName = "Hans";
            //p.LastName = "Peter";
            //_list.Add(p);

            _list = loadPhotographers();
         }

        /// <summary>
        /// Ladet die Photographers aus dem Configfile
        /// </summary>
        /// <returns></returns>
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

            //shit pfad
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Mausi\Desktop\SWE-PRUEFUNG\PicDB\photographers.config");
            PhotographerModel p;
            PhotographerViewModel pvm;
            foreach (string line in lines)
            {
                string[] element = line.Split(';');
                p = new PhotographerModel();
                p.FirstName = element[0];
                p.LastName = element[1];
                p.Notes = element[3];
                pvm = new PhotographerViewModel(p);
                list.Add(pvm);
            }
            

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