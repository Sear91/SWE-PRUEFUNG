using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using Microsoft.Win32;

namespace PicDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string testMe { get; set; }

        public MainWindow()
        {


            InitializeComponent();
            
            
            //List<Foto> thumbs = new List<Foto>();

            //Foto image;

            //image = new Foto(@"C:\Users\Christoph\Desktop\FH\PicDB\SWE2-CS\PicDB\Resources\Img1.jpg");
            //thumbs.Add(image);
            //image = new Foto(@"C:\Users\Christoph\Desktop\FH\PicDB\SWE2-CS\PicDB\Resources\Img2.jpg");
            //thumbs.Add(image);
            //image = new Foto(@"C:\Users\Christoph\Desktop\FH\PicDB\SWE2-CS\PicDB\Resources\Img3.jpg");
            //thumbs.Add(image);

            //thumbNails.ItemsSource = thumbs;
        }

        //public class Foto
        //{
        //    public Foto(string quelle)
        //    {
        //        source = quelle;
        //    }
        //    public string source { get; set; }
        //}


    }
}
