using System;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class CameraModel : ICameraModel
    {
        private DateTime? _boughtOn;
        private int _id;
        private decimal _isoLimitAcceptable;
        private decimal _isoLimitGood;
        private string _make;
        private string _notes;
        private string _producer;

        public CameraModel()
        {
        }

        public CameraModel(String producer, String make)
        {
            _producer = producer;
            _make = make;
        }

        public DateTime? BoughtOn
        {
            get
            {
                return _boughtOn;
            }

            set
            {
                _boughtOn = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public decimal ISOLimitAcceptable
        {
            get
            {
                return _isoLimitAcceptable;
            }

            set
            {
                _isoLimitAcceptable = value;
            }
        }

        public decimal ISOLimitGood
        {
            get
            {
                return _isoLimitGood;
            }

            set
            {
                _isoLimitGood = value;
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

        public string Notes
        {
            get
            {
                return _notes;
            }

            set
            {
                _notes = value;
            }
        }

        public string Producer
        {
            get
            {
                return _producer;
            }

            set
            {
                _producer = value;
            }
        }
    }
}