using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioMarca
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        //METODO PARA validar SI EXISTE LA MARCA --> 100%
        public bool existeMarca(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select descripcion from MARCAS where descripcion= @mar";
                comando.Parameters.AddWithValue("@mar", codigo);
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        //METODO PARA AGREGAR MARCA A DB --> 100%
        public void agregarMarca(String nuevo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into MARCAS(descripcion) values (@codii)";
                comando.Parameters.AddWithValue("@codii", nuevo);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        //METODO QUE TRAE TODAS LAS MARCAS PARA CARGAR EL CMBMARCAS
        public List<Marca> traerMarca()
        {
            try
            {
                List<Marca> listado = new List<Marca>();

                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id, descripcion from marcas";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Marca mar = new Marca();
                    mar.id = lector.GetInt32(0);
                    mar.marca = lector.GetString(1);

                    listado.Add(mar);
                }
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
