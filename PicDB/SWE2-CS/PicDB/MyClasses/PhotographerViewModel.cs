using System;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class PhotographerViewModel : IPhotographerViewModel
    {
        private PhotographerModel mdl;
        private string _ValidSummary;

        public PhotographerViewModel()
        {
        }

        public PhotographerViewModel(PhotographerModel mdl)
        {
            this.mdl = mdl;
        }

        public DateTime? BirthDay
        {
            get
            {
                return mdl.BirthDay;
            }

            set
            {
                mdl.BirthDay = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mdl.FirstName;
            }

            set
            {
                mdl.FirstName = value;
            }
        }

        public int ID
        {
            get
            {
                return mdl.ID;
            }
        }

        public bool IsValid
        {
            get
            {
                if(IsValidBirthDay && IsValidLastName)
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsValidBirthDay
        {
            get
            {
                if(BirthDay == null)
                {

                    return true;
                }
                else if (mdl.BirthDay.Value.Year > 2018)
                {
                    return false;
                }
                
                return true;
            }
        }

        public bool IsValidLastName
        {
            get
            {
                if(LastName == "" || LastName == null)
                {
                    return false;
                }
                return true;
            }
        }

        public string LastName
        {
            get
            {
                return mdl.LastName;
            }

            set
            {
                mdl.LastName = value;
            }
        }

        public string Notes
        {
            get
            {
                return mdl.Notes;
            }

            set
            {
                mdl.Notes = value;
            }
        }

        public int NumberOfPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ValidationSummary
        {
            get
            {
                if(!IsValidLastName)
                {
                    _ValidSummary += "LastName";
                }
                if(!IsValidBirthDay)
                {
                    _ValidSummary += " Birthday";
                }
                return _ValidSummary;
            }
        }
    }
}