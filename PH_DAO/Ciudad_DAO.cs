using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Ciudad_DAO : Base
    {
        private int error;

        public Ciudad_ENT insert(Ciudad_ENT datosCiudad)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_CIUDAD";

                    cmd.Parameters.AddWithValue("@id_ciudad", datosCiudad.IdCiudad);
                    cmd.Parameters.AddWithValue("@id_region", datosCiudad.IdRegion);
                    cmd.Parameters.AddWithValue("@nombre", datosCiudad.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosCiudad.Estado);

                    Ciudad_ENT oCiudad = new Ciudad_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oCiudad.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oCiudad.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oCiudad.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oCiudad.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);
                    }
                    return oCiudad;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_CIUDAD", ex);
            }
        }

        public int delete(Ciudad_ENT datosCiudad)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_CIUDAD";
                    cmd.Parameters.AddWithValue("@id_ciudad", datosCiudad.IdCiudad);
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
                throw new Exception("Error al ejecutar SP_DELETE_CIUDAD", ex);
            }


        }

        public int update(Ciudad_ENT datosCiudad)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_CIUDAD_IDCIUDAD";

                    cmd.Parameters.AddWithValue("@id_ciudad", datosCiudad.IdCiudad);
                    cmd.Parameters.AddWithValue("@id_region", datosCiudad.IdRegion);
                    cmd.Parameters.AddWithValue("@nombre", datosCiudad.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosCiudad.Estado);
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
                throw new Exception("Error al ejecutar SP_UPDATE_CIUDAD_IDCIUDAD", ex);
            }
        }

        public Ciudad_ENT getForIdCiudad(Ciudad_ENT datosCiudad)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_CIUDAD_IDCIUDAD";
                    cmd.Parameters.AddWithValue("@id_region", datosCiudad.IdRegion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Ciudad_ENT oCiudad = new Ciudad_ENT();
                    if (reader.Read())
                    {
                        oCiudad.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oCiudad.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oCiudad.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oCiudad.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);
                        return oCiudad;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_CIUDAD_IDCIUDAD", ex);
            }
        }

        public List<Ciudad_ENT> listCiudadForIdRegion(Ciudad_ENT datosCiudad)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_CIUDAD_IDREGION";

                    cmd.Parameters.AddWithValue("@id_region", datosCiudad.IdRegion);

                    List<Ciudad_ENT> listCiudad = new List<Ciudad_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Ciudad_ENT oCiudad = new Ciudad_ENT();

                        oCiudad.IdCiudad = Convert.ToInt32(reader["id_ciudad"]);
                        oCiudad.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oCiudad.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oCiudad.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);

                        listCiudad.Add(oCiudad);
                    }
                    return listCiudad;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_CIUDAD_IDREGION", ex);
            }
        }
    }
}
