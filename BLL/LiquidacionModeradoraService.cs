using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;


namespace BLL
{
    public class LiquidacionModeradoraService
    {
        private LiquidacionModeradoraRepository liquidacionesRepositorio;

        public LiquidacionModeradoraService()
        {
            liquidacionesRepositorio = new LiquidacionModeradoraRepository();
        }
        public string Guardar(LiquidacionModeradora liquidacionmoderadora)
        {
            try
            {
                if (liquidacionesRepositorio.Buscar(liquidacionmoderadora.NumeroDeLiquidacion) == null)
                {
                    liquidacionesRepositorio.Guardar(liquidacionmoderadora);
                    return $"Los datos de la liquidacion numero {liquidacionmoderadora.NumeroDeLiquidacion} han sido guardados correctamente";
                }
                return $"No es posible registrar la cuenta con numero {liquidacionmoderadora.NumeroDeLiquidacion}, porque ya se encuentra registrada";
            }
            catch (Exception E)
            {
                return "Error de lectura " + E.Message;
            }
        }
        public string Eliminar(string numerodeliquidacion)
        {
            try
            {
                if (liquidacionesRepositorio.Buscar(numerodeliquidacion) != null)
                {

                    liquidacionesRepositorio.Eliminar(numerodeliquidacion);
                    return $"La liquidacion con Numero {numerodeliquidacion} ha sido eliminada satisfacatoriamente";
                }
                return $"La Liquidacion {numerodeliquidacion} no se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }
        public string Modificar(LiquidacionModeradora liquidacionmoderadora)
        {
            try
            {
                if (liquidacionesRepositorio.Buscar(liquidacionmoderadora.NumeroDeLiquidacion) != null)
                {

                    liquidacionesRepositorio.Modificar(liquidacionmoderadora);
                    return $"Los liquidacion con numero {liquidacionmoderadora.NumeroDeLiquidacion} ha sido modificada satisfacatoriamente";
                }
                return $"La liquidacion {liquidacionmoderadora.NumeroDeLiquidacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }

        }
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                IList<LiquidacionModeradora> liquidacionescuotas = liquidacionesRepositorio.Consultar();
                if (liquidacionescuotas.Count != 0)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de liquidaciones";
                    respuesta.liquidacionesCuotas= liquidacionescuotas;
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                    respuesta.liquidacionesCuotas = null;
                }

            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
                respuesta.liquidacionesCuotas = null;
            }
            return respuesta;

        }
        public RespuestaBusqueda Buscar(string numeroliquidacion)
        {
            RespuestaBusqueda respuesta = new RespuestaBusqueda();
            try
            {
                respuesta.Error = false;
                LiquidacionModeradora Liquidacionmoderadora= liquidacionesRepositorio.Buscar(numeroliquidacion);
                if (Liquidacionmoderadora == null)
                {
                    respuesta.Mensaje = $"La Liquidaacion con  numero {numeroliquidacion} no se encuentra registrada";
                    respuesta.liquidacionmoderadora= null;
                }
                else
                {
                    respuesta.liquidacionmoderadora =Liquidacionmoderadora;
                    respuesta.Mensaje = "liquidacion encontrada\n\n";
                }
            }
            catch (Exception E)
            {
                respuesta.Mensaje = "Error de lectura o escritura de archivos: " + E.Message;
                respuesta.liquidacionmoderadora = null;
                respuesta.Error = true;
            }
            return respuesta;
        }
        public int TotalizarLiquidaciones()
        {
            return liquidacionesRepositorio.TotalizarLiquidaciones();
        }

        public int TotalizarLiquidacionesSubsidiadas()
        {
            return liquidacionesRepositorio.TotalizarLiquidacionesSubsidiadas();
        }

        public int TotalizarLiquidacionesContributivas()
        {
            return liquidacionesRepositorio.TotalizarLiquidacionesContributivas();
        }

        public IList<LiquidacionModeradora> ListaSubsidiadas()
        {
            return liquidacionesRepositorio.ListaSubsidiadas();
        }


        public IList<LiquidacionModeradora> ListaContributivas()
        {
            return liquidacionesRepositorio.ListaContributivas();
        }

        public decimal SumarCuotas() {
            return liquidacionesRepositorio.SumarCuotas(); 
                }
        public decimal SumarCuotasSubsidiadas()
        {

            return liquidacionesRepositorio.SumarCuotasSubsidiadas();
        }
        public decimal SumarCuotasContributivas()
        {

            return liquidacionesRepositorio.SumarCuotasContributivas();
        }
        public IList<LiquidacionModeradora> ConsultarXFecha(DateTime fecha)
        {
            return liquidacionesRepositorio.ConsultarXFecha(fecha);
        }

        public IList<LiquidacionModeradora> ConsultarXFechaSubsidiadas(DateTime fecha)
        {
          return liquidacionesRepositorio.ConsultarXFechaSubsidiadas(fecha);
        }

        public IList<LiquidacionModeradora> ConsultarXFechaContributivas(DateTime fecha) {
            return liquidacionesRepositorio.ConsultarXFechaContributivas(fecha);
        }


        public IList<LiquidacionModeradora> ConsultaPorNombre(string nombre)
        {
            return liquidacionesRepositorio.ConsultaPorNombre(nombre);
        }

    }
}
