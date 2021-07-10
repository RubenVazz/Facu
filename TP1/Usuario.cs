using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace TP1
{
    public class Usuario
    {
        public static void CrearUsuario(string usuario, string contrasena)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sql = "insert into Usuario(usuario,contrasena) values (@usuario,contrasena)";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter p1 = new SqlParameter("@usuario",usuario);
                p1.SqlDbType = SqlDbType.VarChar;

                string contrasenaencriptada = EncriptarContrasena(contrasena);
                SqlParameter p2 = new SqlParameter("@contrasena", contrasena);
                p2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();

            }

        }

        public static bool ValidarUsuario(string usuario, string contrasena)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sql = "select * from usuario where usuario = @usuario,@contrasena";

                SqlCommand cmd = new SqlCommand(sql, con);

                SqlParameter p1 = new SqlParameter("@usuario", usuario);
                p1.SqlDbType = SqlDbType.VarChar;

                string contrasenaencriptada = EncriptarContrasena(contrasena);
                SqlParameter p2 = new SqlParameter("@contrasena", contrasena);
                p2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.HasRows)
                {
                    lector.Close();
                    return true;
                }
                else
                {
                    lector.Close();
                    return false;
                }

            }

        }

        public static string EncriptarContrasena(string contrasena)
        {

            SHA256 sha256 = new SHA256CryptoServiceProvider();
            string agregado = "0d71ee4472658cd5874c5578410a9d8611fc9aef";
            string contrasenaAgregado = contrasena + agregado;

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(contrasenaAgregado);
            byte[] hash = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);


        }
    }
}
