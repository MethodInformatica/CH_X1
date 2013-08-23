using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class TipoProducto_DAO : Base
    {
        private int error;

        public TipoProducto_ENT insert(TipoProducto_ENT datosTipoProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_TIPOPRODUCTO";

                    cmd.Parameters.AddWithValue("@nombre", datosTipoProducto.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosTipoProducto.Estado);

                    TipoProducto_ENT oTipoProducto = new TipoProducto_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oTipoProducto.IdTipoProducto = Convert.ToInt32(reader["id_tipo_producto"]);
                        oTipoProducto.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oTipoProducto.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]);
                    }
                    return oTipoProducto;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_TIPOPRODUCTO", ex);
            }
        }

        public int delete(TipoProducto_ENT datosTipoProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_TIPOPRODUCTO";
                    cmd.Parameters.AddWithValue("@id_tipo_producto", datosTipoProducto.IdTipoProducto);
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
                throw new Exception("Error al ejecutar SP_DELETE_TIPOPRODUCTO", ex);
            }


        }

        public int update(TipoProducto_ENT datosTipoProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_TIPOPRODUCTO_IDTIPOPRODUCTO";

                    cmd.Parameters.AddWithValue("@id_tipo_producto", datosTipoProducto.IdTipoProducto);
                    cmd.Parameters.AddWithValue("@nombre", datosTipoProducto.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosTipoProducto.Estado);
                    
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
                throw new Exception("Error al ejecutar SP_UPDATE_TIPOPRODUCTO_IDTIPOPRODUCTO", ex);
            }
        }

        public TipoProducto_ENT getForIdTipoProducto(TipoProducto_ENT datosTipoProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_TIPOPRODUCTO_IDTIPOPRODUCTO";
                    cmd.Parameters.AddWithValue("@id_tipo_producto", datosTipoProducto.IdTipoProducto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    TipoProducto_ENT oTipoProducto = new TipoProducto_ENT();
                    if (reader.Read())
                    {
                        oTipoProducto.IdTipoProducto = Convert.ToInt32(reader["id_tipo_producto"]);
                        oTipoProducto.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oTipoProducto.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]);
                        return oTipoProducto;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_TIPOPRODUCTO_IDTIPOPRODUCTO", ex);
            }
        }

    }
}
