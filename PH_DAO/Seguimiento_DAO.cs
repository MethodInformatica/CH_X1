using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Seguimiento_DAO : Base
    {
        private int error;

        public Seguimiento_ENT insert(Seguimiento_ENT datosSeguimiento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_SEGUIMIENTO";

                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosSeguimiento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@id_usuario", datosSeguimiento.IdUsuario);
                    cmd.Parameters.AddWithValue("@fecha", datosSeguimiento.Fecha);
                    cmd.Parameters.AddWithValue("@mensaje", datosSeguimiento.Mensaje);

                    Seguimiento_ENT oSeguimiento = new Seguimiento_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oSeguimiento.IdSeguimiento = Convert.ToInt32(reader["id_seguimiento"]);
                        oSeguimiento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oSeguimiento.IdUsuario = reader["id_usuario"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_usuario"]);
                        oSeguimiento.Fecha = reader["fecha"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha"]);
                        oSeguimiento.Mensaje = reader["mensaje"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["mensaje"]);
                    }
                    return oSeguimiento;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_SEGUIMIENTO", ex);
            }
        }

        public int delete(Seguimiento_ENT datosSeguimiento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_SEGUIMIENTO";
                    cmd.Parameters.AddWithValue("@id_seguimiento", datosSeguimiento.IdSeguimiento);
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
                throw new Exception("Error al ejecutar SP_DELETE_SEGUIMIENTO", ex);
            }


        }

        public int update(Seguimiento_ENT datosSeguimiento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_SEGUIMIENTO_IDSEGUIMIENTO";

                    cmd.Parameters.AddWithValue("@id_seguimiento", datosSeguimiento.IdSeguimiento);
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosSeguimiento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@id_usuario", datosSeguimiento.IdUsuario);
                    cmd.Parameters.AddWithValue("@fecha", datosSeguimiento.Fecha);
                    cmd.Parameters.AddWithValue("@mensaje", datosSeguimiento.Mensaje);
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
                throw new Exception("Error al ejecutar SP_UPDATE_SEGUIMIENTO_IDSEGUIMIENTO", ex);
            }
        }

        public Seguimiento_ENT getForIdSeguimiento(Seguimiento_ENT datosSeguimiento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_SEGUIMIENTO_IDSEGUIMIENTO";
                    cmd.Parameters.AddWithValue("@id_seguimiento", datosSeguimiento.IdSeguimiento);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Seguimiento_ENT oSeguimiento = new Seguimiento_ENT();
                    if (reader.Read())
                    {
                        oSeguimiento.IdSeguimiento = Convert.ToInt32(reader["id_seguimiento"]);
                        oSeguimiento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oSeguimiento.IdUsuario = reader["id_usuario"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_usuario"]);
                        oSeguimiento.Fecha = reader["fecha"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha"]);
                        oSeguimiento.Mensaje = reader["mensaje"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["mensaje"]);
                        return oSeguimiento;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_SEGUIMIENTO_IDSEGUIMIENTO", ex);
            }
        }

        public List<Seguimiento_ENT> getAllByPage(Seguimiento_ENT documento, int desde, int hasta)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_BYPAGE_SEGUIMIENTO";
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", documento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@desde", desde);
                    cmd.Parameters.AddWithValue("@hasta", hasta);
                    List<Seguimiento_ENT> listado = new List<Seguimiento_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Seguimiento_ENT oSeguimiento = new Seguimiento_ENT();
                        oSeguimiento.IdSeguimiento = Convert.ToInt32(reader["id_seguimiento"]);
                        oSeguimiento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oSeguimiento.IdUsuario = reader["id_usuario"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_usuario"]);
                        oSeguimiento.Fecha = reader["fecha"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha"]);
                        oSeguimiento.Mensaje = reader["mensaje"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["mensaje"]);
                        listado.Add(oSeguimiento);
                    }
                    return listado;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_BYPAGE_SEGUIMIENTO", ex);
            }
        }

        public int getCount(Seguimiento_ENT documento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_COUNT_SEGUIMIENTO";
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", documento.IdConjuntoHabitacional);
                     SqlDataReader reader = cmd.ExecuteReader();
                     if (reader.Read())
                     {
                         return  reader["total"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["total"]);                         
                     }
                     else
                     {
                         return 0;
                     }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_COUNT_SEGUIMIENTO", ex);
            }
        }
    }
}
