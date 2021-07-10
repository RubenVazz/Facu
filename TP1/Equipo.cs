using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TP1
{
    public class Equipo
    {
        private short _id;
        public short CodEquipo
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

        public string Descripcion { get; set; }
        public int CodMarca { get; set; }
        public string FechaAdq { get; set; }
        public double CostoGs { get; set; }
        public int CodSala { get; set; }
        public double Precio { get; set; }
        public int CodEstadoEquipo { get; set; }
        private static List<Equipo> ListaEquipo = new List<Equipo>();


        public Equipo()
        {

        }

        public Equipo(string descripcion,int codMarca,string fechaAdq,double costoGs,int codSala,double Precio,int codEstadoEquipo)
        {
            this._id = Utilidades.ObtenerCodigo();
           
            this.Descripcion = descripcion;
            this.CodMarca = codMarca;
            this.FechaAdq = fechaAdq;
            this.CostoGs = costoGs;
            this.CodSala = codSala;
            this.Precio = Precio;
            this.CodEstadoEquipo = codEstadoEquipo;
        }

        public static int ObtenerIndice(short id)
        {
            int indice;
            indice = ListaEquipo.FindIndex(x => x.CodEquipo == id);
            return indice;

        }

        public static bool AgregarEquipo(Equipo equipo)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "insert into Equipo(CodEquipo,Descripcion,CodMarca,FechaAdq" +
                    "CostoGs,CodSala,CodPrecio,CodEstadoEquipo" +
                    "values (@CodEquipo,@Descripcion,@CodMarca,@FechaAdq" +
                    "@CostoGs,@CodSala,@CodPrecio,@CodEstadoEquipo ))";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter("@CodEquipo", equipo.CodEquipo);
                p1.SqlDbType = SqlDbType.char;

                SqlParameter p2 = new SqlParameter("@Descripcion", equipo.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                SqlParameter p3 = new SqlParameter("@CodMarca", equipo.CodMarca);
                p3.SqlDbType = SqlDbType.Char;

                SqlParameter p4 = new SqlParameter("@FechaAdq", equipo.FechaAdq);
                p4.SqlDbType = SqlDbType.Date;

                SqlParameter p5 = new SqlParameter("@CostoGs", equipo.CostoGs);
                p5.SqlDbType = SqlDbType.Money;

                SqlParameter p6 = new SqlParameter("@CodSala", equipo.CodSala);
                p6.SqlDbType = SqlDbType.Char;

                SqlParameter p7 = new SqlParameter("@CodEstadoEquipo", equipo.CodEstadoEquipo);
                p7.SqlDbType = SqlDbType.Char;

                

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool EditarEquipo(Equipo equipo)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "Update Equipo " +
                                      "set  CodEquipo = @CodEquipo ," +
                                      "Descripcion = @Descripcion," +
                                      "CodMarca = @CodMarca," +
                                      "FechaAdq = @FechaAdq" +
                                      "CostoGs = @CostoGs," +
                                      "CodSala = @CodSala," +
                                      "CodPrecio = @CodPrecio," +
                                      "CodEstadoEquipo = @CodEstadoEquipo" +
                                      "where Id = @Id";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);
                SqlParameter p1 = new SqlParameter("@CodEquipo", equipo.CodEquipo);
                p1.SqlDbType = SqlDbType.Char;

                SqlParameter p2 = new SqlParameter("@Descripcion", equipo.Descripcion);
                p2.SqlDbType = SqlDbType.Char;

                SqlParameter p3 = new SqlParameter("@CodMarca", equipo.CodMarca);
                p3.SqlDbType = SqlDbType.Char;

                SqlParameter p4 = new SqlParameter("@FechaAdq", equipo.FechaAdq);
                p4.SqlDbType = SqlDbType.Date;

                SqlParameter p5 = new SqlParameter("@CostoGs", equipo.CostoGs);
                p5.SqlDbType = SqlDbType.Money;

                SqlParameter p6 = new SqlParameter("@CodSala", equipo.CodSala);
                p6.SqlDbType = SqlDbType.Char;

                SqlParameter p7 = new SqlParameter("@CodEstadoEquipo", equipo.CodEstadoEquipo);
                p7.SqlDbType = SqlDbType.Char;



                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);

                cmd.ExecuteNonQuery();
                


                ActualizarEquipoLista();



            }
            return true;
        }
        public static bool EliminarEquipo(short id)
        {
            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();

                string sentenciaSql = "delete from Equipo where ";
                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlParameter p1 = new SqlParameter();
                p1.SqlDbType = SqlDbType.char;

                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();

                ActualizarAlumnoLista();



            }
            return true;
        }
        public static List<Equipo> ObtenerEquipoLista()
        {
            if (ListaEquipo.Count == 0) ActualizarEquipoLista();

            return ListaEquipo;
        }
        public static List<Alumno> ActualizarEquipoLista()
        {
            ListaEquipo.Clear();
            Equipo equipo;

            using (SqlConnection con = new SqlConnection(configuracion.Cadena_Conexion))
            {
                con.Open();
                string sentenciaSql = "Select * from Equipo";

                SqlCommand cmd = new SqlCommand(sentenciaSql, con);

                SqlDataReader lectorDatos = cmd.ExecuteReader();

                while (lectorDatos.Read())
                {
                    equipo = new Equipo();

                    equipo.CodEquipo = (short)lectorDatos.GetInt32(0);
                    equipo.Descripcion = lectorDatos.GetString(1);
                    equipo.CodMarca = lectorDatos.GetInt32(2);
                    equipo.FechaAdq = lectorDatos.GetString(3);
                    equipo.CostoGs = lectorDatos.GetDouble(4);
                    equipo.CodSala = lectorDatos.GetInt32(5);
                    equipo.CodEstadoEquipo = lectorDatos.GetInt32(6);
                
                    ListaEquipo.Add(equipo);

                }

                return ListaEquipo;
            }
        }
    }
}
