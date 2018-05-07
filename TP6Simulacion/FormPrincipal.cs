using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6Simulacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            List<Int64> lista = new List<long>();
            Proceso p = new Proceso();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(p.generarRafagaCPU());
            }
        }
    }
}
