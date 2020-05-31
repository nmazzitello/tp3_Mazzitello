using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class NegocioArticulo
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        //METODO PARA validar SI EXISTE EL ARTICULO --> 100%
        public bool existeArticulo(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select codigo from ARTICULOS where codigo= @art";
                comando.Parameters.AddWithValue("@art", codigo);
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

        //METODO PARA AGREGAR UN ARTICULO A LA DB-->100%
        public void guardarArticulo(String codigo, String nombre, String descripcion, int marca, int categoria, String imagen, float precio)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into ARTICULOS(codigo, nombre, descripcion, idmarca, idcategoria, imagenurl, precio) values (@cod, @nom, @desc, @mar, @cat, @ima, @pre)";
                comando.Parameters.AddWithValue("@cod", codigo);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@desc", descripcion);
                comando.Parameters.AddWithValue("@mar", marca);
                comando.Parameters.AddWithValue("@cat", categoria);
                comando.Parameters.AddWithValue("@ima", imagen);
                comando.Parameters.AddWithValue("@pre", precio);
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

        //METODOO QUE TRAE TODOS LOS ARTICULOS --> 100%
        public List<Articulo> listar()
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Codigo, a.Nombre, a.ImagenUrl, a.Precio, A.idCategoria, c.Descripcion, a.idmarca, m.Descripcion, a.Descripcion from ARTICULOS as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id order by codigo asc";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> listado = new List<Articulo>();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    Categoria cate = new Categoria();
                    Marca marc = new Marca();

                    art.codigo = lector.GetString(0);
                    art.nombre = lector.GetString(1);
                    art.imagen = lector.GetString(2);
                    art.precio = (float)lector.GetDecimal(3);

                    cate.id = lector.GetInt32(4);
                    cate.categoria = lector.GetString(5);
                    art.categoria = cate;
                    //art.cat.id = lector.GetInt32(4);
                    //art.cat.categoria = lector.GetString(5);

                    marc.id = lector.GetInt32(6);
                    marc.marca = lector.GetString(7);
                    art.marca = marc;
                   // art.marca = lector.GetString(6);

                    art.descripcion = lector.GetString(8);

                    listado.Add(art);
                }
                return listado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //METODO QUE TRAE EL ARTICULO QUE SE BUSCO POR CODIGO --> 100%
        public Articulo traerArtPorCod(String codigo)
        {
            try
            {
                conexion.ConnectionString= "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Codigo, a.Nombre, a.ImagenUrl, a.Precio, a.idCategoria, c.Descripcion, a.idMarca, m.Descripcion, a.Descripcion from ARTICULOS as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id where a.codigo like '"+codigo+"' ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                Articulo art = new Articulo();
                Categoria cate = new Categoria();
                Marca marc = new Marca();

                if(lector.Read())
                {
                    art.codigo = lector.GetString(0);
                    art.nombre = lector.GetString(1);
                    art.imagen = lector.GetString(2);
                    art.precio = (float)lector.GetDecimal(3);

                    cate.id = lector.GetInt32(4);
                    cate.categoria = lector.GetString(5);
                    art.categoria = cate;

                    marc.id = lector.GetInt32(6);
                    marc.marca = lector.GetString(7);
                    art.marca = marc;

                    art.descripcion = lector.GetString(8);
                }
                else
                {
                    art = null;
                }
                return art;
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

        //METODO QUE TRAE EL/LOS ARTICULO QUE SE BUSCO POR NOMBRE --> 100%
        public List<Articulo> traerArtPorNom(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Codigo, a.Nombre, a.ImagenUrl, a.Precio, a.idCategoria, c.Descripcion, a.idMarca, m.Descripcion, a.Descripcion from ARTICULOS as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id where nombre like '%" +codigo+ "%' order by 1 asc";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> listado = new List<Articulo>();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    Categoria cate = new Categoria();
                    Marca marc = new Marca();

                    art.codigo = lector.GetString(0);
                    art.nombre = lector.GetString(1);
                    art.imagen = lector.GetString(2);
                    art.precio = (float)lector.GetDecimal(3);
                    cate.id = lector.GetInt32(4);
                    cate.categoria = lector.GetString(5);
                    art.categoria = cate;
                    marc.id = lector.GetInt32(6);
                    marc.marca = lector.GetString(7);
                    art.marca = marc;
                    art.descripcion = lector.GetString(8);

                    listado.Add(art);
                }
                if(listado.Count==0)
                {
                    listado = null;
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

        //METODO QUE TRAE EL/LOS ARTICULOS POR CATEGORIA --> 100%
        public List<Articulo> traerArtPorCat(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Codigo, a.Nombre, a.ImagenUrl, a.Precio, a.idCategoria, c.Descripcion, a.idMarca, m.Descripcion, a.Descripcion from ARTICULOS as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id where C.descripcion like '%" + codigo + "%' order by 6 asc, 1 asc";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> listado = new List<Articulo>();

                while (lector.Read())
                {
                    Articulo art = new Articulo(); 
                    Categoria cate = new Categoria();
                    Marca marc = new Marca();

                    art.codigo = lector.GetString(0);
                    art.nombre = lector.GetString(1);
                    art.imagen = lector.GetString(2);
                    art.precio = (float)lector.GetDecimal(3);
                    cate.id = lector.GetInt32(4);
                    cate.categoria = lector.GetString(5);
                    art.categoria = cate;
                    marc.id = lector.GetInt32(6);
                    marc.marca = lector.GetString(7);
                    art.marca = marc;
                    art.descripcion = lector.GetString(8);

                    listado.Add(art);
                }
                if (listado.Count == 0)
                {
                    listado = null;
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

        //METODO QUE TRAE EL ARTICULO QUE SE BUSCO POR MARCA --> 100%
        public List<Articulo> traerArtPorMar(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Codigo, a.Nombre, a.ImagenUrl, a.Precio, a.idCategoria, c.Descripcion, a.idMarca, m.Descripcion, a.Descripcion from ARTICULOS as a inner join CATEGORIAS as c on a.IdCategoria = c.id inner join marcas as m on a.IdMarca = m.id where M.descripcion like '%" + codigo + "%' order by 8 asc, 1 asc";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> listado = new List<Articulo>();

                while (lector.Read())
                {
                    Articulo art = new Articulo();
                    Categoria cate = new Categoria();
                    Marca marc = new Marca();

                    art.codigo = lector.GetString(0);
                    art.nombre = lector.GetString(1);
                    art.imagen = lector.GetString(2);
                    art.precio = (float)lector.GetDecimal(3);
                    cate.id = lector.GetInt32(4);
                    cate.categoria = lector.GetString(5);
                    art.categoria = cate;
                    marc.id = lector.GetInt32(6);
                    marc.marca = lector.GetString(7);
                    art.marca = marc;
                    art.descripcion = lector.GetString(8);

                    listado.Add(art);
                }
                if (listado.Count == 0)
                {
                    listado = null;
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

        //METODO PARA ELIMINAR ARTICULO --> 100%
        public bool eliminarArt(String codigo)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "delete from ARTICULOS where codigo like '" +codigo+ "'";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

                return true;
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

        //METODO PARA MODIFICAR ARTICULO -->
        public bool modificarArt(String codigo, String codigoNue, String nombre, String descripcion, int marca, int categoria, String imagen, float precio)
        {
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-NBAJLFJ\\SQLEXPRESS; initial catalog= CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update articulos set codigo='"+codigoNue+"', nombre='"+nombre+"', descripcion='"+descripcion+"', idmarca='"+marca+"', idcategoria='"+categoria+"', imagenurl='"+imagen+"', precio='"+precio+"' where codigo like '"+codigo+"'";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

                return true;
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
