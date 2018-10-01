using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PictureListViewModel : IPictureListViewModel
    {
        private IEnumerable<IPictureViewModel> _list;

        public PictureListViewModel()
        {
            _list = LoadPictureList();
            CurrentPicture = _list.First();

        }

        private IEnumerable<IPictureViewModel> LoadPictureList()
        {
            BusinessLayer bl = new BusinessLayer();
            bl.Sync();
            var models = bl.GetPictures();

            List<PictureViewModel> pictureObjects = new List<PictureViewModel>();

            foreach (PictureModel model in models)
            {
                var pictureViewModelImpl = new PictureViewModel(model);
                pictureObjects.Add(pictureViewModelImpl);
            }

            return pictureObjects;
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int CurrentIndex
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPictureViewModel CurrentPicture
        {
            get;
            set;
        }

        public string CurrentPictureAsString
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPictureViewModel> List
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

        public IEnumerable<IPictureViewModel> NextPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<IPictureViewModel> PrevPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}