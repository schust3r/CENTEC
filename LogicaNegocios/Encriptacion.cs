using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    /// <summary>
    /// Encriptación para contraseñas de usuario
    /// </summary>
    class Encriptacion
    {

        /// <summary>
        /// Método para encriptar un string a SHA512 para almacenar en la base de datos
        /// </summary>
        /// <param name="pass">parámetro string a encriptar</param>
        /// <returns>string pass encriptado</returns>
        public string EncriptarSHA512(string pass)
        {
            UnicodeEncoding uEncode = new UnicodeEncoding();
            byte[] bytpass = uEncode.GetBytes(pass);
            SHA512Managed sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(bytpass);
            return Convert.ToBase64String(hash);
        }

    }
}
