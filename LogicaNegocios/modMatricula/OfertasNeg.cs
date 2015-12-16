using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.modMatricula;
using Entidades.eMatricula;
using System.Data;
using Entidades;
using LogicaNegocios.modConfiguracion;

namespace LogicaNegocios.modMatricula
{
    public class OfertasNeg
    {
        // Acceso a ofertas
        private AccesoOfertas ofertasDAL;

        public OfertasNeg()
        {
            ofertasDAL = new AccesoOfertas();
        } 

        /// <summary>
        /// Consultar tabla de ofertas
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView ConsultarOfertas(EOferta consulta)
        {
            DataTable tabla = ofertasDAL.ConsultarOfertas(consulta);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Recuperar tabla con historial de la oferta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarHistorialOferta(int idOferta)
        {
            DataTable tabla = ofertasDAL.CargarHistorialOferta(idOferta);
            return tabla.AsDataView();
        }

        /// <summary>
        /// Registra una oferta
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>true - si el procedimiento tuvo éxito</returns>
        public bool RegistrarOferta(EOferta oferta)
        {
            try
            {
                if (ofertasDAL.RegistrarOferta(oferta) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = oferta.LoginUsuario;
                    entrada.Accion = "Registrar oferta";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado la oferta '" + oferta.Nombre +
                                         "' con la siguiente información: " +
                                         "estado = " + oferta.Estado + ", " +
                                         "Sede = " + oferta.Sede + ", " +
                                         "Fecha y hora de matrícula = " + oferta.FechaRegistro + ", " +
                                         "Observaciones = " + oferta.Observacion;
                    entrada.Entidad = oferta.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Cambia el estado de la oferta y actualiza el historial
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>true - si el procedimiento tuvo éxito</returns>
        public bool CambiarEstadoOferta(EOferta oferta, string anterior, string nuevo)
        {
            try
            {
                if (anterior.Equals("En matrícula") && !nuevo.Equals("En matrícula") ||
                    !anterior.Equals("En matrícula") && nuevo.Equals("En matrícula"))
                {
                    if (ofertasDAL.CambiarEstadoOferta(oferta) != 0)
                    {
                        // Notificar a bitácora
                        EBitacora entrada = new EBitacora();
                        entrada.LoginUsuario = oferta.LoginUsuario;
                        entrada.Accion = "Cambiar estado de oferta";
                        entrada.TipoEvento = "Modificar";
                        entrada.Descripcion = "El estado de la oferta '" + oferta.Nombre +
                                              "' fue cambiado de '" + anterior + "' a '" +
                                              nuevo + "'.";
                        entrada.Entidad = oferta.Nombre;
                        new ReporteNeg().RegistrarBitacora(entrada);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Método para modificar una oferta
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>true - si el procedimiento tuvo éxito</returns>
        public bool ModificarOferta(EOferta oferta)
        {
            try
            {
                if (ofertasDAL.ModificarOferta(oferta) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = oferta.LoginUsuario;
                    entrada.Accion = "Modificar oferta";
                    entrada.TipoEvento = "Modificar";
                    entrada.Descripcion = "Se ha modificado la oferta '" + oferta.Nombre +
                                         "' con la siguiente información: " +
                                         "estado = " + oferta.Estado + ", " +
                                         "Sede = " + oferta.Sede + ", " +
                                         "Fecha y hota de matrícula = " + oferta.FechaRegistro + ", " +
                                         "Observaciones = " + oferta.Observacion;
                    entrada.Entidad = oferta.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Elimina una oferta de la base de datos a partir de su ID
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns>true - si el procedimiento tuvo éxito</returns>
        public bool EliminarOferta(EOferta oferta)
        {
            try
            {
                if (ofertasDAL.EliminarOferta(oferta.IdOferta) != 0)
                {
                    // Notificar a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = oferta.LoginUsuario;
                    entrada.Accion = "Eliminar oferta";
                    entrada.TipoEvento = "Eliminar";
                    entrada.Descripcion = "Se ha eliminado la información de la oferta '" +
                                          oferta.Nombre + "'.";
                    entrada.Entidad = oferta.Nombre;
                    new ReporteNeg().RegistrarBitacora(entrada);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Cargar datos de una oferta dada
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow CargarOferta(int id)
        {
            DataTable tabla = ofertasDAL.CargarOferta(id);
            return tabla.Rows[0];
        }

        /// <summary>
        /// Cargar listado de estados para la oferta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaEstados()
        {
            DataTable tabla = ofertasDAL.CargarListaEstados();
            return tabla.AsDataView();
        }

        /// <summary>
        /// Cargar listado de sedes para la oferta
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataView CargarListaSedes()
        {
            DataTable tabla = ofertasDAL.CargarListaSedes();
            return tabla.AsDataView();
        }

    }
}
