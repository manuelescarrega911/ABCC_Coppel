using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCC_Articulos.CargasDeComboBox
{
    public class Departamento_Clase
    {

        public String sLastError = "";

        String sServer = "";
        String sBaseDatos = "";
        String sUsuario = "";
        String sPassword = "";
        public Departamento_Clase(String sServer, String sBaseDatos, String sUsuario, String sPassword)
        {
            this.sServer = sServer;
            this.sBaseDatos = sBaseDatos;
            this.sUsuario = sUsuario;
            this.sPassword = sPassword;
        }
        public Boolean Combo_Depa_Clase(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Clase, Nombre_Clase FROM Clase";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
        public Boolean Combo_Depa_Clase_1(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Clase, Nombre_Clase FROM DEPARTAMENTO_CLASE_1";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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


        public Boolean Combo_Depa_Clase_2(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Clase, Nombre_Clase FROM DEPARTAMENTO_CLASE_2";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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


        public Boolean Combo_Depa_Clase_3(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Clase, Nombre_Clase FROM DEPARTAMENTO_CLASE_3";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

        public Boolean Combo_Depa_Clase_4(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "SELECT Numero_Clase, Nombre_Clase FROM DEPARTAMENTO_CLASE_4";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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
