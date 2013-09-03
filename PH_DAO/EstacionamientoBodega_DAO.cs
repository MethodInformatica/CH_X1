using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class EstacionamientoBodega_DAO :Base
    {
        private int error;

        public EstacionamientoBodega_ENT insert(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_ESTACIONAMIENTOBODEGA";

                    cmd.Parameters.AddWithValue("@numero_est_bod", datosEstacionamientoBodega.NumeroEstBod);

                    EstacionamientoBodega_ENT oEstacionamientoBodega = new EstacionamientoBodega_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oEstacionamientoBodega.IdEstacionamientoBodega = Convert.ToInt32(reader["id_estacionamiento_bodega"]);
                        oEstacionamientoBodega.NumeroEstBod = reader["numero_est_bod"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["numero_est_bod"]);
                    }
                    return oEstacionamientoBodega;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_ESTACIONAMIENTOBODEGA", ex);
            }
        }

        public int delete(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_ESTACIONAMIENTOBODEGA";
                    cmd.Parameters.AddWithValue("@id_estacionamiento_bodega", datosEstacionamientoBodega.IdEstacionamientoBodega);
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
                throw new Exception("Error al ejecutar SP_DELETE_ESTACIONAMIENTOBODEGA", ex);
            }


        }

        public int update(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_ESTACIONAMIENTOBODEGA_IDESTACIONAMIENTOBODEGA";
                    cmd.Parameters.AddWithValue("@id_estacionamiento_bodega", datosEstacionamientoBodega.IdEstacionamientoBodega);
                    cmd.Parameters.AddWithValue("@numero_est_bod", datosEstacionamientoBodega.NumeroEstBod);
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
                throw new Exception("Error al ejecutar SP_UPDATE_CASA_IDCASA", ex);
            }
        }

        public EstacionamientoBodega_ENT getForIdEstacionamientoBodega(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_ESTACIONAMIENTOBODEGA_IDESTACIONAMIENTOBODEGA";
                    cmd.Parameters.AddWithValue("@id_estacionamiento_bodega", datosEstacionamientoBodega.IdEstacionamientoBodega);
                    SqlDataReader reader = cmd.ExecuteReader();
                    EstacionamientoBodega_ENT oEstacionamientoBodega = new EstacionamientoBodega_ENT();
                    if (reader.Read())
                    {
                        oEstacionamientoBodega.IdEstacionamientoBodega = Convert.ToInt32(reader["id_estacionamiento_bodega"]);
                        oEstacionamientoBodega.NumeroEstBod = reader["numero_est_bod"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["numero_est_bod"]);
                        return oEstacionamientoBodega;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_ESTACIONAMIENTOBODEGA_IDESTACIONAMIENTOBODEGA", ex);
            }
        }


    }
}
