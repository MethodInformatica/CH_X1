using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Departamento_DAO : Base
    {
        private int error;

        public Departamento_ENT insert(Departamento_ENT datosDepartamento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_DEPARTAMENTO";

                    cmd.Parameters.AddWithValue("@block", datosDepartamento.Block);
                    cmd.Parameters.AddWithValue("@piso", datosDepartamento.Piso);
                    cmd.Parameters.AddWithValue("@numero_depto", datosDepartamento.NumeroDepto);
                    cmd.Parameters.AddWithValue("@modelo", datosDepartamento.Modelo);

                    Departamento_ENT oDepartamento = new Departamento_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oDepartamento.IdDepartamento = Convert.ToInt32(reader["id_departamento"]);
                        oDepartamento.Block = reader["block"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["block"]);
                        oDepartamento.Piso = reader["piso"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["piso"]);
                        oDepartamento.NumeroDepto = reader["numero_depto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["numero_depto"]);
                        oDepartamento.Modelo = reader["modelo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["modelo"]);
                    }
                    return oDepartamento;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_DEPARTAMENTO", ex);
            }
        }

        public int delete(Departamento_ENT datosDepartamento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_DEPARTAMENTO";
                    cmd.Parameters.AddWithValue("@id_departamento", datosDepartamento.IdDepartamento);
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
                throw new Exception("Error al ejecutar SP_DELETE_DEPARTAMENTO", ex);
            }


        }

        public int update(Departamento_ENT datosDepartamento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_DEPARTAMENTO_IDDEPARTAMENTO";
                    cmd.Parameters.AddWithValue("@id_departamento", datosDepartamento.IdDepartamento);
                    cmd.Parameters.AddWithValue("@block", datosDepartamento.Block);
                    cmd.Parameters.AddWithValue("@piso", datosDepartamento.Piso);
                    cmd.Parameters.AddWithValue("@numero_depto", datosDepartamento.NumeroDepto);
                    cmd.Parameters.AddWithValue("@modelo", datosDepartamento.Modelo);
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

        public Departamento_ENT getForIdDepartamento(Departamento_ENT datosDepartamento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_DEPARTAMENTO_IDDEPARTAMENTO";
                    cmd.Parameters.AddWithValue("@id_departamento", datosDepartamento.IdDepartamento);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Departamento_ENT oDepartamento = new Departamento_ENT();
                    if (reader.Read())
                    {
                        oDepartamento.IdDepartamento = Convert.ToInt32(reader["id_departamento"]);
                        oDepartamento.Block = reader["block"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["block"]);
                        oDepartamento.Piso = reader["piso"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["piso"]);
                        oDepartamento.NumeroDepto = reader["numero_depto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["numero_depto"]);
                        oDepartamento.Modelo = reader["modelo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["modelo"]);

                        return oDepartamento;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_DEPARTAMENTO_IDDEPARTAMENTO", ex);
            }
        }
    }
}
