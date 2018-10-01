using System;
using System.Collections.Generic;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using System.IO;
using System.Reflection;

namespace PicDB
{
    internal class BusinessLayer : IBusinessLayer
    {
        private LinkedList<PictureModel> _data = new LinkedList<PictureModel>();
        IMoneyDAL DAL;
        //DalFactory DFactory = new DalFactory();

        public BusinessLayer()
        {
            DAL = DalFactory.Single.GetDAL();

        }

        public void DeletePhotographer(int ID)
        {
            DAL.DeletePhotographer(ID);
        }

        public void DeletePicture(int ID)
        {
            DAL.DeletePicture(ID);
        }

        public IEXIFModel ExtractEXIF(string filename)
        {

            return DAL.ExtractEXIF(filename);
        }

        public IIPTCModel ExtractIPTC(string filename)
        {
            return DAL.ExtractIPTC(filename);
        }

        public ICameraModel GetCamera(int ID)
        {
            return DAL.GetCamera(ID);
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return DAL.GetCameras();
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            return DAL.GetPhotographer(ID);
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return DAL.GetPhotographers();
        }

        public IPictureModel GetPicture(int ID)
        {
            return DAL.GetPicture(ID);
        }

        public IEnumerable<IPictureModel> GetPictures()
        {
            return _data;
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            return DAL.GetPictures(namePart, photographerParts, iptcParts, exifParts);
        }

        public void Save(IPhotographerModel photographer)
        {
            DAL.Save(photographer);
        }

        public void Save(IPictureModel picture)
        {
            DAL.Save(picture);
        }

        public void Sync()
        {

            
            string currentDirectory = Environment.CurrentDirectory.ToString(); 
            Console.WriteLine(currentDirectory);

            string PicFolder;

            Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory().ToString(), "/Pictures"));

            currentDirectory = Directory.GetCurrentDirectory().ToString();
            PicFolder = currentDirectory + "/Pictures";

            //if (File.Exists(Path.Combine(Directory.GetCurrentDirectory().ToString(), "/Pictures")))
            //{
            //    currentDirectory = Directory.GetCurrentDirectory().ToString();
            //    PicFolder = Path.Combine(currentDirectory, "/Pictures");
            //}
            //else
            //{
            //    currentDirectory = Environment.CurrentDirectory;
            //    PicFolder = Path.Combine(currentDirectory, "../../BIF-SS18-SWE2-if16b020/deploy/Pictures");
            //}

             


            var list = Directory.GetFiles(PicFolder, "*");
            if (list.Length > 0)
            {
                for (int i = 0; i < list.Length; i++) { _data.AddFirst(new PictureModel(list[i].ToString())); }
            }



          

            
        }

        public void WriteIPTC(string filename, IIPTCModel iptc)
        {
            
        }
    }
}