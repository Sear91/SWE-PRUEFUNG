using System;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class PictureModel : IPictureModel
    {
        CameraModel _camera;
        EXIFModel _exif;
        string _fileName;
        int _id;
        IPTCModel _iptc;

        public PictureModel()
        {
        }

        public PictureModel(string fileName)
        {
            _fileName = fileName;
            _iptc = new IPTCModel();
            _exif = new EXIFModel();
            _camera = new CameraModel("","");

        }

        public ICameraModel Camera
        {
            get
            {
                return _camera;
            }

            set
            {
                _camera = (CameraModel) value;
            }
        }

        public IEXIFModel EXIF
        {
            get
            {
                return _exif;
            }

            set
            {
                _exif = (EXIFModel)value;
            }
        }

        public string FileName
        {
            get
            {
                return _fileName;
            }

            set
            {
                _fileName = value;
            }
        }

        public int ID
        {
            get
            {
                if(_id == 0)
                {
                    Random rnd = new Random();

                    _id = rnd.Next(1, 1000);
                }
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public IIPTCModel IPTC
        {
            get
            {
                return _iptc;
            }

            set
            {
                _iptc = (IPTCModel)value;
            }
        }
    }
}