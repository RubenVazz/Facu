using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Pais
    {
        private short _id;
        public short Id
        {
            get { return _id; }
            set
            {

                if (ObtenerIndice(value) >= 0)
                {
                    _id = value;
                }
                else
                {
                    _id = Utilidades.ObtenerCodigo();
                }
            }
        }
        public int CodPais { get; set; }
        public string Descripcion { get; set; }
        private static List<Pais> ListaPais = new List<Pais>();

        public Pais()
        {

        }

        public Pais(int codPais,string descripcion)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.CodPais = codPais;
            this.Descripcion = descripcion; 
        }
        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaPais.FindIndex(x => x.Id == id);
            return indice;

        }
        public static bool AgregarPais(Pais pais)
        {

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Pais(CodPais,Descripcion" +
                    "values (@CodPais,Descripcion))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codPais", pais.CodPais);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", pais.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                

                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static bool EditarPais(Pais pais)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Pais " +
                                      "set CodPais= @CodPais, " +
                                      "Descripcion= @Descripcion, " + 
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codEstadoMatriculacion", pais.CodPais);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@FechaUltimoPago", pais.Descripcion);
                p2.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();
                ActualizarPaisLista();



            }
            return true;
        }
        public static bool EliminarPais(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Pais where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarPaisLista();
            }
            return true;
        }
        public static List<Pais> ObtenerPaisLista()
        {
            if (ListaPais.Count == 0) ActualizarPaisLista();

            return ListaPais;
        }
        public static List<Alumno> ActualizarPaisLista()
        {
            ListaPais.Clear();
            Pais pais;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Pais";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    pais = new Pais();

                    Pais.CodPais = lectorDatos.GetInt32(0);
                    alumno.FechaIngreso = lectorDatos.GetString(1);

                    ListaAlumno.Add(alumno);

                }

                return ListaAlumno;
            }
        }
    }
}
