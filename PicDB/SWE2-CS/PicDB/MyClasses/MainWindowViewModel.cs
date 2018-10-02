using System;
using System.Windows;
using System.Windows.Input;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class MainWindowViewModel : IMainWindowViewModel
    {
        protected PictureListViewModel pictureList;


        public MainWindowViewModel()
        {
            pictureList = new PictureListViewModel();
            CurrentPicture = null;
            
        }

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

        public IPictureListViewModel List
        {
            get
            {
                return new PictureListViewModel();
            }
        }

        public ISearchViewModel Search
        {
            get
            {
                return new SearchViewModel();
            }
        }

        

        
    }
}