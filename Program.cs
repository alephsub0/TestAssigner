/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* Autor: Víctor Silverio                                       *
* Contacto: vsilverio262@puce.edu.ec                           *
* Creado: 22/abr/2020                                          *
* Última Modificación: 16/sep/2020                             *
* Licencia: GNU GPLv3                                          *
* Descripción: Punto de entrada principal para la aplicación.  *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssigner
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuPrincipal());
        }
    }
}
