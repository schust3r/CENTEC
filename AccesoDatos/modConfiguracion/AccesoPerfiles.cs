using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos.modConfiguracion
{
    /// <summary>
    /// Acceso a Datos para el Perfiles de usuario. Permite registrar,
    /// eliminar, actualizar, consultar perfiles, cargar un perfil
    /// específico o consultar la lista de perfiles disponibles.
    /// </summary>
    public class AccesoPerfiles : MetodosDatos
    {

        // Registrar nuevo perfil
        public int RegistrarPerfil(EPerfil perfil)
        {
            SqlCommand comando = CrearComandoProc("CON_PerfilRegistrar");
            comando.Parameters.AddWithValue("@Nombre", perfil.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", perfil.Descripcion);
            comando.Parameters.AddWithValue("@AgregarPerfil", perfil.RegistrarPerfil);
            comando.Parameters.AddWithValue("@EliminarPerfil", perfil.EliminarPerfil);
            comando.Parameters.AddWithValue("@ModificarPerfil", perfil.ModificarPerfil);
            comando.Parameters.AddWithValue("@VerDetallesPerfil", perfil.VerDetallesPerfil);
            comando.Parameters.AddWithValue("@AgregarUsuario", perfil.RegistrarUsuario);
            comando.Parameters.AddWithValue("@EliminarUsuario", perfil.EliminarUsuario);
            comando.Parameters.AddWithValue("@ModificarUsuario", perfil.ModificarUsuario);
            comando.Parameters.AddWithValue("@VerDetallesUsuario", perfil.VerDetallesUsuario);
            comando.Parameters.AddWithValue("@VerBitacora", perfil.VerBitacora);
            comando.Parameters.AddWithValue("@RegistrarOferta", perfil.RegistrarOferta);
            comando.Parameters.AddWithValue("@EliminarOferta", perfil.EliminarOferta);
            comando.Parameters.AddWithValue("@ModificarOferta", perfil.ModificarOferta);
            comando.Parameters.AddWithValue("@VerDetallesOferta", perfil.VerDetallesOferta);
            comando.Parameters.AddWithValue("@CambiarEstadoOferta", perfil.CambiarEstadoOferta);
            comando.Parameters.AddWithValue("@RegistrarCurso", perfil.RegistrarCurso);
            comando.Parameters.AddWithValue("@EliminarCurso", perfil.EliminarCurso);
            comando.Parameters.AddWithValue("@ModificarCurso", perfil.ModificarCurso);
            comando.Parameters.AddWithValue("@VerDetallesCurso", perfil.VerDetallesCurso);
            comando.Parameters.AddWithValue("@CambiarEstadoCurso", perfil.CambiarEstadoCurso);
            comando.Parameters.AddWithValue("@MatriculaPres", perfil.MatriculaPres);
            comando.Parameters.AddWithValue("@CambiarEstadoPart", perfil.CambiarEstadoPart);
            comando.Parameters.AddWithValue("@ImpComprobante", perfil.ImprimirComprobante);
            return EjecutarComando(comando);
        }

        // Eliminar un perfil existente
        public int EliminarPerfil(int idPerfil)
        {
            SqlCommand comando = CrearComandoProc("CON_PerfilEliminar");
            comando.Parameters.AddWithValue("@IdPerfil", idPerfil);
            return EjecutarComando(comando);
        }

        // Modificar o actualizar perfil existente
        public int ModificarPerfil(EPerfil perfil)
        {
            SqlCommand comando = CrearComandoProc("CON_PerfilModificar");
            comando.Parameters.AddWithValue("@IdPerfil", perfil.IdPerfil);
            comando.Parameters.AddWithValue("@NuevoNombre", perfil.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", perfil.Descripcion);
            comando.Parameters.AddWithValue("@AgregarPerfil", perfil.RegistrarPerfil);
            comando.Parameters.AddWithValue("@EliminarPerfil", perfil.EliminarPerfil);
            comando.Parameters.AddWithValue("@ModificarPerfil", perfil.ModificarPerfil);
            comando.Parameters.AddWithValue("@VerDetallesPerfil", perfil.VerDetallesPerfil);
            comando.Parameters.AddWithValue("@AgregarUsuario", perfil.RegistrarUsuario);
            comando.Parameters.AddWithValue("@EliminarUsuario", perfil.EliminarUsuario);
            comando.Parameters.AddWithValue("@ModificarUsuario", perfil.ModificarUsuario);
            comando.Parameters.AddWithValue("@VerDetallesUsuario", perfil.VerDetallesUsuario);
            comando.Parameters.AddWithValue("@VerBitacora", perfil.VerBitacora);
            comando.Parameters.AddWithValue("@RegistrarOferta", perfil.RegistrarOferta);
            comando.Parameters.AddWithValue("@EliminarOferta", perfil.EliminarOferta);
            comando.Parameters.AddWithValue("@ModificarOferta", perfil.ModificarOferta);
            comando.Parameters.AddWithValue("@VerDetallesOferta", perfil.VerDetallesOferta);
            comando.Parameters.AddWithValue("@CambiarEstadoOferta", perfil.CambiarEstadoOferta);
            comando.Parameters.AddWithValue("@RegistrarCurso", perfil.RegistrarCurso);
            comando.Parameters.AddWithValue("@EliminarCurso", perfil.EliminarCurso);
            comando.Parameters.AddWithValue("@ModificarCurso", perfil.ModificarCurso);
            comando.Parameters.AddWithValue("@VerDetallesCurso", perfil.VerDetallesCurso);
            comando.Parameters.AddWithValue("@CambiarEstadoCurso", perfil.CambiarEstadoCurso);
            comando.Parameters.AddWithValue("@MatriculaPres", perfil.MatriculaPres);
            comando.Parameters.AddWithValue("@CambiarEstadoPart", perfil.CambiarEstadoPart);
            comando.Parameters.AddWithValue("@ImpComprobante", perfil.ImprimirComprobante);
            return EjecutarComando(comando);
        }

        // Consultar perfiles
        public DataTable ConsultarPerfil(string Nombre, string Descripcion)
        {
            SqlCommand comando = CrearComandoProc("CON_PerfilConsultar");
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            return EjecutarComandoDataTable(comando);
        }

        // Cargar un perfil específico
        public DataTable CargarPerfil(int idPerfil)
        {
            SqlCommand comando = CrearComandoProc("CON_PerfilCargar");
            comando.Parameters.AddWithValue("@IdPerfil", idPerfil);
            return EjecutarComandoDataTable(comando);
        }

        // Cargar listado de perfiles
        public DataTable CargarListaPerfiles()
        {
            SqlCommand comando = CrearComandoProc("INF_ListaPerfiles");
            return EjecutarComandoDataTable(comando);
        }

    }
}
