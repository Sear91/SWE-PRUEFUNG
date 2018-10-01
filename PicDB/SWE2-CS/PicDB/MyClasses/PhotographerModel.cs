using System;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class PhotographerModel : IPhotographerModel
    {
        int _id;
        private DateTime? _Birthday;
        private string _firstname;
        private string _lastname;
        private string _notes;

        public DateTime? BirthDay
        {
            get
            {
                return _Birthday;
            }

            set
            {
                _Birthday = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }

        public int ID
        {
            get
            {
                if (_id == 0)
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

        public string LastName
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
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
    }
}