using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;

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
 


    }
}
