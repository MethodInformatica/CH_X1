using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class Cliente_DAO : Base
    {
        private int error;

        public Cliente_ENT insert(Cliente_ENT datosCliente)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_CLIENTE";

                    cmd.Parameters.AddWithValue("@id_producto", datosCliente.IdProducto);
                    cmd.Parameters.AddWithValue("@rut", datosCliente.Rut);
                    cmd.Parameters.AddWithValue("@nombre", datosCliente.Nombre);
                    cmd.Parameters.AddWithValue("@email", datosCliente.Email);
                    cmd.Parameters.AddWithValue("@area", datosCliente.Area);
                    cmd.Parameters.AddWithValue("@telefono", datosCliente.Telefono);

                    Cliente_ENT oCliente = new Cliente_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oCliente.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                        oCliente.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);
                        oCliente.Rut = reader["rut"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut"]);
                        oCliente.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oCliente.Email = reader["email"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["email"]);
                        oCliente.Area = reader["area"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["area"]);
                        oCliente.Telefono = reader["telefono"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["telefono"]);
                    }
                    return oCliente;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_CLIENTE", ex);
            }
        }

        public int delete(Cliente_ENT datosCliente)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_CLIENTE";
                    cmd.Parameters.AddWithValue("@id_cliente", datosCliente.IdCliente);
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
                throw new Exception("Error al ejecutar SP_DELETE_CLIENTE", ex);
            }


        }

        public int update(Cliente_ENT datosCliente)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_CLIENTE_IDCLIENTE";

                    cmd.Parameters.AddWithValue("@id_cliente", datosCliente.IdCliente);
                    cmd.Parameters.AddWithValue("@id_producto", datosCliente.IdProducto);
                    cmd.Parameters.AddWithValue("@rut", datosCliente.Rut);
                    cmd.Parameters.AddWithValue("@nombre", datosCliente.Nombre);
                    cmd.Parameters.AddWithValue("@email", datosCliente.Email);
                    cmd.Parameters.AddWithValue("@area", datosCliente.Area);
                    cmd.Parameters.AddWithValue("@telefono", datosCliente.Telefono);
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
                throw new Exception("Error al ejecutar SP_UPDATE_CLIENTE_IDCLIENTE", ex);
            }
        }

        public Cliente_ENT getForIdCliente(Cliente_ENT datosCliente)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_CLIENTE_IDCLIENTE";
                    cmd.Parameters.AddWithValue("@id_cliente", datosCliente.IdCliente);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Cliente_ENT oCliente = new Cliente_ENT();
                    if (reader.Read())
                    {
                        oCliente.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                        oCliente.IdProducto = reader["id_producto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_producto"]);
                        oCliente.Rut = reader["rut"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut"]);
                        oCliente.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oCliente.Email = reader["email"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["email"]);
                        oCliente.Area = reader["area"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["area"]);
                        oCliente.Telefono = reader["telefono"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["telefono"]);
                        return oCliente;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_CLIENTE_IDCLIENTE", ex);
            }
        }
    }
}
