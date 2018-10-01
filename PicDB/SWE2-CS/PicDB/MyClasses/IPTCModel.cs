using System;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class IPTCModel : IIPTCModel
    {
        private string _byline;
        private string _caption;
        private string _copyRightNotice;
        private string _headline;
        private string _keywords;

        public string ByLine
        {
            get
            {
                return _byline;
            }

            set
            {
                _byline = value;
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }

            set
            {
                _caption = value;
            }
        }

        public string CopyrightNotice
        {
            get
            {
                return _copyRightNotice;
            }

            set
            {
                _copyRightNotice = value;
            }
        }

        public string Headline
        {
            get
            {
                return _headline;
            }

            set
            {
                _headline = value;
            }
        }

        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }
    }
}