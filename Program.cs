using Etat_civil.Layouts;
using Etat_civil.Layouts.Admin;
using Etat_civil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etat_civil
{
    static class Program
    {
        public static Authentification auth;
        public static Main main;
        public static User user;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            auth = new Authentification();
            main = new Main();
            Application.Run(auth);
        }
    }
}
