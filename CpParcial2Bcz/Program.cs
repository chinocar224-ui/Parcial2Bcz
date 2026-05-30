// CpParcial2Bcz - Capa de Presentación
// Punto de entrada de la aplicación

using System;
using System.Windows.Forms;

namespace CpParcial2Bcz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrograma());
        }
    }
}
