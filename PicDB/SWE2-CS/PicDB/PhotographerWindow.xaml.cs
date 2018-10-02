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
    public partial class PhotographerWindow : Window
    {
        


        public PhotographerWindow()
        {
            
            InitializeComponent();
        
        }

        /// <summary>
        /// Die Photographers werden in ein ConfigFile gespeichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePhotographer(object sender, RoutedEventArgs e)
        {

            string photographerData ="";

            foreach (PhotographerViewModel item in this.photographerList.ItemsSource)
            {
                //shit pfad

                photographerData += item.FirstName + ";" + item.LastName + ";" + item.BirthDay + ";" + item.Notes + "\n";
                

                
                Console.WriteLine("Photograph gespeichert");
            }
            System.IO.File.WriteAllText(@"C:\Users\Mausi\Desktop\SWE-PRUEFUNG\PicDB\photographers.config", photographerData);

        }
        /// <summary>
        /// fügt einen Photographen hinzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotographer(object sender, RoutedEventArgs e)
        {
            //List<PhotographerModel> pml = (List < PhotographerModel > )this.photographerList.ItemsSource;
            //PhotographerModel p = new PhotographerModel();
            //p.FirstName = this.firstName.Text;
            //p.LastName = this.lastName.Text;
            //p.Notes = this.notes.Text;
            //pml.Add(p);
            //this.photographerList.ItemsSource = pml;
        }

        /// <summary>
        /// Löscht aktiven Photographen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
