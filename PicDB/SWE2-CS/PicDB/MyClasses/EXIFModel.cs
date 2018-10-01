using System;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class EXIFModel : IEXIFModel
    {
        private decimal _ISOValue;
        private string _make;
        private decimal _exposureTime;
        private bool _flash;
        private decimal _fNumber;
        private ExposurePrograms _exposureProgram;


        public ExposurePrograms ExposureProgram
        {
            get
            {
                return _exposureProgram;
            }

            set
            {
                _exposureProgram = value;
            }
        }

        public decimal ExposureTime
        {
            get
            {
                return _exposureTime;
            }

            set
            {
                _exposureTime = value;
            }
        }

        public bool Flash
        {
            get
            {
                return _flash;
            }

            set
            {
                _flash = value;
            }
        }

        public decimal FNumber
        {
            get
            {
                return _fNumber;
            }

            set
            {
                _fNumber = value;
            }
        }

        public decimal ISOValue
        {
            get
            {
                return _ISOValue;
            }

            set
            {
                _ISOValue = value;
            }
        }

        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                _make = value;
            }
        }
    }
}