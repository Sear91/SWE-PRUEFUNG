using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class DataAccessLayer : IMoneyDAL
    {
        SqlConnection cnn;
        string connectionString = "user id=shit;password=shit,server=GIGAMATE;database=PicDB;";
        public void DeletePhotographer(int ID)
        {
            cnn.Open();
            SqlCommand delPhotographer = new SqlCommand("Delete From Photographers Where id = @id", cnn);
            delPhotographer.Parameters.Add(new SqlParameter("@id", ID));
            try
            {
                delPhotographer.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void DeletePicture(int ID)
        {
            cnn.Open();
            SqlCommand delPicture = new SqlCommand("Delete From Pictures Where id = @id", cnn);
            delPicture.Parameters.Add(new SqlParameter("@id", ID));
            try
            {
                delPicture.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
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