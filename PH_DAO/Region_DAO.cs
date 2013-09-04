using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class Region_DAO : Base
    {
        private int error;

        public Region_ENT insert(Region_ENT datosRegion)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_REGION";

                    cmd.Parameters.AddWithValue("@id_region", datosRegion.IdRegion);
                    cmd.Parameters.AddWithValue("@nombre", datosRegion.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosRegion.Estado);

                    Region_ENT oRegion = new Region_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oRegion.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oRegion.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oRegion.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["sitio"]);                        
                    }
                    return oRegion;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_REGION", ex);
            }
        }

        public int delete(Region_ENT datosRegion)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_REGION";
                    cmd.Parameters.AddWithValue("@id_region", datosRegion.IdRegion);
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
                throw new Exception("Error al ejecutar SP_DELETE_REGION", ex);
            }


        }

        public int update(Region_ENT datosRegion)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_REGION_IDREGION";

                    cmd.Parameters.AddWithValue("@id_region", datosRegion.IdRegion);
                    cmd.Parameters.AddWithValue("@nombre", datosRegion.Nombre);
                    cmd.Parameters.AddWithValue("@estado", datosRegion.Estado);
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
                throw new Exception("Error al ejecutar SP_UPDATE_REGION_IDREGION", ex);
            }
        }

        public Region_ENT getForIdRegion(Region_ENT datosRegion)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_REGION_IDREGION";
                    cmd.Parameters.AddWithValue("@id_region", datosRegion.IdRegion);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Region_ENT oRegion = new Region_ENT();
                    if (reader.Read())
                    {
                        oRegion.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oRegion.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oRegion.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]);                        
                        return oRegion;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_REGION_IDREGION", ex);
            }
        }

        public List<Region_ENT> listRegion()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_REGION";

                    List<Region_ENT> listRegion = new List<Region_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Region_ENT oRegion = new Region_ENT();

                        oRegion.IdRegion = Convert.ToInt32(reader["id_region"]);
                        oRegion.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oRegion.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]);                        

                        listRegion.Add(oRegion);
                    }
                    return listRegion;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_REGION", ex);
            }
        }

    }
}
