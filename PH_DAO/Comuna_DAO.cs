using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Comuna_DAO : Base
    {
        private int error;

        public Comuna_ENT insert(Comuna_ENT datosComuna)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_COMUNA";

                    cmd.Parameters.AddWithValue("@id_comuna", datosComuna.IdComuna);
                    cmd.Parameters.AddWithValue("@id_ciudad", datosComuna.IdCiudad);
                    cmd.Parameters.AddWithValue("@nombre", datosComuna.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosComuna.Estado);

                    Comuna_ENT oComuna = new Comuna_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oComuna.IdComuna = Convert.ToInt32(reader["id_comuna"]);
                        oComuna.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oComuna.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oComuna.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);
                    }
                    return oComuna;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_COMUNA", ex);
            }
        }

        public int delete(Comuna_ENT datosComuna)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_COMUNA";
                    cmd.Parameters.AddWithValue("@id_comuna", datosComuna.IdComuna);
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
                throw new Exception("Error al ejecutar SP_DELETE_COMUNA", ex);
            }


        }

        public int update(Comuna_ENT datosComuna)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_COMUNA_IDCOMUNA";

                    cmd.Parameters.AddWithValue("@id_comuna", datosComuna.IdComuna);
                    cmd.Parameters.AddWithValue("@id_ciudad", datosComuna.IdCiudad);
                    cmd.Parameters.AddWithValue("@nombre", datosComuna.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosComuna.Estado);
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
                throw new Exception("Error al ejecutar SP_UPDATE_COMUNA_IDCOMUNA", ex);
            }
        }

        public Comuna_ENT getForIdComuna(Comuna_ENT datosComuna)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_COMUNA_IDCOMUNA";
                    cmd.Parameters.AddWithValue("@id_comuna", datosComuna.IdComuna);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Comuna_ENT oComuna = new Comuna_ENT();
                    if (reader.Read())
                    {
                        oComuna.IdComuna = Convert.ToInt32(reader["id_comuna"]);
                        oComuna.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oComuna.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oComuna.Estado = true;
                        return oComuna;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_COMUNA_IDCOMUNA", ex);
            }
        }

        public List<Comuna_ENT> listComunaForIdCiudad(Comuna_ENT datosComuna)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_COMUNA_IDCIUDAD";

                    cmd.Parameters.AddWithValue("@id_ciudad", datosComuna.IdCiudad);

                    List<Comuna_ENT> listComuna = new List<Comuna_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Comuna_ENT oComuna = new Comuna_ENT();

                        oComuna.IdComuna = Convert.ToInt32(reader["id_comuna"]);
                        oComuna.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oComuna.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oComuna.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);

                        listComuna.Add(oComuna);
                    }
                    return listComuna;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_COMUNA_IDCIUDAD", ex);
            }
        }
    }
}
