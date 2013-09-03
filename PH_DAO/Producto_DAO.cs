using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Producto_DAO : Base
    {
        private int error;

        public Producto_ENT insert(Producto_ENT datosProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_PRODUCTO";

                    cmd.Parameters.AddWithValue("@codigo_producto", datosProducto.CodigoProducto);
                    cmd.Parameters.AddWithValue("@id_tipo_producto", datosProducto.IdTipoProducto);
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosProducto.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@rut_cliente", datosProducto.RutCliente);
                    cmd.Parameters.AddWithValue("@id_referencia", datosProducto.IdReferencia);

                    Producto_ENT oProducto = new Producto_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oProducto.IdProducto = Convert.ToInt32(reader["id_producto"]);
                        oProducto.CodigoProducto = reader["codigo_producto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_producto"]);
                        oProducto.IdTipoProducto = reader["id_tipo_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_tipo_producto"]);
                        oProducto.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oProducto.RutCliente = reader["rut_cliente"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_cliente"]);
                        oProducto.IdReferencia = reader["id_referencia"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_referencia"]);
                    }
                    return oProducto;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_PRODUCTO", ex);
            }
        }

        public int delete(Producto_ENT datosProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_PRODUCTO";
                    cmd.Parameters.AddWithValue("@id_producto", datosProducto.IdProducto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        this.error = reader["error"].Equals(1) ? 1 : 0;
                    }
                    return this.error;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_DELETE_PRODUCTO", ex);
            }


        }

        public int update(Producto_ENT datosProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_PRODUCTO_IDPRODUCTO";

                    cmd.Parameters.AddWithValue("@id_producto", datosProducto.IdProducto);
                    cmd.Parameters.AddWithValue("@codigo_producto", datosProducto.CodigoProducto);
                    cmd.Parameters.AddWithValue("@id_tipo_producto", datosProducto.IdTipoProducto);
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosProducto.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@rut_cliente", datosProducto.RutCliente);
                    cmd.Parameters.AddWithValue("@id_referencia", datosProducto.IdReferencia);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.error = reader["error"].Equals(1) ? 1 : 0;
                    }
                    return this.error;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_UPDATE_PRODUCTO_IDPRODUCTO", ex);
            }
        }

        public Producto_ENT getForIdProducto(Producto_ENT datosProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_PRODUCTO_IDPRODUCTO";
                    cmd.Parameters.AddWithValue("@id_producto", datosProducto.IdProducto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Producto_ENT oProducto = new Producto_ENT();
                    if (reader.Read())
                    {
                        oProducto.IdProducto = Convert.ToInt32(reader["id_producto"]);
                        oProducto.CodigoProducto = reader["codigo_producto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_producto"]);
                        oProducto.IdTipoProducto = reader["id_tipo_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_tipo_producto"]);
                        oProducto.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oProducto.RutCliente = reader["rut_cliente"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_cliente"]);
                        oProducto.IdReferencia = reader["id_referencia"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_referencia"]);
                        return oProducto;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_PRODUCTO_IDPRODUCTO", ex);
            }
        }

        public List<Producto_ENT> listProducto()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_PRODUCTO";

                    List<Producto_ENT> listProducto = new List<Producto_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto_ENT oProducto = new Producto_ENT();

                        oProducto.IdProducto = Convert.ToInt32(reader["id_producto"]);
                        oProducto.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oProducto.IdReferencia = reader["id_referencia"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_referencia"]);
                        oProducto.CodigoProducto = reader["codigo_producto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_producto"]);
                        oProducto.TipoProducto = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oProducto.ValoUF = reader["valor_uf"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["valor_uf"]);
                        oProducto.IdTipoProducto = reader["id_tipo_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_tipo_producto"]);

                        listProducto.Add(oProducto);
                    }
                    return listProducto;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_PRODUCTO", ex);
            }
        }
    }
}
