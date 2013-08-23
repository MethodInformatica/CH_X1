using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class LocalComercial_DAO : Base
    {
        private int error;

        public LocalComercial_ENT insert(LocalComercial_ENT datosLocalComercial)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_LOCALCOMERCIAL";

                    
                    cmd.Parameters.AddWithValue("@sitio", datosLocalComercial.Sitio);

                    LocalComercial_ENT oLocalComercial = new LocalComercial_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oLocalComercial.IdLocalComercial = Convert.ToInt32(reader["id_local_comercial"]);
                        oLocalComercial.Sitio = reader["sitio"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["sitio"]);
                    }
                    return oLocalComercial;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_LOCALCOMERCIAL", ex);
            }
        }

        public int delete(LocalComercial_ENT datosLocalComercial)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_LOCALCOMERCIAL";
                    cmd.Parameters.AddWithValue("@id_local_comercial", datosLocalComercial.IdLocalComercial);
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
                throw new Exception("Error al ejecutar SP_DELETE_LOCALCOMERCIAL", ex);
            }


        }

        public int update(LocalComercial_ENT datosLocalComercial)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_LOCALCOMERCIAL_IDLOCALCOMERCIAL";
                    cmd.Parameters.AddWithValue("@id_local_comercial", datosLocalComercial.IdLocalComercial);
                    cmd.Parameters.AddWithValue("@sitio", datosLocalComercial.Sitio);
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
                throw new Exception("Error al ejecutar SP_UPDATE_LOCALCOMERCIAL_IDLOCALCOMERCIAL", ex);
            }
        }

        public LocalComercial_ENT getForIdLocalComercial(LocalComercial_ENT datosLocalComercial)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_LOCALCOMERCIAL_IDLOCALCOMERCIAL";
                    cmd.Parameters.AddWithValue("@id_local_comercial", datosLocalComercial.IdLocalComercial);
                    SqlDataReader reader = cmd.ExecuteReader();
                    LocalComercial_ENT oLocalComercial = new LocalComercial_ENT();
                    if (reader.Read())
                    {
                        oLocalComercial.IdLocalComercial = Convert.ToInt32(reader["id_local_comercial"]);
                        oLocalComercial.Sitio = reader["sitio"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["sitio"]);

                        return oLocalComercial;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_LOCALCOMERCIAL_IDLOCALCOMERCIAL", ex);
            }
        }

    }
}
