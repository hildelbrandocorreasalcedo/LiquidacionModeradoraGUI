using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LiquidacionModeradoraContributiva : LiquidacionModeradora
    {
        public LiquidacionModeradoraContributiva()
        {
        }

        public LiquidacionModeradoraContributiva(string numerodeLiquidacion, string identificacion,string tipoAfiliacion,DateTime fecha,string nombrePaciente,decimal salarioPaciente,decimal valorServicio) : 
            base(numerodeLiquidacion,identificacion,"contributiva",fecha,nombrePaciente,salarioPaciente,valorServicio)
        {
        }
        public override void EstablecerTarifa()
        {
            if (SalarioPaciente < SalarioMinimo * 2)
            {
                Tarifa = (decimal)0.15;
            }
            else if (SalarioPaciente > SalarioMinimo * 5)
            {
                Tarifa = (decimal)0.25;
            }
            else
            {
                Tarifa = (decimal)0.20;
            }
        }

        public override void EstablecerTopeMaximo()
        {
            if (SalarioPaciente < SalarioMinimo * 2)
            {
                TopeMaximo = 250000;
            }
            else if (SalarioPaciente > SalarioMinimo * 5)
            {

                TopeMaximo = 1500000;
            }
            else
            {

                TopeMaximo = 900000;
            }
        }
    }
}
