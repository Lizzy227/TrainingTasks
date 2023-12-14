using Microsoft.VisualBasic.ApplicationServices;
using System;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;
using Task2_HierarchicalStructure.View;

namespace Task2_HierarchicalStructure
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();



            //Instantiate
            PersonModel personModel = PersonModel.GetInstance();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new PersonList());
        }
    }
}