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

        public DetalleProducto_ENT insert(Cliente_ENT datosCliente, DetalleProducto_ENT datosDetalleProducto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_DETALLEPRODCUTO";

                    cmd.Parameters.AddWithValue("@id_producto", datosDetalleProducto.IdProducto);
                    cmd.Parameters.AddWithValue("@numero_reserva", datosDetalleProducto.NumeroReserva);
                    cmd.Parameters.AddWithValue("@fecha_reserva", datosDetalleProducto.FechaReserva);
                    cmd.Parameters.AddWithValue("@numero_carta_oferta", datosDetalleProducto.NumeroCartaOferta);
                    cmd.Parameters.AddWithValue("@fecha_carta_oferta", datosDetalleProducto.FechaCartaOferta);
                    cmd.Parameters.AddWithValue("@caracteristicas", datosDetalleProducto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@deslines", datosDetalleProducto.Deslines);
                    cmd.Parameters.AddWithValue("@orientacion", datosDetalleProducto.Orientacion);
                    cmd.Parameters.AddWithValue("@mts_construidos", datosDetalleProducto.MtsConstruidos);
                    cmd.Parameters.AddWithValue("@mts_terreno", datosDetalleProducto.MtsTerreno);
                    cmd.Parameters.AddWithValue("@direccion_comunal", datosDetalleProducto.DireccionComunal);
                    cmd.Parameters.AddWithValue("@rol_sii", datosDetalleProducto.RolSii);
                    cmd.Parameters.AddWithValue("@ejecutivo_venta", datosDetalleProducto.EjecutivoVenta);
                    cmd.Parameters.AddWithValue("@fecha_venta", datosDetalleProducto.FechaVenta);
                    cmd.Parameters.AddWithValue("@codigo_proyecto_cliente", datosDetalleProducto.CodigoProyectoCliente);
                    cmd.Parameters.AddWithValue("@valor_uf", datosDetalleProducto.ValorUf);
                    cmd.Parameters.AddWithValue("@descuento", datosDetalleProducto.Descuento);
                    cmd.Parameters.AddWithValue("@valor_final_uf", datosDetalleProducto.ValorFinalUf);
                    cmd.Parameters.AddWithValue("@gastos_operacionales_uf", datosDetalleProducto.GastosOperacionalesUf);

                    DetalleProducto_ENT detalleProducto = new DetalleProducto_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        detalleProducto.IdDetalle = Convert.ToInt32(reader["id_detalle"]);
                        datosDetalleProducto.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);
                        datosDetalleProducto.NumeroReserva = reader["numero_reserva"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_reserva"]);
                        datosDetalleProducto.FechaReserva = reader["fecha_reserva"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_reserva"]);
                        datosDetalleProducto.NumeroCartaOferta = reader["numero_carta_oferta"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_carta_oferta"]);
                        datosDetalleProducto.FechaCartaOferta = reader["fecha_carta_oferta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_carta_oferta"]);
                        datosDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        datosDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        datosDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        datosDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        datosDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        datosDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        datosDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        datosDetalleProducto.EjecutivoVenta = reader["ejecutivo_venta"].Equals(DBNull.Value) ?  0 : Convert.ToInt32(reader["ejecutivo_venta"]);
                        datosDetalleProducto.FechaVenta = reader["fecha_venta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_venta"]);
                        datosDetalleProducto.CodigoProyectoCliente = reader["codigo_proyecto_cliente"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_proyecto_cliente"]);
                        datosDetalleProducto.ValorUf = reader["valor_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_uf"]);
                        datosDetalleProducto.Descuento = reader["descuento"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["descuento"]);
                        datosDetalleProducto.ValorFinalUf = reader["valor_final_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["valor_final_uf"]);
                        datosDetalleProducto.GastosOperacionalesUf = reader["gastos_operacionales_uf"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["gastos_operacionales_uf"]);
                    }
                    return detalleProducto;
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
                    cmd.CommandText = "SP_UPDATE_DETALLEPRODCUTO_IDDETALLE";

                    cmd.Parameters.AddWithValue("@id_detalle", detalleProducto.IdDetalle);
                    cmd.Parameters.AddWithValue("@id_producto", detalleProducto.IdProducto);
                    cmd.Parameters.AddWithValue("@numero_reserva", detalleProducto.NumeroReserva);
                    cmd.Parameters.AddWithValue("@fecha_reserva", detalleProducto.FechaReserva);
                    cmd.Parameters.AddWithValue("@numero_carta_oferta", detalleProducto.NumeroCartaOferta);
                    cmd.Parameters.AddWithValue("@fecha_carta_oferta", detalleProducto.FechaCartaOferta);
                    cmd.Parameters.AddWithValue("@caracteristicas", detalleProducto.Caracteristicas);
                    cmd.Parameters.AddWithValue("@deslines", detalleProducto.Deslines);
                    cmd.Parameters.AddWithValue("@orientacion", detalleProducto.Orientacion);
                    cmd.Parameters.AddWithValue("@mts_construidos", detalleProducto.MtsConstruidos);
                    cmd.Parameters.AddWithValue("@mts_terreno", detalleProducto.MtsTerreno);
                    cmd.Parameters.AddWithValue("@direccion_comunal", detalleProducto.DireccionComunal);
                    cmd.Parameters.AddWithValue("@rol_sii", detalleProducto.RolSii);
                    cmd.Parameters.AddWithValue("@ejecutivo_venta", detalleProducto.EjecutivoVenta);
                    cmd.Parameters.AddWithValue("@fecha_venta", detalleProducto.FechaVenta);
                    cmd.Parameters.AddWithValue("@codigo_proyecto_cliente", detalleProducto.CodigoProyectoCliente);
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
                        oDetalleProducto.NumeroReserva = reader["numero_reserva"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_reserva"]);
                        oDetalleProducto.FechaReserva = reader["fecha_reserva"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_reserva"]);
                        oDetalleProducto.NumeroCartaOferta = reader["numero_carta_oferta"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_carta_oferta"]);
                        oDetalleProducto.FechaCartaOferta = reader["fecha_carta_oferta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_carta_oferta"]);
                        oDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        oDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        oDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        oDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        oDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        oDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        oDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        oDetalleProducto.EjecutivoVenta = reader["ejecutivo_venta"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["ejecutivo_venta"]);
                        oDetalleProducto.FechaVenta = reader["fecha_venta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_venta"]);
                        oDetalleProducto.CodigoProyectoCliente = reader["codigo_proyecto_cliente"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_proyecto_cliente"]);
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
                        oDetalleProducto.NumeroReserva = reader["numero_reserva"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_reserva"]);
                        oDetalleProducto.FechaReserva = reader["fecha_reserva"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_reserva"]);
                        oDetalleProducto.NumeroCartaOferta = reader["numero_carta_oferta"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["numero_carta_oferta"]);
                        oDetalleProducto.FechaCartaOferta = reader["fecha_carta_oferta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_carta_oferta"]);
                        oDetalleProducto.Caracteristicas = reader["caracteristicas"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["caracteristicas"]);
                        oDetalleProducto.Deslines = reader["deslines"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["deslines"]);
                        oDetalleProducto.Orientacion = reader["orientacion"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["orientacion"]);
                        oDetalleProducto.MtsConstruidos = reader["mts_construidos"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_construidos"]);
                        oDetalleProducto.MtsTerreno = reader["mts_terreno"].Equals(DBNull.Value) ? 0 : Convert.ToDecimal(reader["mts_terreno"]);
                        oDetalleProducto.DireccionComunal = reader["direccion_comunal"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_comunal"]);
                        oDetalleProducto.RolSii = reader["rol_sii"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rol_sii"]);
                        oDetalleProducto.EjecutivoVenta = reader["ejecutivo_venta"].Equals(DBNull.Value) ?  0: Convert.ToInt32(reader["ejecutivo_venta"]);
                        oDetalleProducto.FechaVenta = reader["fecha_venta"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_venta"]);
                        oDetalleProducto.CodigoProyectoCliente = reader["codigo_proyecto_cliente"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_proyecto_cliente"]);
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
