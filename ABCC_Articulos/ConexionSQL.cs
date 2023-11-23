using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace ABCC_Articulos
{

    public class InfoArticulos
    {
        public Int64 SKu;
        public String Articulo;
        public String Marca;
        public String Modelo;
        public Int64 Departamento;
        public Int64 Clase;
        public Int64 Familia;
        public DateTime FechaAlta;
        public Int64 Stock;
        public Int64 Cantidad;
        public Boolean Descontinuado;
        public DateTime FechaBaja;
    }
    public class ConexionSQL
    {

        String sServer = "";
        String sBaseDatos = "";
        String sUsuario = "";
        String sPassword = "";
        public ConexionSQL(String sServer, String sBaseDatos, String sUsuario, String sPassword)
        {
            this.sServer = sServer;
            this.sBaseDatos = sBaseDatos;
            this.sUsuario = sUsuario;
            this.sPassword = sPassword;
        }

        public Boolean ALtaArticulos(InfoArticulos infoArticulos)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {

                connection.Open();
                try
                {
                    String CommnadText = "EXECUTE dbo.Sp_Insert_Articulo @Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @FechaAlta, @Stock, @Catidad, @Descontinuado, @FechaBaja";
                    SqlCommand cmd = new SqlCommand (CommnadText, connection);

                    cmd.Parameters.Add("@Sku", System.Data.SqlDbType.BigInt);
                    cmd.Parameters.Add("@Articulo", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Marca", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Modelo", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Clase", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Familia", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@FechaAlta", System.Data.SqlDbType.DateTime);
                    cmd.Parameters.Add("@Stock", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Catidad", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Descontinuado", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@FechaBaja", System.Data.SqlDbType.DateTime);

                    cmd.Parameters["@Sku"].Value = infoArticulos.SKu;
                    cmd.Parameters["@Articulo"].Value = infoArticulos.Articulo;
                    cmd.Parameters["@Marca"].Value = infoArticulos.Marca;
                    cmd.Parameters["@Modelo"].Value = infoArticulos.Modelo;
                    cmd.Parameters["@Departamento"].Value = infoArticulos.Departamento;
                    cmd.Parameters["@Clase"].Value = infoArticulos.Clase;
                    cmd.Parameters["@Familia"].Value = infoArticulos.Familia;
                    cmd.Parameters["@FechaAlta"].Value = infoArticulos.FechaAlta;
                    cmd.Parameters["@Stock"].Value = infoArticulos.Stock;
                    cmd.Parameters["@Catidad"].Value = infoArticulos.Cantidad;
                    cmd.Parameters["@Descontinuado"].Value = infoArticulos.Descontinuado;
                    cmd.Parameters["@FechaBaja"].Value = infoArticulos.FechaBaja;

                    cmd.ExecuteNonQuery();
                    Correcto = true;

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close(); 
                }
            }
            return Correcto;
        }


        public Boolean BajaArticulos(Int64 Sku_Articulos)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                connection.Open();
                try
                {
                    String CommnadText = "EXECUTE dbo.SP_DELETE_ARTICULO @Sku";
                    SqlCommand cmd = new SqlCommand(CommnadText, connection);
                    cmd.Parameters.Add("@Sku", System.Data.SqlDbType.BigInt);
                    cmd.Parameters["@Sku"].Value = Sku_Articulos;
                    cmd.ExecuteNonQuery();
                    Correcto = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    connection.Close();
                }
            }
            return Correcto;
        }

        public Boolean UpdateArticulos(InfoArticulos infoArticulos)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {

                connection.Open();
                try
                {
                    String CommnadText = "EXECUTE dbo.SP_UPDATE_ARTICULO @Sku, @Articulo, @Marca, @Modelo, @Departamento, @Clase, @Familia, @FechaAlta, @Stock, @Catidad, @Descontinuado, @FechaBaja";
                    SqlCommand cmd = new SqlCommand(CommnadText, connection);

                    cmd.Parameters.Add("@Sku", System.Data.SqlDbType.BigInt);
                    cmd.Parameters.Add("@Articulo", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Marca", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Modelo", System.Data.SqlDbType.VarChar);
                    cmd.Parameters.Add("@Departamento", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Clase", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Familia", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@FechaAlta", System.Data.SqlDbType.DateTime);
                    cmd.Parameters.Add("@Stock", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Catidad", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@Descontinuado", System.Data.SqlDbType.Int);
                    cmd.Parameters.Add("@FechaBaja", System.Data.SqlDbType.DateTime);

                    cmd.Parameters["@Sku"].Value = infoArticulos.SKu;
                    cmd.Parameters["@Articulo"].Value = infoArticulos.Articulo;
                    cmd.Parameters["@Marca"].Value = infoArticulos.Marca;
                    cmd.Parameters["@Modelo"].Value = infoArticulos.Modelo;
                    cmd.Parameters["@Departamento"].Value = infoArticulos.Departamento;
                    cmd.Parameters["@Clase"].Value = infoArticulos.Clase;
                    cmd.Parameters["@Familia"].Value = infoArticulos.Familia;
                    cmd.Parameters["@FechaAlta"].Value = infoArticulos.FechaAlta;
                    cmd.Parameters["@Stock"].Value = infoArticulos.Stock;
                    cmd.Parameters["@Catidad"].Value = infoArticulos.Cantidad;
                    cmd.Parameters["@Descontinuado"].Value = infoArticulos.Descontinuado;
                    cmd.Parameters["@FechaBaja"].Value = infoArticulos.FechaBaja;

                    cmd.ExecuteNonQuery();
                    Correcto = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Correcto;
        }



        public Boolean ConsultaArt(Int64 Sku_Articulos, ref InfoArticulos infoArticulos)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                connection.Open();
                try
                {
                    String sCmdSql = "Select Articulo, Marca, Modelo, Departamento, Clase, Familia, FechaAlta, Stock, Catidad, Descontinuado, FechaBaja " +
                                    $" from InfoArticulos where Sku = '{Sku_Articulos}'";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        infoArticulos.Articulo = reader[0].ToString();
                        infoArticulos.Marca = reader[1].ToString();
                        infoArticulos.Modelo = reader[2].ToString();
                        infoArticulos.Departamento = Convert.ToInt32(reader[3]);
                        infoArticulos.Clase = Convert.ToInt64(reader[4]);
                        infoArticulos.Familia = Convert.ToInt64(reader[5]);
                        infoArticulos.FechaAlta = Convert.ToDateTime(reader[6]);
                        infoArticulos.Stock = Convert.ToInt64(reader[7]);
                        infoArticulos.Cantidad = Convert.ToInt64(reader[8]);
                        infoArticulos.Descontinuado = Convert.ToBoolean(reader[9]);
                        infoArticulos.FechaBaja = Convert.ToDateTime(reader[10]);

                        Correcto = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    connection.Close();

                }
            }
            return Correcto;
        }
        public Boolean CargaCombo(ref DataTable dataTable)
        {
            Boolean Correcto = false;
            using (SqlConnection connection = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    String sCmdSql = "select Numero_Departamento, Nombre_Departamento from Departamento ";
                    SqlCommand cmd = new SqlCommand(sCmdSql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    Correcto = true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    connection.Close ();
                }
            }

           return Correcto;

        }

        public Boolean ConsultaGeneral(Int64 Sku_Articulos, ref DataTable tabla)
        {
            Boolean Correcto = false;
            using (SqlConnection conn = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    conn.Open();

                    String sCmdSql = "EXECUTE dbo.SP_VIEW_ARTICULO @SKu";
                    SqlCommand cmd = new SqlCommand(sCmdSql, conn);
                    cmd.Parameters.Add("@Sku", System.Data.SqlDbType.BigInt);
                    cmd.Parameters["@Sku"].Value = Sku_Articulos;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adapter.Fill(tabla);

                    Correcto = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return Correcto;
        }
        public Boolean Consulta_Departamento(ref DataTable tabla)
        {
            Boolean Correcto = false;
            using (SqlConnection conn = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    conn.Open();

                    String sCmdSql = "EXECUTE dbo.SP_VIEW_DEPA";
                    SqlCommand cmd = new SqlCommand(sCmdSql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adapter.Fill(tabla);

                    Correcto = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return Correcto;
        }
        public Boolean Consulta_Clase(ref DataTable tabla)
        {
            Boolean Correcto = false;
            using (SqlConnection conn = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    conn.Open();

                    String sCmdSql = "EXECUTE dbo.SP_VIEW_CLASE";
                    SqlCommand cmd = new SqlCommand(sCmdSql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adapter.Fill(tabla);

                    Correcto = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return Correcto;
        }

        public Boolean Consulta_Familia(ref DataTable tabla)
        {
            Boolean Correcto = false;
            using (SqlConnection conn = new SqlConnection($"Server={this.sServer};Database={this.sBaseDatos};User Id={this.sUsuario};Password={this.sPassword};"))
            {
                try
                {
                    conn.Open();

                    String sCmdSql = "EXECUTE dbo.SP_VIEW_FAMILIA";
                    SqlCommand cmd = new SqlCommand(sCmdSql, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adapter.Fill(tabla);

                    Correcto = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return Correcto;
        }

    }
}
