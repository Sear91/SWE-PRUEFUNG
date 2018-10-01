using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class MockDAL : IMoneyDAL
    {
        // Tables of Fake DB
        List<ICameraModel> cameraTable = new List<ICameraModel>();
        List<IPhotographerModel> photographerTable = new List<IPhotographerModel>();
        List<IPictureModel> pictureTable = new List<IPictureModel>();
        List<PictureModel> pictest = new List<PictureModel>();


        public void DeletePhotographer(int ID)
        {
            int index = photographerTable.FindIndex(a => a.ID == ID);
            photographerTable.RemoveAt(index);
        }

        public void DeletePicture(int ID)
        {
            int index = pictureTable.FindIndex(a => a.ID == ID);
            pictureTable.RemoveAt(index);
        }

        public ICameraModel GetCamera(int ID)
        {
            // TO DO - Select where Camera = ID and return this Camera
            CameraModel newCamera = new CameraModel("", "");
            newCamera.ID = ID;
            cameraTable.Add(newCamera);
            return newCamera;
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            if(!cameraTable.Any())
            {
                cameraTable.Add(new CameraModel("", ""));
                cameraTable.Add(new CameraModel("", ""));
                cameraTable.Add(new CameraModel("", ""));
                cameraTable.Add(new CameraModel("", ""));
            }
            return cameraTable;
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            photographerTable.Add(new PhotographerModel() { ID = ID });
            int index = photographerTable.FindIndex(a => a.ID == ID);
            return photographerTable[index];
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            PhotographerModel newPhotographer0 = new PhotographerModel();
            PhotographerModel newPhotographer1 = new PhotographerModel();

            newPhotographer0.ID = 1;
            newPhotographer1.ID = 10;

            photographerTable.Add(newPhotographer0);
            photographerTable.Add(newPhotographer1);

            return photographerTable;
        }

        public IPictureModel GetPicture(int ID)
        {
            pictureTable.Add(new PictureModel("") { ID = ID });
            int index = pictureTable.FindIndex(a => a.ID == ID);
            return pictureTable[index];
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            if (pictureTable.Count == 0)
            {
                PictureModel newPicture0;

                if (string.IsNullOrWhiteSpace(namePart))
                {
                    newPicture0 = new PictureModel("");
                }
                else
                {
                    newPicture0 = new PictureModel(namePart);
                }


                newPicture0.ID = 1;


                pictureTable.Add(newPicture0);
            }
            

            return pictureTable;

        }

        public void Save(IPictureModel picture)
        {
            pictureTable.Add(picture);
            
        }

        public void Save(IPhotographerModel photographer)
        {
            photographerTable.Add(photographer);
        }

        public IEXIFModel ExtractEXIF(string filename)
        {
            pictureTable.Add(new PictureModel("Img1.jpg") { EXIF = new EXIFModel() { ExposureTime = 1, FNumber = 2, ISOValue = 100, Make = "haha" } });
            try
            {
                int index = pictureTable.FindIndex(a => a.FileName == filename);
                return pictureTable[index].EXIF;
            }
            catch(Exception e)
            {
                throw new ArgumentNullException("the picture doesn´t exist!", e);
            }
            
        }
        public IIPTCModel ExtractIPTC(string filename)
        {
            pictureTable.Add(new PictureModel("Img1.jpg") { IPTC = new IPTCModel() { ByLine = "test1", Caption = "test2", CopyrightNotice = "illegal copy", Headline = "XD", Keywords = "d&d" } });
            try
            {
                int index = pictureTable.FindIndex(a => a.FileName == filename);
                return pictureTable[index].IPTC;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("the picture doesn´t exist!", e);
            }

        }


    }
}
