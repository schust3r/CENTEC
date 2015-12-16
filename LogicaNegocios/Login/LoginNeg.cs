using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Login;
using System.Data;
using System.Text.RegularExpressions;
using Entidades;
using System.Security.Cryptography;
using LogicaNegocios.modConfiguracion;

namespace LogicaNegocios.Login
{
    /// <summary>
    /// Lógica de negocios para el ingreso a sistema.
    /// </summary>
    public class LoginNeg
    {

        private AccesoLogin loginDAL;

        public LoginNeg()
        {
            loginDAL = new AccesoLogin();
        }

        // Intentar login desde el cliente
        public bool IntentarIngreso(string login, string pass)
        {
            try
            {
                // Comprobación de formato del login mediante RegEx
                Regex regex = new Regex(@"[a-zA-ZñÑ\s]");
                if (regex.IsMatch(login))
                {
                    login = login.ToLower();
                    DataTable datos;

                    if (login.Equals("admin"))
                        datos = loginDAL.VerificarUsuario(login, pass);

                    else
                        datos = loginDAL.VerificarUsuario(login, 
                            new Encriptacion().EncriptarSHA512(pass));

                    if (datos.Rows.Count != 0 && Convert.ToBoolean(datos.Rows[0][1]))
                    {
                        // Notificar ingreso a bitácora
                        EBitacora entrada = new EBitacora();
                        entrada.LoginUsuario = login;
                        entrada.Accion = "Ingresar al sistema";
                        entrada.TipoEvento = "Ingresar";
                        entrada.Descripcion = "El usuario '" + login + "' con el perfil '" +
                                             datos.Rows[0][2] + "' ha ingresado al sistema.";
                        entrada.Entidad = "Sistema";
                        new ReporteNeg().RegistrarBitacora(entrada);
                        return true;
                    }

                    else
                    {
                        // Notificar ingreso a bitácora
                        EBitacora entrada = new EBitacora();
                        entrada.LoginUsuario = login;
                        entrada.Accion = "Ingresar al sistema";
                        entrada.TipoEvento = "Ingresar";
                        entrada.Descripcion = "El usuario '" + login + "' ha tratado de ingresar al " +
                                              "sistema pero se presentó el siguiente error: nombre y contraseña " +
                                              "no se encuentran en el sistema.";
                        entrada.Entidad = "Sistema";
                        new ReporteNeg().RegistrarBitacora(entrada);
                        return false;
                    }
                }

                return false;
            }

            catch
            {
                return false;
            }
        }

    }
}
