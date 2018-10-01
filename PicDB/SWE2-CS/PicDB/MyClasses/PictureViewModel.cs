using System;
using System.ComponentModel;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PictureViewModel : IPictureViewModel, INotifyPropertyChanged
    {
        private PictureModel mdl;
        private CameraViewModel _camera;
        private EXIFViewModel _exif;
        private IPTCViewModel _iptc;
        private PhotographerViewModel _photographer;
        private string _picTitle;
        private string _picNotes;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }

        public string picTitle
        {
            get
            {
                return _picTitle;
            }
            set
            {
                if (value != _picTitle)
                {
                    _picTitle = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string picNotes
        {
            get
            {
                return _picNotes;
            }
            set
            {
                if (value != _picNotes)
                {
                    _picNotes = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public PictureViewModel(PictureModel mdl)
        {
            this.mdl = mdl;
            _camera = new CameraViewModel();
            _iptc = new IPTCViewModel();
            EXIFModel em = new EXIFModel();
            em.Make = "Hi";
            em.ISOValue = 30;
            em.Flash = true;
            _exif = new EXIFViewModel(em);
            _picTitle = "";
            _photographer = new PhotographerViewModel(new PhotographerModel());
        }


        public ICameraViewModel Camera
        {
            get
            {
                
                return _camera;
            }
        }

        public string DisplayName
        {
            get
            {
                if (String.IsNullOrEmpty(picTitle))
                {
                    string ganzerPfad = FileName;
                    string[] splitPfad = ganzerPfad.Split('\\');
                    string pictureName = splitPfad[splitPfad.Length - 1];
                    picTitle = pictureName.Split('.')[0];

                    
                }
                return picTitle + " (by " + Photographer.FirstName + " " + Photographer.LastName + ")";
            }
            
        }

        public IEXIFViewModel EXIF
        {
            get
            {
                return _exif;
            }
        }

        public string FileName
        {
            get
            {

                return mdl.FileName;
            }
        }

        public string FilePath
        {
            get
            {
                return mdl.FileName;
            }
        }

        public int ID
        {
            get
            {
                return mdl.ID;
            }
        }

        public IIPTCViewModel IPTC
        {
            get
            {
                return _iptc;
            }
        }

        public IPhotographerViewModel Photographer
        {
            get
            {
                return _photographer;
            }
        }
    }
}