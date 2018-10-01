using System;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class CameraViewModel : ICameraViewModel
    {
        private string _make;
        private string _producer;
        private int _id;
        private decimal _ISOLimitAcceptable;
        private decimal _ISOLimitGood;
        private bool _isValid;
        private bool _isValidBoughtOn;
        private bool _IsValidMake;
        private bool _isValidProducer;
        private string _notes;
        private string _ValidSummary;
        private DateTime? _boughton;

        public CameraViewModel()
        {
            _make = "eos80d";
            _producer = "canon";
        }
        public CameraViewModel(CameraModel core)
        {
            _make = core.Make;
            _producer = core.Producer;
            _id = core.ID;
            _ISOLimitAcceptable = core.ISOLimitAcceptable;
            _ISOLimitGood = core.ISOLimitGood;
            _boughton = core.BoughtOn;
            
        

        }

        public DateTime? BoughtOn
        {
            get
            {
                return _boughton;
            }

            set
            {
                _boughton = value;           
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public decimal ISOLimitAcceptable
        {
            get
            {
                return _ISOLimitAcceptable;
            }

            set
            {
                _ISOLimitAcceptable = value;
            }
        }

        public decimal ISOLimitGood
        {
            get
            {
                return _ISOLimitGood;
            }

            set
            {
                _ISOLimitGood = value;
            }
        }

        public bool IsValid
        {
            get
            {
                if (IsValidMake && IsValidMake && IsValidProducer && IsValidBoughtOn)
                {
                    _isValid = true;
                }
                else
                {
                    _isValid = false;
                }
                    
                return _isValid;
            }
        }

        public bool IsValidBoughtOn
        {
            get
            {
                if (_boughton == null)
                {
                    _isValidBoughtOn = true;
                }
                else
                {
                    if (_boughton.Value.Year > 2018)
                    {
                        _isValidBoughtOn = false;
                    }
                    else
                    {
                        _isValidBoughtOn = true;
                    }
                }
                
                
                return _isValidBoughtOn;
            }
        }

        public bool IsValidMake
        {
            get
            {   
                if(_make == "" || _make == null)
                {
                    _IsValidMake = false;
                }
                else
                {
                    _IsValidMake = true;
                }
                return _IsValidMake;
            }
        }

        public bool IsValidProducer
        {
            get
            {
                if(_producer == "" || _producer == null)
                {
                    _isValidProducer = false;
                }
                else
                {
                    _isValidProducer = true;
                }
                return _isValidProducer;
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

        public int NumberOfPictures
        {
            get
            {
                throw new NotImplementedException();
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

        public string ValidationSummary
        {
            get
            {
                if(!IsValidMake)
                {
                    _ValidSummary += "Make";
                }
                if (!IsValidProducer)
                {
                    ; _ValidSummary += " Producer";
                }
                if (!IsValidBoughtOn)
                {
                    _ValidSummary += " Date";
                }
                return _ValidSummary;
                
            }
        }

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}