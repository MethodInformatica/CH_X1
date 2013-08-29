using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class Documento_DAO : Base
    {
        private int error;

        public Documento_ENT insert(Documento_ENT datosDocumento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_DOCUMENTO";

                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosDocumento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@folio", datosDocumento.Folio);
                    cmd.Parameters.AddWithValue("@nombre", datosDocumento.Nombre);
                    cmd.Parameters.AddWithValue("@fecha_documento", datosDocumento.FechaDocumento);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", datosDocumento.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", datosDocumento.FechaIngreso);
                    cmd.Parameters.AddWithValue("@descripcion", datosDocumento.Descripcion);
                    cmd.Parameters.AddWithValue("@archivo_nombre", datosDocumento.ArchivoNombre);
                    cmd.Parameters.AddWithValue("@archivo_extencion", datosDocumento.ArchivoExtencion);
                    cmd.Parameters.AddWithValue("@archivo_tipo", datosDocumento.ArchivoTipo);
                    cmd.Parameters.AddWithValue("@estado", datosDocumento.Estado);

                    Documento_ENT oDatosDocumento = new Documento_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        datosDocumento.IdDocumento = Convert.ToInt32(reader["id_documento"]);
                        datosDocumento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        datosDocumento.Folio = reader["folio"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["folio"]);
                        datosDocumento.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        datosDocumento.FechaDocumento = reader["fecha_documento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_documento"]);
                        datosDocumento.FechaVencimiento = reader["fecha_vencimiento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_vencimiento"]);
                        datosDocumento.FechaIngreso = reader["fecha_ingreso"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_ingreso"]);
                        datosDocumento.Descripcion = reader["descripcion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["descripcion"]);
                        datosDocumento.ArchivoNombre = reader["archivo_nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_nombre"]);
                        datosDocumento.ArchivoExtencion = reader["archivo_extencion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_extencion"]);
                        datosDocumento.ArchivoTipo = reader["archivo_tipo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_tipo"]);
                        datosDocumento.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]); 
                    }
                    return oDatosDocumento;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_DOCUMENTO", ex);
            }
        }

        public int delete(Documento_ENT datosDocumento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_DOCUMENTO";
                    cmd.Parameters.AddWithValue("@id_documento", datosDocumento.IdDocumento);
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
                throw new Exception("Error al ejecutar SP_DELETE_DOCUMENTO", ex);
            }


        }

        public int update(Documento_ENT datosDocumento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_DOCUMENTO_IDDOCUMENTO";

                    cmd.Parameters.AddWithValue("@id_documento", datosDocumento.IdDocumento);
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosDocumento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosDocumento.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@folio", datosDocumento.Folio);
                    cmd.Parameters.AddWithValue("@nombre", datosDocumento.Nombre);
                    cmd.Parameters.AddWithValue("@fecha_documento", datosDocumento.FechaDocumento);
                    cmd.Parameters.AddWithValue("@fecha_vencimiento", datosDocumento.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", datosDocumento.FechaIngreso);
                    cmd.Parameters.AddWithValue("@descripcion", datosDocumento.Descripcion);
                    cmd.Parameters.AddWithValue("@archivo_nombre", datosDocumento.ArchivoNombre);
                    cmd.Parameters.AddWithValue("@archivo_extencion", datosDocumento.ArchivoExtencion);
                    cmd.Parameters.AddWithValue("@archivo_tipo", datosDocumento.ArchivoTipo);
                    cmd.Parameters.AddWithValue("@estado", datosDocumento.Estado);

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
                throw new Exception("Error al ejecutar SP_UPDATE_DOCUMENTO_IDDOCUMENTO", ex);
            }
        }

        public List<Documento_ENT> listConjuntoHabitacional(int idConjunto)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_DOCUMENTOS_BY_IDCONJUNTO";
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", idConjunto);
                    List<Documento_ENT> listDocumento = new List<Documento_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Documento_ENT datosDocumento = new Documento_ENT();
                        datosDocumento.IdDocumento = Convert.ToInt32(reader["id_documento"]);
                        datosDocumento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        datosDocumento.Folio = reader["folio"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["folio"]);
                        datosDocumento.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        datosDocumento.FechaDocumento = reader["fecha_documento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_documento"]);
                        datosDocumento.FechaVencimiento = reader["fecha_vencimiento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_vencimiento"]);
                        datosDocumento.FechaIngreso = reader["fecha_ingreso"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_ingreso"]);
                        datosDocumento.Descripcion = reader["descripcion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["descripcion"]);
                        datosDocumento.ArchivoNombre = reader["archivo_nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_nombre"]);
                        datosDocumento.ArchivoExtencion = reader["archivo_extencion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_extencion"]);
                        datosDocumento.ArchivoTipo = reader["archivo_tipo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_tipo"]);
                        datosDocumento.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]); 

                        listDocumento.Add(datosDocumento);
                    }
                    return listDocumento;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_DOCUMENTOS_BY_IDCONJUNTO", ex);
            }
        }

        public Documento_ENT getForIdDocumento(Documento_ENT datosDocumento)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_DOCUMENTO_IDDOCUMENTO";
                    cmd.Parameters.AddWithValue("@id_documento", datosDocumento.IdDocumento);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Documento_ENT oDatosDocumento = new Documento_ENT();
                    if (reader.Read())
                    {
                        oDatosDocumento.IdDocumento = Convert.ToInt32(reader["id_documento"]);
                        oDatosDocumento.IdConjuntoHabitacional = reader["id_conjunto_habitacional"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oDatosDocumento.Folio = reader["folio"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["folio"]);
                        oDatosDocumento.Nombre = reader["nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre"]);
                        oDatosDocumento.FechaDocumento = reader["fecha_documento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_documento"]);
                        oDatosDocumento.FechaVencimiento = reader["fecha_vencimiento"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_vencimiento"]);
                        oDatosDocumento.FechaIngreso = reader["fecha_ingreso"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_ingreso"]);
                        oDatosDocumento.Descripcion = reader["descripcion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["descripcion"]);
                        oDatosDocumento.ArchivoNombre = reader["archivo_nombre"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_nombre"]);
                        oDatosDocumento.ArchivoExtencion = reader["archivo_extencion"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_extencion"]);
                        oDatosDocumento.ArchivoTipo = reader["archivo_tipo"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["archivo_tipo"]);
                        oDatosDocumento.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"]); 

                        return oDatosDocumento;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_DOCUMENTO_IDDOCUMENTO", ex);
            }
        }
    }
}
