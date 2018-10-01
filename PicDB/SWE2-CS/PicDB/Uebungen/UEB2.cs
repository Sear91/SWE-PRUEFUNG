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
    public class UEB2 : IUEB2
    {
        public void HelloWorld()
        {
        }

        public IBusinessLayer GetBusinessLayer()
        {
            return new BusinessLayer();
        }

        public IMainWindowViewModel GetMainWindowViewModel()
        {
            return new MainWindowViewModel();
        }

        public IPictureModel GetPictureModel(string filename)
        {
            return new PictureModel(filename);
        }

        public IPictureViewModel GetPictureViewModel(IPictureModel mdl)
        {
            return new PictureViewModel((PictureModel)mdl);
        }

        public void TestSetup(string picturePath)
        {
            
        }

        public ICameraModel GetCameraModel(string producer, string make)
        {
            return new CameraModel(producer, make);
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
            return new CameraViewModel();
        }
    }
}
