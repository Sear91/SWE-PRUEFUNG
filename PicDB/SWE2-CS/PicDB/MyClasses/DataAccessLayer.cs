using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    internal class DataAccessLayer : IMoneyDAL
    {
        SqlConnection cnn;
        
        public DataAccessLayer()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\manfr\OneDrive\Dokumente\Alg_prüfung\next shit\PicDB\db.config");
            cnn = new SqlConnection(lines[0]);
            //cnn.Open();
            //int ID = 1;
            //SqlCommand delPhotographer = new SqlCommand("Delete From Pictures Where id = @id", cnn);
            //delPhotographer.Parameters.Add(new SqlParameter("@id", ID));
            //delPhotographer.ExecuteNonQuery();

            

        }
        
         //= "user id=shit;password=shit,server=GIGAMATE;database=PicDB;";
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
            // brauch i ned
            throw new NotImplementedException();
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            // brauchen ma ned
            throw new NotImplementedException();
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            DataTable photographers = new DataTable();

            cnn.Open();
            SqlCommand getPhotographer = new SqlCommand("Select * From Photographers Where id = @id", cnn);
            getPhotographer.Parameters.Add(new SqlParameter("@id", ID));
            SqlDataAdapter phapher = new SqlDataAdapter(getPhotographer);
            phapher.Fill(photographers);
            cnn.Close();

            IPhotographerModel photographer = new PhotographerModel();

            var row = photographers.Rows[0];
            photographer.ID = Int32.Parse(row[0].ToString());
            photographer.FirstName = row[1].ToString();
            photographer.LastName = row[2].ToString();
            photographer.BirthDay = DateTime.Parse((row[3].ToString()));
            photographer.Notes = row[4].ToString();

            return photographer;
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            DataTable photographers = new DataTable();

            cnn.Open();
            SqlCommand getPhotographer = new SqlCommand("Select * From Photographers", cnn);            
            SqlDataAdapter phapher = new SqlDataAdapter(getPhotographer);
            phapher.Fill(photographers);
            cnn.Close();

            
            List<PhotographerModel> listph = new List<PhotographerModel>();
            foreach (DataRow row in photographers.Rows)
            {
                PhotographerModel photographer = new PhotographerModel();
                photographer.ID = Int32.Parse(row[0].ToString());
                photographer.FirstName = row[1].ToString();
                photographer.LastName = row[2].ToString();
                photographer.BirthDay = DateTime.Parse((row[3].ToString()));
                photographer.Notes = row[4].ToString();
                listph.Add(photographer);
            }
            return listph;
        }

        public IPictureModel GetPicture(int ID)
        {
            DataTable pictures = new DataTable();

            cnn.Open();
            SqlCommand getPicture = new SqlCommand("Select * From Pictures Where id = @id", cnn);
            getPicture.Parameters.Add(new SqlParameter("@id", ID));
            SqlDataAdapter phapher = new SqlDataAdapter(getPicture);
            phapher.Fill(pictures);
            cnn.Close();

            IPictureModel picture = new PictureModel();

            var row = pictures.Rows[0];
            picture.ID = Int32.Parse(row[0].ToString());
            picture.FileName = row[1].ToString();           

            return picture;
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            //    DataTable pictures = new DataTable();

            //    cnn.Open();
            //    SqlCommand getPicture = new SqlCommand("Select * From Pictures Where id = @id", cnn);
            //    getPicture.Parameters.Add(new SqlParameter("@id", ID));
            //    SqlDataAdapter phapher = new SqlDataAdapter(getPicture);
            //    phapher.Fill(pictures);
            //    cnn.Close();

            //    IPictureModel picture = new PictureModel();

            //    var row = pictures.Rows[0];
            //    picture.ID = Int32.Parse(row[0].ToString());
            //    picture.FileName = row[1].ToString();

            //    return picture;
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