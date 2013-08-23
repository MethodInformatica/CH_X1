using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class Casa_DAO : Base
    {
        private int error;

        public Casa_ENT insert(Casa_ENT datosCasa)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_CASA";

                    cmd.Parameters.AddWithValue("@manzana", datosCasa.Manzana);
                    cmd.Parameters.AddWithValue("@sitio", datosCasa.Sitio);
                    cmd.Parameters.AddWithValue("@casa_esquina", datosCasa.CasaEsquina);
                    cmd.Parameters.AddWithValue("@modelo", datosCasa.Modelo);

                    Casa_ENT oCasa = new Casa_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oCasa.IdCasa = Convert.ToInt32(reader["id_casa"]);
                        oCasa.Manzana = reader["manzana"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["manzana"]);
                        oCasa.Sitio = reader["sitio"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["sitio"]);
                        oCasa.CasaEsquina = reader["casa_esquina"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["casa_esquina"]);
                        oCasa.Modelo = reader["modelo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["modelo"]);
                    }
                    return oCasa;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_CASA", ex);
            }
        }

        public int delete(Casa_ENT datosCasa)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_CASA";
                    cmd.Parameters.AddWithValue("@id_casa", datosCasa.IdCasa);
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
                throw new Exception("Error al ejecutar SP_DELETE_CASA", ex);
            }


        }

        public int update(Casa_ENT datosCasa)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_CASA_IDCASA";
                    cmd.Parameters.AddWithValue("@id_casa", datosCasa.IdCasa);
                    cmd.Parameters.AddWithValue("@manzana", datosCasa.Manzana);
                    cmd.Parameters.AddWithValue("@sitio", datosCasa.Sitio);
                    cmd.Parameters.AddWithValue("@casa_esquina", datosCasa.CasaEsquina);
                    cmd.Parameters.AddWithValue("@modelo", datosCasa.Modelo);
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

        public Casa_ENT getForIdCasa(Casa_ENT datosCasa)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_CASA_IDCASA";
                    cmd.Parameters.AddWithValue("@id_casa", datosCasa.IdCasa);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Casa_ENT oCasa = new Casa_ENT();
                    if (reader.Read())
                    {
                        oCasa.IdCasa = Convert.ToInt32(reader["id_casa"]);
                        oCasa.Manzana = reader["manzana"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["manzana"]);
                        oCasa.Sitio = reader["sitio"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["sitio"]);
                        oCasa.CasaEsquina = reader["casa_esquina"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["casa_esquina"]);
                        oCasa.Modelo = reader["modelo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["modelo"]); ;
                        return oCasa;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_CASA_IDCASA", ex);
            }
        }

    }
}
