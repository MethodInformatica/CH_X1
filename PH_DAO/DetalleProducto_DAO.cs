using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class DetalleProducto_DAO : Base
    {

        private int error;

        public DetalleProducto_ENT insert(DetalleProducto_ENT detalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_DETALLEPRODCUTO";

                    cmd.Parameters.AddWithValue("@id_producto", detalleProducto.IdProducto);

                    cmd.Parameters.AddWithValue("@caracteristicas", detalleProducto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@deslines", detalleProducto.Deslines);
                    cmd.Parameters.AddWithValue("@orientacion", detalleProducto.Orientacion);
                    cmd.Parameters.AddWithValue("@direccion", detalleProducto.Direccion);
                    cmd.Parameters.AddWithValue("@mts_construidos", detalleProducto.MtsConstruidos);
                    cmd.Parameters.AddWithValue("@mts_terreno", detalleProducto.MtsTerreno);
                    cmd.Parameters.AddWithValue("@direccion_comunal", detalleProducto.DireccionComunal);
                    cmd.Parameters.AddWithValue("@rol_sii", detalleProducto.RolSii);
                    cmd.Parameters.AddWithValue("@estado_producto", detalleProducto.EstadoProducto);

                    cmd.Parameters.AddWithValue("@valor_uf", detalleProducto.ValorUf);
                    cmd.Parameters.AddWithValue("@descuento", detalleProducto.Descuento);
                    cmd.Parameters.AddWithValue("@valor_final_uf", detalleProducto.ValorFinalUf);
                    cmd.Parameters.AddWithValue("@gastos_operacionales_uf", detalleProducto.GastosOperacionalesUf);

                    DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oDetalleProducto.IdDetalle = Convert.ToInt32(reader["id_detalle"]);
                        oDetalleProducto.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);

                        oDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        oDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        oDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        oDetalleProducto.Direccion = reader["direccion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion"]);
                        oDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        oDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        oDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        oDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        oDetalleProducto.EstadoProducto = reader["estado_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["estado_producto"]);

                        oDetalleProducto.ValorUf = reader["valor_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_uf"]);
                        oDetalleProducto.Descuento = reader["descuento"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["descuento"]);
                        oDetalleProducto.ValorFinalUf = reader["valor_final_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_final_uf"]);
                        oDetalleProducto.GastosOperacionalesUf = reader["gastos_operacionales_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["gastos_operacionales_uf"]);
                    }
                    return oDetalleProducto;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_PRODUCTO", ex);
            }
        }

        public int delete(DetalleProducto_ENT detalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_DETALLEPRODUCTO";
                    cmd.Parameters.AddWithValue("@id_detalle", detalleProducto.IdDetalle);
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

        public int update(DetalleProducto_ENT detalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_DETALLEPRODUCTO_IDDETALLE";

                    cmd.Parameters.AddWithValue("@id_detalle", detalleProducto.IdDetalle);
                    cmd.Parameters.AddWithValue("@id_producto", detalleProducto.IdProducto);

                    cmd.Parameters.AddWithValue("@caracteristicas", detalleProducto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@deslines", detalleProducto.Deslines);
                    cmd.Parameters.AddWithValue("@orientacion", detalleProducto.Orientacion);
                    cmd.Parameters.AddWithValue("@direccion", detalleProducto.Direccion);
                    cmd.Parameters.AddWithValue("@mts_construidos", detalleProducto.MtsConstruidos);
                    cmd.Parameters.AddWithValue("@mts_terreno", detalleProducto.MtsTerreno);
                    cmd.Parameters.AddWithValue("@direccion_comunal", detalleProducto.DireccionComunal);
                    cmd.Parameters.AddWithValue("@rol_sii", detalleProducto.RolSii);
                    cmd.Parameters.AddWithValue("@estado_producto", detalleProducto.EstadoProducto);

                    cmd.Parameters.AddWithValue("@valor_uf", detalleProducto.ValorUf);
                    cmd.Parameters.AddWithValue("@descuento", detalleProducto.Descuento);
                    cmd.Parameters.AddWithValue("@valor_final_uf", detalleProducto.ValorFinalUf);
                    cmd.Parameters.AddWithValue("@gastos_operacionales_uf", detalleProducto.GastosOperacionalesUf);

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
                throw new Exception("Error al ejecutar SP_UPDATE_DETALLEPRODCUTO_IDDETALLE", ex);
            }
        }

        public DetalleProducto_ENT getForIdProducto(DetalleProducto_ENT detalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_DETALLEPRODUCTO_IDPRODUCTO";
                    cmd.Parameters.AddWithValue("@id_producto", detalleProducto.IdProducto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
                    if (reader.Read())
                    {
                        oDetalleProducto.IdDetalle = Convert.ToInt32(reader["id_detalle"]);
                        oDetalleProducto.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);

                        oDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        oDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        oDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        oDetalleProducto.Direccion = reader["direccion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion"]);
                        oDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        oDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        oDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        oDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        oDetalleProducto.EstadoProducto = reader["estado_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["estado_producto"]);

                        oDetalleProducto.ValorUf = reader["valor_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_uf"]);
                        oDetalleProducto.Descuento = reader["descuento"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["descuento"]);
                        oDetalleProducto.ValorFinalUf = reader["valor_final_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_final_uf"]);
                        oDetalleProducto.GastosOperacionalesUf = reader["gastos_operacionales_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["gastos_operacionales_uf"]);

                        return oDetalleProducto;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_DETALLEPRODUCTO_IDPRODUCTO", ex);
            }
        }

        public DetalleProducto_ENT getForIdDetalle(DetalleProducto_ENT detalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_DETALLEPRODUCTO_IDDETALLE";
                    cmd.Parameters.AddWithValue("@id_detalle", detalleProducto.IdDetalle);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DetalleProducto_ENT oDetalleProducto = new DetalleProducto_ENT();
                    if (reader.Read())
                    {
                        oDetalleProducto.IdDetalle = Convert.ToInt32(reader["id_detalle"]);
                        oDetalleProducto.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);

                        oDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        oDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        oDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        oDetalleProducto.Direccion = reader["direccion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion"]);
                        oDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        oDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        oDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        oDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        oDetalleProducto.EstadoProducto = reader["estado_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["estado_producto"]);

                        oDetalleProducto.ValorUf = reader["valor_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_uf"]);
                        oDetalleProducto.Descuento = reader["descuento"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["descuento"]);
                        oDetalleProducto.ValorFinalUf = reader["valor_final_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_final_uf"]);
                        oDetalleProducto.GastosOperacionalesUf = reader["gastos_operacionales_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["gastos_operacionales_uf"]);

                        return oDetalleProducto;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_DETALLEPRODUCTO_IDDETALLE", ex);
            }
        }

    }
}