using robert_baxter_inventory_system.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace robert_baxter_inventory_system
{
    internal static class Program
    {
        // creating a public static mainlayout to control a single source 
        public static MainLayout MainLayout;

        public static void ResetLayout()
        {
            MainLayout.Refresh();
            MainLayout.Show();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainLayout = new MainLayout();
            Application.Run(MainLayout);
        }
    }
}
