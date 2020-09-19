/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
* Autor: Víctor Silverio                                 *
* Contacto: vsilverio262@puce.edu.ec                     *
* Creado: 22/abr/2020                                    *
* Última Modificación: 16/sep/2020                       *
* Licencia: GNU GPLv3                                    *
* Descripción: Código detrás del diseño de créditos      *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssigner
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLAleph.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.alephsub0.org/about/");
        }
    }
}
