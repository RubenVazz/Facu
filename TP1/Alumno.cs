using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace TP1
{
    public class Alumno : Persona
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
        public int CodEstadoAlumno { get; set; }
        public string FechaUltimoPago { get; set; }
        public string FechaIngresoFacultad { get; set; }
        private static List<Alumno> ListaAlumno = new List<Alumno>();

        public Alumno()
        {

        }
        public Alumno(string nroDocumento, string codNacionalidad, string fechaNacimiento, string nombre, string apellido, string direccion, string rUC, string correo, string celular, string fechaIngreso, string porcentajeDesc, string fechaUltimoPago)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.NroDocumento = nroDocumento;
            this.CodNacionalidad = codNacionalidad;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.RUC = rUC;
            this.Correo = correo;
            this.Celular = celular;
            this.FechaIngresoFacultad = fechaIngreso;
            this.PorcentajeDesc = porcentajeDesc;
            this.FechaUltimoPago = fechaUltimoPago;
        }

        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaAlumno.FindIndex(x => x.Id == id);
            return indice;

        }
        public override string ToString()
        {
            return $"Fecha de Ingreso {this.FechaIngreso}";
        }

        public static bool AgregarAlumno(Alumno alumno)
        {

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Alumno(codEstadoMatriculacion,FechaUltimoPago,FechaIngresoFacultad " +
                    "values (@codEstadoMatriculacion,@FechaUltimoPago,@FechaIngresoFacultad ))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codEstadoMatriculacion", alumno.CodEstadoAlumno);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@FechaUltimoPago", alumno.FechaUltimoPago);
                p2.SqlDbType = SqlDbType.Date;

                SqlParameter p3 = new SqlParameter("@FechaIngresoFacultad", alumno.FechaIngresoFacultad);
                p3.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool EditarAlumno(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Alumno " +
                                      "set codEstadoMatriculacion= @codEstadoMatriculacion, " +
                                      "FechaUltimoPago= @FechaUltimoPago, " +
                                      "FechaIngresoFacultad= @FechaIngresoFacultad, " +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@codEstadoMatriculacion", alumno.CodEstadoAlumno);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@FechaUltimoPago", alumno.FechaUltimoPago);
                p2.SqlDbType = SqlDbType.Date;

                SqlParameter p3 = new SqlParameter("@FechaIngresoFacultad", alumno.FechaIngresoFacultad);
                p3.SqlDbType = SqlDbType.Date;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
                ActualizarAlumnoLista();



            }
            return true;
        }
        public static bool EliminarAlumno(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Alumno where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.Char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarAlumnoLista();
            }
            return true;
        }
        public static List<Alumno> ObtenerAlumnoLista()
        {
            if (ListaAlumno.Count == 0) ActualizarAlumnoLista();

            return ListaAlumno;
        }

        public static List<Alumno> ActualizarAlumnoLista()
        {
            ListaAlumno.Clear();
            Alumno alumno;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Alumno";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    alumno = new Alumno();

                    alumno.CodEstadoAlumno = lectorDatos.GetInt32(0);
                    alumno.FechaIngreso = lectorDatos.GetString(1);
                    alumno.FechaUltimoPago = lectorDatos.GetString(2);

                    ListaAlumno.Add(alumno);

                }

                return ListaAlumno;
            }
        }

    }

}
