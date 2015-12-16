using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.modConfiguracion;
using System.Data;
using Entidades;

namespace LogicaNegocios.modConfiguracion
{
    /// <summary>
    /// Lógica de negocios para la sección Perfil del módulo Configuración
    /// </summary>
    public class PerfilNeg
    {

        // Acceso a perfiles
        private AccesoPerfiles perfilDAL;

        public PerfilNeg()
        {
            perfilDAL = new AccesoPerfiles();
        }

        /// <summary>
        /// Realizar un nuevo registro de perfil en base de datos a partir
        /// de parámetros de una entidad Perfil
        /// </summary>
        /// <param name="perfil">Entidad tipo Perfil</param>
        /// <returns>true - si el registro tuvo éxito</returns>
        public bool RegistrarPerfil(EPerfil perfil)
        {
            try
            {
                if (perfilDAL.RegistrarPerfil(perfil) != 0)
                {
                    // Notificar registro a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = perfil.LoginUsuario;
                    entrada.Accion = "Registrar perfil";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado el perfil '" + perfil.Nombre + 
                                         "' con la siguiente información: " + GenerarStringDescripcion(perfil);
                    entrada.Entidad = perfil.Nombre;
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

        // Actualizar datos de perfil existente
        public bool ModificarPerfil(EPerfil perfil)
        {
            try
            {
                if (perfilDAL.ModificarPerfil(perfil) != 0)
                {
                    // Notificar cambio a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = perfil.LoginUsuario;
                    entrada.Accion = "Modificar perfil";
                    entrada.TipoEvento = "Modificar";
                    entrada.Descripcion = "Se ha modificado el perfil '" + perfil.Nombre +
                                         "' con la siguiente información: " + GenerarStringDescripcion(perfil);
                    entrada.Entidad = perfil.Nombre;
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

        // Eliminar perfil
        public bool EliminarPerfil(EPerfil perfil)
        {
            try
            {
                if (perfilDAL.EliminarPerfil(perfil.IdPerfil) != 0)
                {
                    // Notificar cambio a bitácora
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = perfil.LoginUsuario;
                    entrada.Accion = "Eliminar perfil";
                    entrada.TipoEvento = "Eliminar";
                    entrada.Descripcion = "Se ha eliminado la informacion del perfil '" + perfil.Nombre + "'.";
                    entrada.Entidad = perfil.Nombre;
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

        // Consultar tabla de perfiles
        public DataView ConsultarPerfiles(string Nombre, string Descripcion)
        {
            DataTable tabla = perfilDAL.ConsultarPerfil(Nombre, Descripcion);
            return tabla.AsDataView();
        }

        // Cargar perfil con sus respectivos permisos
        public DataRow CargarPerfil(int idPerfil)
        {
            DataTable tbl = perfilDAL.CargarPerfil(idPerfil);
            return tbl.Rows[0];
        }

        /// <summary>
        /// Obtener listado de los perfiles registrados en la base de datos
        /// </summary>
        /// <returns>Retornar lista de nombres de los perfiles registrados</returns>
        public DataView CargarListaPerfiles()
        {
            DataTable tbl = perfilDAL.CargarListaPerfiles();
            return tbl.AsDataView();
        }

        /// <summary>
        /// Generar string de Descripción para bitácora 
        /// </summary>
        /// <param name="perfil">Entidad Perfil</param>
        /// <returns>string con detalles de </returns>
        private string GenerarStringDescripcion(EPerfil perfil)
        {
            string s = "";
            s += "Nombre = '" + perfil.Nombre + "', ";
            s += "Descripción = '" + perfil.Descripcion + "', ";
            s += "Permisos = {";

            if (perfil.RegistrarPerfil)
                s += "[Permiso = 'Registrar perfil'], ";

            if (perfil.ModificarPerfil)
                s += "[Permiso = 'Modificar perfil'], ";

            if (perfil.EliminarPerfil)
                s += "[Permiso = 'Eliminar perfil'], ";

            if (perfil.VerDetallesPerfil)
                s += "[Permiso = 'Ver detalle de perfil'], ";

            if (perfil.RegistrarUsuario)
                s += "[Permiso = 'Registrar usuario'], ";

            if (perfil.ModificarUsuario)
                s += "[Permiso = 'Modificar usuario'], ";

            if (perfil.EliminarUsuario)
                s += "[Permiso = 'Eliminar usuario'], ";

            if (perfil.VerDetallesUsuario)
                s += "[Permiso = 'Ver detalle de usuario'], ";

            if (perfil.VerBitacora)
                s += "[Permiso = 'Ver bitácora'], ";

            if (perfil.RegistrarOferta)
                s += "[Permiso = 'Registrar oferta'], ";

            if (perfil.EliminarOferta)
                s += "[Permiso = 'Eliminar oferta'], ";

            if (perfil.ModificarOferta)
                s += "[Permiso = 'Modificar oferta'], ";

            if (perfil.VerDetallesOferta)
                s += "[Permiso = 'Ver detalle de oferta'], ";

            if (perfil.CambiarEstadoOferta)
                s += "[Permiso = 'Cambiar estado de oferta'], ";

            if (perfil.RegistrarCurso)
                s += "[Permiso = 'Registrar curso'], ";

            if (perfil.EliminarCurso)
                s += "[Permiso = 'Eliminar curso'], ";

            if (perfil.ModificarCurso)
                s += "[Permiso = 'Modificar curso'], ";

            if (perfil.VerDetallesCurso)
                s += "[Permiso = 'Ver detalle de curso'], ";

            if (perfil.CambiarEstadoCurso)
                s += "[Permiso = 'Cambiar estado de curso'], ";

            if (perfil.MatriculaPres)
                s += "[Permiso = 'Matrícula presencial'], ";

            if (perfil.CambiarEstadoPart)
                s += "[Permiso = 'Cambiar estado de participante'], ";

            if (perfil.ImprimirComprobante)
                s += "[Permiso = 'Imprimir comprobante'], ";

            s += "}";
            return s;
        }

    }
}
