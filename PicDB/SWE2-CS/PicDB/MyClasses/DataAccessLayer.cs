using System;
using System.Collections.Generic;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class DataAccessLayer : IMoneyDAL
    {
        public void DeletePhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        public void DeletePicture(int ID)
        {
            throw new NotImplementedException();
        }

        public ICameraModel GetCamera(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            throw new NotImplementedException();
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return null;
        }

        public IPictureModel GetPicture(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            throw new NotImplementedException();
        }

        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }

        public void Save(IPictureModel picture)
        {
            throw new NotImplementedException();
        }
        public IEXIFModel ExtractEXIF(string filename)
        {
            //pictureTable.Add(new PictureModel("Img1.jpg") { EXIF = new EXIFModel() { ExposureTime = 1, FNumber = 2, ISOValue = 100, Make = "haha" } });
            //int index = pictureTable.FindIndex(a => a.FileName == filename);
            //return pictureTable[index].EXIF;
            throw new NotImplementedException();
        }
        public IIPTCModel ExtractIPTC(string filename)
        {
            throw new NotImplementedException();
        }
    }
}