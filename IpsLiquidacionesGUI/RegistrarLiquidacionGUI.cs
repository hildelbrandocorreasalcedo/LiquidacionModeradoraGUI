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
    public partial class RegistrarLiquidacionGUI : Form
    {  LiquidacionModeradoraService liquidacionmoderadoraservice = new LiquidacionModeradoraService();
        public RegistrarLiquidacionGUI()
        {
            InitializeComponent();
        }

        private void RegistrarLiquidacionGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            LiquidacionModeradora liquidacionmoderadora = MapearLiquidacion();
            string mensaje = liquidacionmoderadoraservice.Guardar(liquidacionmoderadora);
            MessageBox.Show(mensaje);
        }

       public LiquidacionModeradora MapearLiquidacion() {
            LiquidacionModeradora liquidacionmoderadora;
           
            if (TipoCmb.SelectedIndex==0)
            {
                liquidacionmoderadora = new LiquidacionModeradoraContributiva();
               

            }
            else 
            {
                liquidacionmoderadora = new LiquidacionModeradoraSubsidiada();
              }
            liquidacionmoderadora.NumeroDeLiquidacion = NumeroLiquidacionTxt.Text;
            liquidacionmoderadora.Identificacion = IdentificacionTxt.Text;
            liquidacionmoderadora.TipoAfiliacion = TipoCmb.Text;
            liquidacionmoderadora.Fecha = DtFechaLiquidacion.Value.Date;
            liquidacionmoderadora.Nombrepaciente = Nombrepacientetxt.Text;
            liquidacionmoderadora.ValorServicio = decimal.Parse(ValorServicioTxt.Text);
            liquidacionmoderadora.SalarioPaciente = decimal.Parse(SalarioPacienteTxt.Text);
            liquidacionmoderadora.EstablecerTarifa();
            TarifatTxt.Text = liquidacionmoderadora.Tarifa.ToString();
            liquidacionmoderadora.EstablecerTopeMaximo();
            Topetxt.Text = liquidacionmoderadora.TopeMaximo.ToString();
            liquidacionmoderadora.CalcularCuota();
            CuotamoderadoraTxt.Text = liquidacionmoderadora.CuotaModeradora.ToString();
            return liquidacionmoderadora;

        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            NumeroLiquidacionTxt.Text = "";
            IdentificacionTxt.Text = "";
            TipoCmb.Text = "";
            ValorServicioTxt.Text = "";
            SalarioPacienteTxt.Text = "";
            TarifatTxt.Text = "";
             Topetxt.Text = "";
            CuotamoderadoraTxt.Text = "";


        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string numeroloquidacion = NumeroLiquidacionTxt.Text;


            if (numeroloquidacion != "")
            {
                RespuestaBusqueda respuesta =liquidacionmoderadoraservice.Buscar( numeroloquidacion);

                if (respuesta.liquidacionmoderadora != null)
                {
                   LiquidacionModeradora liquidacionmoderadora = respuesta.liquidacionmoderadora;
                    IdentificacionTxt.Text = liquidacionmoderadora.Identificacion;
                    TipoCmb.Text = liquidacionmoderadora.TipoAfiliacion;
                    ValorServicioTxt.Text = liquidacionmoderadora.ValorServicio.ToString();
                    SalarioPacienteTxt.Text = liquidacionmoderadora.SalarioPaciente.ToString();
                     TarifatTxt.Text = liquidacionmoderadora.Tarifa.ToString();
                    Topetxt.Text = liquidacionmoderadora.TopeMaximo.ToString();
                    CuotamoderadoraTxt.Text = liquidacionmoderadora.CuotaModeradora.ToString();



                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {numeroloquidacion} no se encuentra registrada");
                }

            }
            else
            {
                MessageBox.Show("digite una identificacion a buscar");
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string numeroliquidacion = NumeroLiquidacionTxt.Text;
            if (numeroliquidacion != "")
            {
                RespuestaBusqueda respuesta = liquidacionmoderadoraservice.Buscar(numeroliquidacion);
                if (respuesta.liquidacionmoderadora!= null)
                {
                    numeroliquidacion = NumeroLiquidacionTxt.Text;
                    var mensaje = liquidacionmoderadoraservice.Eliminar(numeroliquidacion);
                    MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"La persona con la identificación {numeroliquidacion} no se encuentra registrada");
                }


            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            if (IdentificacionTxt.Text != "" && NumeroLiquidacionTxt.Text != "" && TipoCmb.Text != "" && ValorServicioTxt.Text != "" && SalarioPacienteTxt.Text != "")
            {
               LiquidacionModeradora liquidacionmoderadora= MapearLiquidacion();
                
                liquidacionmoderadora.EstablecerTarifa();
                liquidacionmoderadora.EstablecerTopeMaximo();
                liquidacionmoderadora.CalcularCuota();
                string mensaje = liquidacionmoderadoraservice.Modificar(liquidacionmoderadora);
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("rectifique los campos");
            }
        }
    }
    }

