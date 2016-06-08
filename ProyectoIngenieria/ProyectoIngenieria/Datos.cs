using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoIngenieria
{
    class Datos
    {
        SqlConnection conexion;
        string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private SqlConnection abrir()
        {
            try
            {
                conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void cerrar()
        {
            try { conexion.Close(); }
            catch (Exception) { }
        }
        public bool insertarStore(string Nombre, string apP, string apM, string tipo, string tel, string email, string prof)
        {
            try
            {
                SqlCommand comando = new SqlCommand("AgregarAsesores", abrir()); //   COMANDO
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);  //@stor_id ES NOMBRE DE COLUMNA 
                comando.Parameters.Add("@ApP", SqlDbType.VarChar, 30); //SqlDbType ES EL FORMATO DE CAMPO DE SQL
                comando.Parameters.Add("@ApM", SqlDbType.VarChar, 30);
                comando.Parameters.Add("@Tipo", SqlDbType.VarChar, 20);
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 10);
                comando.Parameters.Add("@Correo", SqlDbType.VarChar, 50);
                comando.Parameters.Add("@Profesion", SqlDbType.VarChar, 30);
                comando.Parameters["@Nombre"].Value = Nombre;
                comando.Parameters["@ApP"].Value = apP;
                comando.Parameters["@ApM"].Value = apM;
                comando.Parameters["@Tipo"].Value = tipo;
                comando.Parameters["@Telefono"].Value = tel;
                comando.Parameters["@Correo"].Value = email;
                comando.Parameters["@profesion"].Value = prof;

                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ModificarAlumnos(int matricula, string nombre, string paterno, string materno, string carrera, string tel, string correo, string proyecto, string empresa)
        {
            try
            {
                SqlCommand comando = new SqlCommand("modAlumnos", abrir());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Matricula", SqlDbType.Int);
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 30);
                comando.Parameters.Add("@ApP", SqlDbType.VarChar, 30);
                comando.Parameters.Add("@ApM", SqlDbType.VarChar, 30);
                comando.Parameters.Add("@Carrera", SqlDbType.VarChar, 20);
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 10);
                comando.Parameters.Add("@Correo", SqlDbType.VarChar, 50);
                comando.Parameters.Add("@NombreProyecto", SqlDbType.VarChar, 80);
                comando.Parameters.Add("@Empresa", SqlDbType.VarChar, 30);

                comando.Parameters["@Matricula"].Value = matricula;
                comando.Parameters["@Nombre"].Value = nombre;
                comando.Parameters["@ApP"].Value = paterno;
                comando.Parameters["@ApM"].Value = materno;
                comando.Parameters["@Carrera"].Value = carrera;
                comando.Parameters["@Telefono"].Value = tel;
                comando.Parameters["@Correo"].Value = correo;
                comando.Parameters["@NombreProyecto"].Value = proyecto;
                comando.Parameters["@Empresa"].Value = empresa;

                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Elim_Alumnos(int matricula)
        {
            try
            {
                SqlCommand comando = new SqlCommand("elimAlumnos", abrir());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Matricula", SqlDbType.Int);
                comando.Parameters["@Matricula"].Value = matricula;
                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataSet verAlumno(string alumno)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(alumno, abrir());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cerrar();
                return ds;
            }
            catch (Exception) { return null; }
        }
        public bool insertarRequisitos(string matricula, bool serv,bool credi, int calif, bool extra, string fecha)
        {
            try
            {
                SqlCommand comando = new SqlCommand("AgregarRequisistos", abrir());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Matricula", SqlDbType.VarChar, 10);
                comando.Parameters.Add("@Servicio", SqlDbType.Bit);
                comando.Parameters.Add("@Creditos", SqlDbType.Bit);
                comando.Parameters.Add("@Calificacion", SqlDbType.Int);
                comando.Parameters.Add("@Extra", SqlDbType.Bit);
                comando.Parameters.Add("@fecha", SqlDbType.DateTime);
                
                comando.Parameters["@Matricula"].Value = matricula;
                comando.Parameters["@Servicio"].Value = serv;
                comando.Parameters["@Creditos"].Value = credi;
                comando.Parameters["@Calificacion"].Value = calif;
                comando.Parameters["@Extra"].Value = extra;
                comando.Parameters["@fecha"].Value = fecha;
                

                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        /*
         * Cliente SMTP
         * Gmail:  smtp.gmail.com  puerto:587
         */ 
        SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

        public bool correo(string correo, string pass)
        {
            /*
             * Autenticacion en el Servidor
             * Utilizaremos nuestra cuenta de correo
             *
             * Direccion de Correo (Gmail o Hotmail)
             * y Contrasena correspondiente
             */
            server.Credentials = new System.Net.NetworkCredential(correo, pass);
            server.EnableSsl = true;
            return true;
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }

        public bool InsertarDoc(bool Solicitud, bool Anteproyecto, bool Carta, bool Dictamen, bool Asignacion, bool AsesorExt, bool Seguimiento, bool Registro, bool CartaAgrad, bool CDInforme, bool CDRes, bool CartaAcep)
        {
            try
            {
                SqlCommand comando = new SqlCommand("AgregarDocumentacion", abrir());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Solicitud", SqlDbType.Bit);
                comando.Parameters.Add("@Anteproyecto", SqlDbType.Bit);
                comando.Parameters.Add("@Carta", SqlDbType.Bit);
                comando.Parameters.Add("@Dictamen", SqlDbType.Bit);
                comando.Parameters.Add("@Asignacion", SqlDbType.Bit);
                comando.Parameters.Add("@AsesorExt", SqlDbType.Bit);
                comando.Parameters.Add("@Seguimiento", SqlDbType.Bit);
                comando.Parameters.Add("@Registro", SqlDbType.Bit);
                comando.Parameters.Add("@CartaAgradecimiento", SqlDbType.Bit);
                comando.Parameters.Add("@CDInforme", SqlDbType.Bit);
                comando.Parameters.Add("@CDRes", SqlDbType.Bit);
                comando.Parameters.Add("@CartaAcep", SqlDbType.Bit);

                comando.Parameters["@Solicitud"].Value = Solicitud;
                comando.Parameters["@Anteproyecto"].Value = Anteproyecto;
                comando.Parameters["@Carta"].Value = Carta;
                comando.Parameters["@Dictamen"].Value = Dictamen;
                comando.Parameters["@Asignacion"].Value = Asignacion;
                comando.Parameters["@AsesorExt"].Value = AsesorExt;
                comando.Parameters["@Seguimiento"].Value = Seguimiento;
                comando.Parameters["@Registro"].Value = Registro;
                comando.Parameters["@CartaAgradecimiento"].Value = CartaAgrad;
                comando.Parameters["@CDInforme"].Value = CDInforme;
                comando.Parameters["@CDRes"].Value = CDRes;
                comando.Parameters["@CartaAcep"].Value = CartaAcep;

                comando.ExecuteNonQuery();
                cerrar();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

        }

        public bool ActualizarDoc(int Folio, bool Solicitud, bool Anteproyecto, bool Carta, bool Dictamen, bool Asignacion, bool AsesorExt, bool Seguimiento, bool Registro, bool CartaAgrad, bool CDInforme, bool CDRes, bool CartaAcep)
        {
            try
            {
                SqlCommand comando = new SqlCommand("modDocumentacion", abrir());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Folio", SqlDbType.Int);
                comando.Parameters.Add("@Solicitud", SqlDbType.Bit);
                comando.Parameters.Add("@Anteproyecto", SqlDbType.Bit);
                comando.Parameters.Add("@Carta", SqlDbType.Bit);
                comando.Parameters.Add("@Dictamen", SqlDbType.Bit);
                comando.Parameters.Add("@Asignacion", SqlDbType.Bit);
                comando.Parameters.Add("@AsesorExt", SqlDbType.Bit);
                comando.Parameters.Add("@Seguimiento", SqlDbType.Bit);
                comando.Parameters.Add("@Registro", SqlDbType.Bit);
                comando.Parameters.Add("@CartaAgradecimiento", SqlDbType.Bit);
                comando.Parameters.Add("@CDInforme", SqlDbType.Bit);
                comando.Parameters.Add("@CDRes", SqlDbType.Bit);
                comando.Parameters.Add("@CartaAcep", SqlDbType.Bit);

                comando.Parameters["@Folio"].Value = Folio;
                comando.Parameters["@Solicitud"].Value = Solicitud;
                comando.Parameters["@Anteproyecto"].Value = Anteproyecto;
                comando.Parameters["@Carta"].Value = Carta;
                comando.Parameters["@Dictamen"].Value = Dictamen;
                comando.Parameters["@Asignacion"].Value = Asignacion;
                comando.Parameters["@AsesorExt"].Value = AsesorExt;
                comando.Parameters["@Seguimiento"].Value = Seguimiento;
                comando.Parameters["@Registro"].Value = Registro;
                comando.Parameters["@CartaAgradecimiento"].Value = CartaAgrad;
                comando.Parameters["@CDInforme"].Value = CDInforme;
                comando.Parameters["@CDRes"].Value = CDRes;
                comando.Parameters["@CartaAcep"].Value = CartaAcep;

                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public DataSet muestra(string Query)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Query, abrir());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cerrar();
                return ds;
            }
            catch (Exception)
            { return null; }

        }


    }
}
