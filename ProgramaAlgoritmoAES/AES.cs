using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
    
namespace ProgramaAlgoritmoAES
{
    public class AES
    {

        public String Cifrar(String mensaje, String password, String salt)
        {

            byte[] clave, iv, datos, datos_cifrados;

            // Instanciamos un objeto de la clase AesCryptoServiceProvider
            AesCryptoServiceProvider cspAes = new AesCryptoServiceProvider();

            // Fusionammos la salt y el password en un objeto tipo Rfc2898DeriveBytes,
            // repitiendo el proceso 9 veces para que la clave resultante sea mas segura
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt), 9);

            // Para obtener la clave dividimos el tamaño de clave por 8 ya que esta en bits y
            // hacemos lo mismo con el tamaño de bloque para obtener el vector de inicializacion (iv)
            clave = rgb.GetBytes(cspAes.KeySize >> 3);
            iv = rgb.GetBytes(cspAes.BlockSize >> 3);

            // Inicializamos AES
            cspAes.Mode = CipherMode.CBC;
            cspAes.Key = clave;
            cspAes.IV = iv;

            // Definimos la interface necesaria para el algoritmo de cifrado
            ICryptoTransform cifrador = cspAes.CreateEncryptor();

            // Convertimos el mensaje a bytes y lo ciframos
            datos = Encoding.Unicode.GetBytes(mensaje);
            datos_cifrados = cifrador.TransformFinalBlock(datos, 0, datos.Length);

            // Devolvemos el mensaje cifrado en forma de cadena "legible"
            return Convert.ToBase64String(datos_cifrados);

        }

        public String Descifrar(String mensaje, String password, String salt)
        {

            byte[] clave, iv, datos, datos_descifrados;

            AesCryptoServiceProvider cspAes = new AesCryptoServiceProvider();
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt), 9);

            clave = rgb.GetBytes(cspAes.KeySize >> 3);
            iv = rgb.GetBytes(cspAes.BlockSize >> 3);

            cspAes.Mode = CipherMode.CBC;
            cspAes.Key = clave;
            cspAes.IV = iv;

            // Definimos la interface necesaria para el algoritmo de descifrado
            ICryptoTransform descifrador = cspAes.CreateDecryptor();

            // Convertimos el mensaje en bytes
            datos = Convert.FromBase64String(mensaje);
            datos_descifrados = descifrador.TransformFinalBlock(datos, 0, datos.Length);

            // Devolvemos el mensaje descifrado en forma de cadena
            return Encoding.Unicode.GetString(datos_descifrados);

        }

    }

}
