using System;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class EXIFViewModel : IEXIFViewModel
    {
        private decimal _ISOValues;
        private string _make;
        private decimal _exposureTime;
        private bool _flash;
        private decimal _fNumber;
        private ExposurePrograms _exposureProgram;
        private ISORatings _ISORating;
        private ICameraViewModel _camera;

        public EXIFViewModel()
        {

        }
        public EXIFViewModel(EXIFModel core_model)
        {
            _exposureProgram = core_model.ExposureProgram;
            
            _ISOValues = core_model.ISOValue;
            Console.WriteLine("{0},{1}",core_model.ISOValue,_ISOValues);
            _make = core_model.Make;
            _exposureTime = core_model.ExposureTime;
            _flash = core_model.Flash;
            _fNumber = core_model.FNumber;
        }
        public ICameraViewModel Camera
        {
            get
            {
                return _camera;
            }

            set
            {
                _camera = value;
            }
        }

        public string ExposureProgram
        {
            get
            {
                return _exposureProgram.ToString();
            }
        }

        public string ExposureProgramResource
        {
            get
            {
                return _exposureProgram.ToString();
            }
        }

        public decimal ExposureTime
        {
            get
            {
                return _exposureTime;
            }
        }

        public bool Flash
        {
            get
            {
                return _flash;
            }
        }

        public decimal FNumber
        {
            get
            {
                return _fNumber;
            }
        }

        public ISORatings ISORating
        {
            get
            {
                _ISORating = (ISORatings)0;
                if (_camera != null)
                {
                    if (ISOValue == 0)
                    { _ISORating = (ISORatings)0; }
                    else if (ISOValue <= _camera.ISOLimitGood)
                    { _ISORating = (ISORatings)1; }
                    else if (ISOValue <= _camera.ISOLimitAcceptable)
                    { _ISORating = (ISORatings)2; }
                    else if (ISOValue > _camera.ISOLimitAcceptable)
                    { _ISORating = (ISORatings)3; }
                }
                return _ISORating;
            }
        }

        public string ISORatingResource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal ISOValue
        {
            get
            {
                return _ISOValues;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }
        }
    }
}