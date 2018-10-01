using System;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    internal class SearchViewModel : ISearchViewModel
    {

        private String _searchText ="";
        private int _resultCount = 0;
        private bool _isActive = false;

        public bool IsActive
        {
            get
            {
                if(!string.IsNullOrEmpty(_searchText))
                {
                    _isActive = true;
                }
                else
                {
                    _isActive = false;
                }
                return _isActive;
            }
        }

        public int ResultCount
        {
            get
            {
                return _resultCount;
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }

            set
            {
                _searchText = value;
            }
        }
    }
}