using System;
using System.Collections.Generic;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class IPTCViewModel : IIPTCViewModel
    {
        private string _byline;
        private string _caption;
        private string _copyRightNotice;
        private string _headline;
        private string _keywords;
        private List<string> _copyRightNotices = new List<string>();


        public IPTCViewModel()
        {
            _copyRightNotices.Add("upps");
            _copyRightNotices.Add("upps1");
            _copyRightNotices.Add("upps2");
        }
        public IPTCViewModel(IPTCModel core_model)
        {
            _byline = core_model.ByLine;
            _caption = core_model.Caption;
            _copyRightNotice = core_model.CopyrightNotice;
            _headline = core_model.Headline;
            _keywords = core_model.Keywords;
            _copyRightNotices.Add("upps");
            _copyRightNotices.Add("upps1");
            _copyRightNotices.Add("upps2");

        }

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

        public IEnumerable<string> CopyrightNotices
        {
            get
            {
                return _copyRightNotices;
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