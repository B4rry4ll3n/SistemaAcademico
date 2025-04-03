using System;
using System.IO;
using MauiApp3.Data;
using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "anchieta.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
    }
}