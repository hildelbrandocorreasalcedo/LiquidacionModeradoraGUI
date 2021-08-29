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
    public partial class ConsultarLiquidacionGUI : Form
    {
        LiquidacionModeradoraService liquidacionService= new LiquidacionModeradoraService();
        RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
        string TotalLiquidacionesinscritas;
        string TotalLiquidacionesSubsidiadas;
        string TotalLiquidacionesContributivas;
        string TotalCuotasGenerales;
        string TotalcuotasSubsidiadas;
        string TotalcuotasContributivas;
        public ConsultarLiquidacionGUI()
        {
            InitializeComponent();
        }

        private void ConsultarLiquidacionGUI_Load(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = liquidacionService.Consultar();
            TotalLiquidacionesinscritas = liquidacionService.TotalizarLiquidaciones().ToString();
            TotalLiquidacionesSubsidiadas = liquidacionService.TotalizarLiquidacionesSubsidiadas().ToString();
            TotalLiquidacionesContributivas = liquidacionService.TotalizarLiquidacionesContributivas().ToString();
            TotalCuotasGenerales = liquidacionService.SumarCuotas().ToString();

            Consultar();
        }

        private void Consultar()

        {
            string Tipo = TipoConsulta.Text;

            if (Tipo.Equals("Liquidaciones"))
            {
                respuestaConsulta = liquidacionService.Consultar();
                dataGridView1.DataSource = respuestaConsulta.liquidacionesCuotas;
                TotalCuotasGenerales = liquidacionService.SumarCuotas().ToString();
                TotalcuotasSubsidiadas = "0";
                TotalcuotasContributivas = "0";
            }
            else if (Tipo.Equals("Subsidiadas"))
            {
                dataGridView1.DataSource = liquidacionService.ListaSubsidiadas();
                TotalLiquidacionesinscritas = TotalLiquidacionesSubsidiadas;
                TotalLiquidacionesContributivas = "0";
                TotalCuotasGenerales = "0";
                TotalcuotasSubsidiadas = liquidacionService.SumarCuotasSubsidiadas().ToString();
                TotalcuotasContributivas = "0";

            }
            else if (Tipo.Equals("Contributivas"))
            {
                dataGridView1.DataSource = liquidacionService.ListaContributivas();
                TotalLiquidacionesinscritas = TotalLiquidacionesContributivas;
                TotalLiquidacionesSubsidiadas = "0";
                TotalCuotasGenerales = "0";
                TotalcuotasContributivas = liquidacionService.SumarCuotasContributivas().ToString();
                TotalcuotasSubsidiadas = "0";
            }
            else if (Tipo.Equals("ConsultarXfecha"))
            {


                DateTime fecha = DtConsultarfecha.Value.Date;
                dataGridView1.DataSource = liquidacionService.ConsultarXFecha(fecha);
                TotalCuotasGenerales = liquidacionService.SumarCuotas().ToString();
                TotalLiquidacionesSubsidiadas = "0";
                TotalLiquidacionesContributivas = "0";
                TotalcuotasSubsidiadas = "0";
                TotalcuotasContributivas = "0";


            }
            else if (Tipo.Equals("ConsultarXfechasubsidiadas"))
            {
                DateTime fecha = DtConsultarfecha.Value.Date;
                dataGridView1.DataSource = liquidacionService.ConsultarXFechaSubsidiadas(fecha);
                TotalLiquidacionesinscritas = TotalLiquidacionesSubsidiadas;
                TotalLiquidacionesContributivas = "0";
                TotalcuotasSubsidiadas = liquidacionService.SumarCuotasSubsidiadas().ToString();
                TotalCuotasGenerales = "0";
                TotalcuotasContributivas = "0";

            }

            else if (Tipo.Equals("ConsultarXfechacontributivas")) {

                DateTime fecha = DtConsultarfecha.Value.Date;
                dataGridView1.DataSource = liquidacionService.ConsultarXFechaContributivas(fecha);
                TotalLiquidacionesinscritas = TotalLiquidacionesContributivas;
                TotalLiquidacionesSubsidiadas = "0";
                TotalcuotasContributivas = liquidacionService.SumarCuotasContributivas().ToString();
                TotalCuotasGenerales = "0";
                TotalcuotasSubsidiadas = "0";

                    }

          LlenarCampos();
        }

        private void LlenarCampos()
        {
            Liquidacionestxt.Text =TotalLiquidacionesinscritas;
           subsidiadastxt.Text = TotalLiquidacionesSubsidiadas;
             contributivastxt.Text= TotalLiquidacionesContributivas;
            ValorTotalLiquidacionestxt.Text = TotalCuotasGenerales;
            TotalSubsidiadastxt.Text= TotalcuotasSubsidiadas;
            TotalContributivastxt.Text = TotalcuotasContributivas;
       }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
