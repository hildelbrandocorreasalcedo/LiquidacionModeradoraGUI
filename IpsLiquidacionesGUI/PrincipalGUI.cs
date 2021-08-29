using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace IpsLiquidacionesGUI
{
    public partial class PrincipalGUI : Form
    {
        public PrincipalGUI()
        {
            InitializeComponent();
        }

        private void registrarLiquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarLiquidacionGUI registrarLiquidacion = new RegistrarLiquidacionGUI();
            registrarLiquidacion.Show();
        }

        private void consultarLiquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLiquidacionGUI consultarLiquidacion = new ConsultarLiquidacionGUI();
            consultarLiquidacion.Show();
        }
    }
}
