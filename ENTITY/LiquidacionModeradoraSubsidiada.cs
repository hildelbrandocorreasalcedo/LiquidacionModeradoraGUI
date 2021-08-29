using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class LiquidacionModeradoraSubsidiada : LiquidacionModeradora
    {
        public LiquidacionModeradoraSubsidiada()
        {
        }

        public LiquidacionModeradoraSubsidiada(string numerodeLiquidacion,string identificacion,string tipoAfiliacion,DateTime fecha,string nombrePaciente,decimal valordeServicio) : 
            base(numerodeLiquidacion,identificacion,"subsidiada",fecha,nombrePaciente,0,valordeServicio)
        {
        }
        public override void EstablecerTarifa()
        {
            Tarifa = (decimal)0.05;

        }
         public override void EstablecerTopeMaximo()
        {
            TopeMaximo = 200000;
        }
    }
}
