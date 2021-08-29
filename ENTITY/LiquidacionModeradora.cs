using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class LiquidacionModeradora
    {
        public string NumeroDeLiquidacion { get; set; }
        public string Identificacion { get; set; }

        public string TipoAfiliacion { get; set; }
         public DateTime Fecha { get; set; }
         public string Nombrepaciente { get; set; }
        public decimal SalarioPaciente { get; set; }
        public decimal ValorServicio { get; set;}

        public decimal TopeMaximo { get; set; }
        public decimal Tarifa { get; set; }
       
        public decimal CuotaModeradora { get; set; }
        public decimal SalarioMinimo = 890000;
        public  abstract void EstablecerTarifa();
        public abstract void EstablecerTopeMaximo();

        public LiquidacionModeradora(string numerodeLiquidacion, string identificacion, string tipoAfilicion,DateTime fecha ,string nombrePaciente,decimal salarioPaciente, decimal valorServicio)
        {
            NumeroDeLiquidacion = numerodeLiquidacion;
            Identificacion = identificacion;
            TipoAfiliacion = tipoAfilicion;
            Fecha = fecha;
            Nombrepaciente = nombrePaciente;
            SalarioPaciente = salarioPaciente;
            ValorServicio = valorServicio;
        }
       public LiquidacionModeradora()
        {
        }

        public void CalcularCuota()
        {
            CuotaModeradora = ValorServicio * Tarifa;
            if (CuotaModeradora > TopeMaximo)
            {
                CuotaModeradora = TopeMaximo;
            }

        }
         public override string ToString()
        {
            return $"{NumeroDeLiquidacion};{Identificacion};{TipoAfiliacion};{Fecha};^{Nombrepaciente};{SalarioPaciente};{ValorServicio};{Tarifa};{TopeMaximo};{CuotaModeradora}";
        }


    }
}
