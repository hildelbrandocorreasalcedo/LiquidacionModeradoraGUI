using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    public class LiquidacionModeradoraRepository
    {
        private string ruta = @"Liquidacioncuotamoderadoras.txt";
        public IList<LiquidacionModeradora> liquidacionesCuotas;

        public LiquidacionModeradoraRepository()
        {
            liquidacionesCuotas = new List<LiquidacionModeradora>();
        }
        public void Guardar(LiquidacionModeradora liquidacionmoderadora)

        {
            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter stream = new StreamWriter(fileStream);
            stream.WriteLine(liquidacionmoderadora.ToString());
            stream.Close();
            fileStream.Close();

        }


        public IList<LiquidacionModeradora> Consultar()
        {
            liquidacionesCuotas.Clear();
            FileStream filestream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(filestream);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {

                LiquidacionModeradora liquidacionmoderadora = MapearLiquidacionModeradora(linea);
                liquidacionesCuotas.Add(liquidacionmoderadora);
            }
            filestream.Close();
            reader.Close();
            return liquidacionesCuotas;
        }

        public LiquidacionModeradora MapearLiquidacionModeradora(string linea)
        {
            string[] datos = linea.Split(';');
            string NumerodeLiquidacion = datos[0];
            string Identificacion = datos[1];
            string TipodeAfiliacion = datos[2];
            DateTime Fecha = DateTime.Parse(datos[3]);
            string NombrePaciente = datos[4];
            decimal SalariodePaciente = decimal.Parse(datos[5]);
            decimal ValordeServicio = decimal.Parse(datos[6]);
            decimal Tarifa = decimal.Parse(datos[7]);
            decimal TopeMaximo = decimal.Parse(datos[8]);
            decimal Cuotareal = decimal.Parse(datos[9]);



            if (TipodeAfiliacion == "C")
            {
                LiquidacionModeradora liquidacioncuotamoderadoracontributiva = new LiquidacionModeradoraContributiva(NumerodeLiquidacion, Identificacion, TipodeAfiliacion, Fecha, NombrePaciente, SalariodePaciente, ValordeServicio);

                liquidacioncuotamoderadoracontributiva.Tarifa = Tarifa;
                liquidacioncuotamoderadoracontributiva.TopeMaximo = TopeMaximo;
                liquidacioncuotamoderadoracontributiva.CuotaModeradora = Cuotareal;
                return liquidacioncuotamoderadoracontributiva;
            }

            else
            {
                LiquidacionModeradora liquidacioncuotamoderadorasubsidiada = new LiquidacionModeradoraSubsidiada(NumerodeLiquidacion, Identificacion, TipodeAfiliacion, Fecha, NombrePaciente, ValordeServicio);
                liquidacioncuotamoderadorasubsidiada.Tarifa = Tarifa;
                liquidacioncuotamoderadorasubsidiada.TopeMaximo = TopeMaximo;
                liquidacioncuotamoderadorasubsidiada.CuotaModeradora = Cuotareal;

                return liquidacioncuotamoderadorasubsidiada;
            }

        }

        public void Eliminar(string Numerodeliquidacion)
        {
            liquidacionesCuotas.Clear();
            liquidacionesCuotas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidacionesCuotas)
            {
                if (item.NumeroDeLiquidacion != Numerodeliquidacion)
                {
                    Guardar(item);
                }
            }

        }

        public LiquidacionModeradora Buscar(string numerodeliquidacion)
        {
            liquidacionesCuotas.Clear();
            liquidacionesCuotas = Consultar();

            foreach (var item in liquidacionesCuotas)
            {
                if (item.NumeroDeLiquidacion.Equals(numerodeliquidacion))
                {
                    return item;
                }
            }
            return null;
        }

        public void Modificar(LiquidacionModeradora liquidacionmoderadora)
        {
            liquidacionesCuotas.Clear();
            liquidacionesCuotas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in liquidacionesCuotas)
            {
                if (item.NumeroDeLiquidacion != liquidacionmoderadora.NumeroDeLiquidacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacionmoderadora);
                }
            }

        }

        public int TotalizarLiquidaciones()
        {
            return liquidacionesCuotas.Count();
        }

        public int TotalizarLiquidacionesSubsidiadas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "subsidiada").Count();
        }

        public int TotalizarLiquidacionesContributivas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "contributiva").Count();
        }

        public IList<LiquidacionModeradora> ListaSubsidiadas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "subsidiada").ToList();
        }
        public IList<LiquidacionModeradora> ListaContributivas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "contributiva").ToList();
        }

        public decimal SumarCuotas() {
            return liquidacionesCuotas.Sum(l => l.CuotaModeradora);

        }
        public decimal SumarCuotasSubsidiadas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "subsidiada").Sum(l => l.CuotaModeradora);
        }

        public decimal SumarCuotasContributivas()
        {
            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "contributiva").Sum(l => l.CuotaModeradora);
        }

        public IList<LiquidacionModeradora> ConsultarXFecha(DateTime fecha) {
            return liquidacionesCuotas.Where(l => l.Fecha.Year.Equals(fecha.Year) && l.Fecha.Month.Equals(fecha.Month)).ToList(); 
        }  
        
        public IList<LiquidacionModeradora>ConsultarXFechaSubsidiadas(DateTime fecha)
        {

            return liquidacionesCuotas.Where(l=> l.TipoAfiliacion =="subsidiada").Where(l => l.Fecha.Year.Equals(fecha.Year) && l.Fecha.Month.Equals(fecha.Month)).ToList();
        }

        public IList<LiquidacionModeradora> ConsultarXFechaContributivas(DateTime fecha) {

            return liquidacionesCuotas.Where(l => l.TipoAfiliacion == "contributiva").Where(l => l.Fecha.Year.Equals(fecha.Year) && l.Fecha.Month.Equals(fecha.Month)).ToList();

        }

        public IList<LiquidacionModeradora> ConsultaPorNombre(string nombre)
        {
            return liquidacionesCuotas.Where(l => l.Nombrepaciente.Contains(nombre)).ToList();
        }
       
    } 
}
