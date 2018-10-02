using System;
using System.Windows;
using System.Windows.Input;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class MainWindowViewModel : IMainWindowViewModel
    {
        protected PictureListViewModel pictureList;

        /// <summary>
        /// Constructor
        /// setzt das currentPicture auf null und befüllt die pictureList
        /// </summary>
        public MainWindowViewModel()
        {
            pictureList = new PictureListViewModel();
            CurrentPicture = null;
            
        }

        /// <summary>
        /// liefert das aktuelle Bild zurück
        /// </summary>
        public IPictureViewModel CurrentPicture
        {
            get
            {
                return pictureList.CurrentPicture;
                
                //return new PictureViewModel(new PictureModel(null));
            }
            set
            {
                pictureList.CurrentPicture = value;
            }
        }

        /// <summary>
        /// liefert die Liste der Bilder zurück
        /// </summary>
        public IPictureListViewModel List
        {
            get
            {
                return new PictureListViewModel();
            }
        }

        /// <summary>
        /// liefert das SearchViewModel zurück
        /// </summary>
        public ISearchViewModel Search
        {
            get
            {
                return new SearchViewModel();
            }
        }

        

        
    }
}