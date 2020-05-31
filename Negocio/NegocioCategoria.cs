using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public  class NegocioCategoria
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        //METODO PARA validar SI EXISTE LA CATEGORIA --> 100%
        public bool existeCategoria(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select descripcion from CATEGORIAS where descripcion= @cat";
                comando.Parameters.AddWithValue("@cat", codigo);
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

        //METODO PARA AGREGAR CATEGORIA A DB -->100%
        public void agregarCategoria(String nuevo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into CATEGORIAS(descripcion) values (@codi)";
                comando.Parameters.AddWithValue("@codi", nuevo);
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

        //METODO QUE TRAE TODAS LAS CATEGORIAS PARA CARGAR EL CMBCATEGORIAS --> 
        public List<Categoria> traerCategorias()
        {
            try
            {
                List<Categoria> listado = new List<Categoria>();

                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id, descripcion from categorias";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Categoria cat = new Categoria();
                    cat.id = lector.GetInt32(0);
                    cat.categoria = lector.GetString(1);

                    listado.Add(cat);
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
