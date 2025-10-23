

using System;
using System.Windows.Forms;

namespace SimulationsPretsBancaires
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialisation de l'application Windows Forms 
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Démarre sur le formulaire principal
            Application.Run(new Forms.FormulairePrincipal());
        }
    }
}