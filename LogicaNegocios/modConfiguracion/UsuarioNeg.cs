using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.modConfiguracion;
using System.Data;
using Entidades;
using LogicaNegocios.Login;

namespace LogicaNegocios.modConfiguracion
{
    public class UsuarioNeg
    {

        private AccesoUsuarios userDAL;

        public UsuarioNeg()
        {
            userDAL = new AccesoUsuarios();
        }


        //  Registrar un nuevo usuario desde la lógica de negocio
        public bool RegistrarUsuario(EUsuario usuario)
        {
            try
            {
                usuario.Contrasena = new Encriptacion().EncriptarSHA512(usuario.Contrasena);
                if (userDAL.RegistrarUsuario(usuario) != 0)
                {
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = usuario.LoginUsuario;
                    entrada.Accion = "Registrar usuario";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha registrado el usuario '" + usuario.Nombre +
                                         "' con la siguiente información: " +
                                         "Login = '" + usuario.Login + "', " +
                                         "Perfil = '" + usuario.NombrePerfil + "', " +
                                         "Nombre = '" + usuario.Nombre + "'.";
                    entrada.Entidad = usuario.Login;
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

        // Eliminar un nuevo usuario desde la logica de negocio
        public bool EliminarUsuario(string usuario)
        {
            try
            {
                if (userDAL.EliminarUsuario(usuario) != 0)
                {
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

        
        //  Modificar un nuevo usuario desde la logica de negocio
        public bool ModificarUsuario(EUsuario usuario)
        {
            try
            {
                if (userDAL.ModificarUsuario(usuario) != 0)
                {
                    EBitacora entrada = new EBitacora();
                    entrada.LoginUsuario = usuario.LoginUsuario;
                    entrada.Accion = "Registrar usuario";
                    entrada.TipoEvento = "Registrar";
                    entrada.Descripcion = "Se ha modificado el usuario '" + usuario.Nombre +
                                         "' con la siguiente información: " +
                                         "Login = '" + usuario.Login + "', " +
                                         "Perfil = '" + usuario.NombrePerfil + "', " +
                                         "Nombre = '" + usuario.Nombre + "', " +
                                         "Activo = '" + BoolToWord(usuario.Activo) + "'.";
                    entrada.Entidad = usuario.Login;
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
        /// Transformar un valor booleano a "Sí" o "No"
        /// </summary>
        /// <param name="input">valor bool</param>
        /// <returns>Sí o No en modo string</returns>
        private string BoolToWord(bool input)
        {
            if (input) return "Sí";
            else return "No";
        }

        // Consulta los usuarios desde la base de datos
        public DataView ConsultarUsuarios(EUsuario usuario)
        {
            DataTable tabla = userDAL.ConsultarUsuarios(usuario);
            return tabla.AsDataView();
        }

        // Consulta un usuario específico desde la base de datos
        public List<string> CargarUsuario(string Login)
        {
            DataTable tablaLista = userDAL.CargarUsuario(Login);
            List<string> res = new List<string>();
            for (int i = 0; i < tablaLista.Columns.Count; i++)
            {
                res.Add(tablaLista.Rows[0][i].ToString());
            }
            return res;
        }

        /// <summary>
        /// Obtener listado de las sedes registradas en la base de datos
        /// </summary>
        /// <returns>Retornar DataView de nombres de sedes registradas</returns>
        public DataView CargarListaSedes()
        {
            DataTable tablaLista = userDAL.CargarListaSedes();
            return tablaLista.AsDataView();
        }

        /// <summary>
        /// Obtener listado de acciones más usadas por ese usuario según
        /// registros de la bitácora
        /// </summary>
        /// <returns>Retornar lista de acciones frecuentes para un usuario
        /// en particular</returns>
        public List<string> AccionesMasUtilizadas(string Login)
        {
            DataTable tablaLista = userDAL.AccionesMasUtilizadas(Login);
            List<string> res = new List<string>();
            foreach (DataRow fila in tablaLista.Rows)
            {
                res.Add(fila[0].ToString());
            }
            return res;
        }

    }
}
