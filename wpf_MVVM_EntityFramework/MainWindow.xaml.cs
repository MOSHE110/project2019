﻿using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL;

namespace wpf_MVVM_EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            #region test
            this.DataContext = new Entitys();
            List<Report> r = new List<Report>()
        {
                  new Report
                  {
                    Id = 10,
                    Report_Id=23,
                    Time = new DateTime(2000,10,10),
                    Name = "Moshe",
                    Report_Adress = "report_Adress",
                    Boom_count = 0,
                    ImagePath = "imagePath",
                    lat = 32.2323,
                    log = 23.345324
                  },
                  new Report {
                Id = 11,
                Report_Id= 123,
                Time = new DateTime(2019,10,10),
                Name = "Netanel",
                Report_Adress = "report_Adress",
                Boom_count = 0,
                ImagePath = "imagePath",
                lat = 32.2323,
                log = 23.345324
                  }
        };
            Drop d = new Drop
            {
                Id = 3,
                Drop_Id = 344981147,
                Drop_Adress = "drop_Adress",
                Drop_time = new DateTime(2010, 10, 10),
                Reports_list = r,
                Real_lat = 2.3333,
                Real_log = 4.5654,
                Estimeated_lat = 2.3333,
                Estimeated_log = 4.5654,

            };
            BL_imp bl = new BL_imp();
            //for (int i = 0; i < 100; i++)
            //{
            //    Random random = new Random();

            //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //    string random_Drop_Adress = new string(Enumerable.Repeat(chars, 8)
            //    .Select(s => s[random.Next(s.Length)]).ToArray());

            //    bl.AddDrop(d);
            //    d.Drop_Adress = random_Drop_Adress;
            //    d.Drop_Id++;
            //}

            //bool flag = true;
          
            //while (flag)
            //    {

            //    flag = bl.RemoveDrop(d.Drop_Id);
            //    d.Drop_Id++;
                
            //    }

            #endregion
            InitializeComponent();
            

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserControls.AnalistPanel();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserControls.DropsMap();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           Main.Content = new UserControls.CollerCenter();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserControls.C1maps();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserControls.loginPanel();

        }
    }
}
    

