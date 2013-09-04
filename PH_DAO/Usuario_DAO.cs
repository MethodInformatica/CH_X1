using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PH_ENT;

namespace PH_DAO
{
    public class Usuario_DAO : Base
    {
        public UsuarioSistema_ENT getForIdUsuario(UsuarioSistema_ENT oUsuario)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_USUARIO_IDUSUARIO";
                    cmd.Parameters.AddWithValue("@id_usuario_sistema", oUsuario.IdUsuarioSistema);
                    SqlDataReader reader = cmd.ExecuteReader();                    
                    if (reader.Read())
                    {
                        UsuarioSistema_ENT usuario = new UsuarioSistema_ENT();
                        usuario.IdUsuarioSistema = Convert.ToInt32(reader["id_usuario_sistema"]);
                        usuario.Rut = reader["rut"].Equals(DBNull.Value) ? "" : reader["rut"].ToString();
                        usuario.Nombres = reader["nombres"].Equals(DBNull.Value) ? "" : reader["nombres"].ToString();
                        usuario.ApPaterno = reader["appaterno"].Equals(DBNull.Value) ? "" : reader["appaterno"].ToString();
                        usuario.ApMaterno = reader["apmaterno"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["apmaterno"]);
                        usuario.Usuario = reader["usuario"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["usuario"]);
                        usuario.Clave = reader["clave"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["clave"]);
                        usuario.IdPerfil = reader["idPerfil"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["idPerfil"].ToString());
                        //usuario.Estado = reader["estado"].Equals(DBNull.Value) ? false : Convert.ToBoolean(reader["estado"].ToString());

                        return usuario;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_USUARIO_IDUSUARIO", ex);
            }
        }
    }
}
