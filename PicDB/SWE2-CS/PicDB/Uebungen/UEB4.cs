using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    public class UEB4 : IUEB4
    {
        public void HelloWorld()
        {
           
        }

        public IBusinessLayer GetBusinessLayer()
        {
            DalFactory.Single.IsFake = true;
            return new BusinessLayer();
        }

        public void TestSetup(string picturePath)
        {
            
        }

        public IEXIFModel GetEmptyEXIFModel()
        {
            return new EXIFModel();
        }

        public IEXIFViewModel GetEXIFViewModel(IEXIFModel mdl)
        {
            return new EXIFViewModel((EXIFModel)mdl);
        }

        public IIPTCModel GetEmptyIPTCModel()
        {
            return new IPTCModel();
        }

        public IIPTCViewModel GetIPTCViewModel(IIPTCModel mdl)
        {
            return new IPTCViewModel((IPTCModel)mdl);
        }

        public ICameraModel GetCameraModel(string producer, string make)
        {
            return new CameraModel(producer, make);
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            return new CameraViewModel((CameraModel)mdl);
        }
    }
}
