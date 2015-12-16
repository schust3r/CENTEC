using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.modConfiguracion
{
    /// <summary>
    /// Acceso a Datos para acceder a usuarios. Permite registrar,
    /// eliminar, actualizar, consultar usuarios, consultar la información
    /// de un usuario específico, cargar las acciones más utilizadas por
    /// un usuario y obtener la lista de sedes disponibles a los usuarios.
    /// </summary>
    public class AccesoUsuarios : MetodosDatos
    {

        // Registrar nuevo usuario
        public int RegistrarUsuario(EUsuario usuario)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioRegistrar");
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
            comando.Parameters.AddWithValue("@IdPerfil", usuario.IdPerfil);
            comando.Parameters.AddWithValue("@IdSede", usuario.IdSede);
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            return EjecutarComando(comando);
        }

        // Eliminar un usuario existente
        public int EliminarUsuario(string Login)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioEliminar");
            comando.Parameters.AddWithValue("@Login", Login);
            return EjecutarComando(comando);
        }

        // Modificar o actualizar usuario existente
        public int ModificarUsuario(EUsuario usuario)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioModificar");
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@IdPerfil", usuario.IdPerfil);
            comando.Parameters.AddWithValue("@IdSede", usuario.IdSede);
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Activo", usuario.Activo);
            return EjecutarComando(comando);
        }

        // Consultar usuarios
        public DataTable ConsultarUsuarios(EUsuario usuario)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioConsultar");
            comando.Parameters.AddWithValue("@Login", usuario.Login);
            comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@Perfil", usuario.NombrePerfil);
            return EjecutarComandoDataTable(comando);
        }

        // Consultar información de un usuario
        public DataTable CargarUsuario(string Login)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioCargar");
            comando.Parameters.AddWithValue("@Login", Login);
            return EjecutarComandoDataTable(comando);
        }

        // Recuperar las acciones más utilizadas por ese usuario.
        public DataTable AccionesMasUtilizadas(string Login)
        {
            SqlCommand comando = CrearComandoProc("CON_UsuarioTopAcciones");
            comando.Parameters.AddWithValue("@Login", Login);
            return EjecutarComandoDataTable(comando);
        }

        // Cargar distintas sedes a las que puede pertenecer un usuario
        public DataTable CargarListaSedes()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaSedes");
            return EjecutarComandoDataTable(comando);
        }

    }
}
