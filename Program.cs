using Peripatos.Core;
using Peripatos_UI;

namespace Peripatos_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Database.Connect_PeripatosDB();
            AppList_Manager.Initialize_List_Beaches();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main_Form());
        }
    }
}