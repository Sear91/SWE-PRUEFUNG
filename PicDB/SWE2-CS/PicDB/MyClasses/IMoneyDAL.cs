using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    public interface IMoneyDAL : IDataAccessLayer
    {

        IEXIFModel ExtractEXIF(string filename);
        IIPTCModel ExtractIPTC(string filename);
        

        
    }
}
