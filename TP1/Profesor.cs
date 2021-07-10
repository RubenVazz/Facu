using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Profesor : Persona
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
        public string FechaIngFacultad { get; set; }
        public string FechaRenovacionContrato { get; set; }
        private static List<Profesor> ListaProfesor = new List<Profesor>();

        public Profesor()
        {

        }

        public Profesor( string nroDocumento, string codNacionalidad, 
            string fechaNacimiento, string nombre, string apellido, 
            string direccion, string ruc, string correo, string celular, 
            string fechaIngreso, string porcentajeDesc)
        {
            this._id = Utilidades.ObtenerCodigo();
            this.NroDocumento = nroDocumento;
            this.CodNacionalidad = codNacionalidad;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.RUC = ruc;
            this.Correo = correo;
            this.Celular = celular;
            this.FechaIngreso = fechaIngreso;
            this.PorcentajeDesc = porcentajeDesc;

        }

        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaProfesor.FindIndex(x => x.Id == id);
            return indice;

        }
        public override string ToString()
        {
            return $"Fecha de Ingreso {this.FechaIngFacultad}";
        }

        public static bool AgregarProfesor(Profesor profesor)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Profesor(FechaIngFacultado,FechaRenovacionContrato values(@FechaIngresoFacultado,@FechaRenovacionContrato))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@FechaIngresoFacultado", profesor.FechaIngFacultad);
                p1.SqlDbType = SqlDbType.char;

                SqlParameter p2 = new SqlParameter("@FechaRenovacionContrato", profesor.FechaRenovacionContrato);
                p2.SqlDbType = SqlDbType.Date;


                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
               

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool EditarProfesor(Profesor profesor)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Profesor " +
                                      "set FechaIngresoFacultado= @,FechaIngresoFacultado " +
                                      "FechaRenovacionContrato= @FechaRenovacionContrato, " +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                SqlParameter p1 = new SqlParameter("@FechaIngresoFacultado", profesor.FechaIngFacultad);
                p1.SqlDbType = SqlDbType.char;

                SqlParameter p2 = new SqlParameter("@FechaRenovacionContrato", profesor.FechaRenovacionContrato);
                p2.SqlDbType = SqlDbType.Date;



                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();
                ActualizarProfesorLista();



            }
            return true;
        }

        public static bool EliminarProfesor(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Delete from Profesor where";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                
                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.char;

                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                ActualizarProfesorLista();



            }
            return true;

        }
        public static List<Profesor> ObtenerProfesorLista()
        {
            if (ListaProfesor.Count == 0) ActualizarProfesorLista();

            return ListaProfesor;
        }

        public static List<Profesor> ActualizarProfesorLista()
        {
            ListaProfesor.Clear();
            Profesor profesor;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Profesor";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    profesor = new Profesor();

                    profesor.FechaIngFacultad = lectorDatos.GetInt32(0);
                    profesor.FechaRenovacionContrato= lectorDatos.GetString(1);

                    ListaProfesor.Add(profesor);

                }

                return ListaProfesor;
            }
        }
        
    }
}
