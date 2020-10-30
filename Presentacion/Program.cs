using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Formularios;

/// <summary>
/// si recompilas la solucion genera los 3: persistencia y negio y el .exe
/// a esto se le va a adiocionar, a la solucion 2 pruyectos mas, ahora te mostre la opcion
/// estableci presentacion ocmo proyecto de inicio
/// 
/// </summary>

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
