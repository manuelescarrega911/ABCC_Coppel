using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCC_Articulos.CargasDeComboBox
{
    public class Clase_Familia
    {
        public String sLastError = "";

        String sServer = "";
        String sBaseDatos = "";
        String sUsuario = "";
        String sPassword = "";
        public Clase_Familia(String sServer, String sBaseDatos, String sUsuario, String sPassword)
        {
            this.sServer = sServer;
            this.sBaseDatos = sBaseDatos;
            this.sUsuario = sUsuario;
            this.sPassword = sPassword;
        }
        public Boolean Combo_Clase_Familia(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Familia, Nombre_Familia FROM Familia";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch
                {

                }
                finally
                {

                }
            }

            return Correcto;

        }
        public Boolean Combo_Clase_Familia_1(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Familia, Nombre_Familia FROM CLASE_FAMILIA_1";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch
                {

                }
                finally
                {

                }
            }

            return Correcto;

        }

        public Boolean Combo_Clase_Familia_2(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Familia, Nombre_Familia FROM CLASE_FAMILIA_2";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch
                {

                }
                finally
                {

                }
            }

            return Correcto;

        }
        public Boolean Combo_Clase_Familia_3(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Familia, Nombre_Familia FROM CLASE_FAMILIA_3";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch
                {

                }
                finally
                {

                }
            }

            return Correcto;

        }
        public Boolean Combo_Clase_Familia_4(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Familia, Nombre_Familia FROM CLASE_FAMILIA_4";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch
                {

                }
                finally
                {

                }
            }

            return Correcto;

        }
    }
}
