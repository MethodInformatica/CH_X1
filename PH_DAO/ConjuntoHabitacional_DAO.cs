using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using System.Data.SqlClient;

namespace PH_DAO
{
    public class ConjuntoHabitacional_DAO : Base
    {
        private int error;

        public ConjuntoHabitacional_ENT insert(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERT_CONJUNTOHABITACIONAL";

                    cmd.Parameters.AddWithValue("@codigo_conjunto", datosConjuntoHabitacional.CodigoConjunto);
                    cmd.Parameters.AddWithValue("@nombre_conjunto", datosConjuntoHabitacional.NombreConjunto);
                    cmd.Parameters.AddWithValue("@etapa", datosConjuntoHabitacional.Etapa);
                    cmd.Parameters.AddWithValue("@id_comuna_conjunto", datosConjuntoHabitacional.IdComunaConjunto);
                    cmd.Parameters.AddWithValue("@direccion_conjunto", datosConjuntoHabitacional.DireccionConjunto);
                    cmd.Parameters.AddWithValue("@rut_constructora", datosConjuntoHabitacional.RutConstructora);
                    cmd.Parameters.AddWithValue("@nombre_constructora", datosConjuntoHabitacional.NombreConstructora);
                    cmd.Parameters.AddWithValue("@rut_empresa_vendedora", datosConjuntoHabitacional.RutEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@nombre_empresa_vendedora", datosConjuntoHabitacional.NombreEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@representante_empresa_vendedora", datosConjuntoHabitacional.RepresentanteEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@id_comuna_empresa_vendedora", datosConjuntoHabitacional.IdComunaEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@direccion_empresa_vendedora", datosConjuntoHabitacional.DireccionEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@area_empresa_vendedora", datosConjuntoHabitacional.AreaEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@telefono_empresa_vendedora", datosConjuntoHabitacional.TelefonoEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@email_empresa_vendedora", datosConjuntoHabitacional.EmailEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@fecha_contrato", datosConjuntoHabitacional.FechaContrato);
                    cmd.Parameters.AddWithValue("@fecha_termino_construccion", datosConjuntoHabitacional.FechaTerminoConstruccion);
                    cmd.Parameters.AddWithValue("@fecha_recepcion_municipal", datosConjuntoHabitacional.FechaRecepcionMunicipal);                    
                    cmd.Parameters.AddWithValue("@fecha_recepcion_prohogar", datosConjuntoHabitacional.FechaRecepcionProhogar);

                    ConjuntoHabitacional_ENT oConjuntoHabitacional = new ConjuntoHabitacional_ENT();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oConjuntoHabitacional.IdConjuntoHabitacional = Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oConjuntoHabitacional.CodigoConjunto = reader["codigo_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_conjunto"]);
                        oConjuntoHabitacional.NombreConjunto = reader["nombre_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_conjunto"]);
                        oConjuntoHabitacional.Etapa = reader["etapa"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["etapa"]);
                        oConjuntoHabitacional.IdComunaConjunto = reader["id_comuna_conjunto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_comuna_conjunto"]);
                        oConjuntoHabitacional.DireccionConjunto = reader["direccion_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_conjunto"]);
                        oConjuntoHabitacional.RutConstructora = reader["rut_constructora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_constructora"]);
                        oConjuntoHabitacional.NombreConstructora = reader["nombre_constructora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_constructora"]);
                        oConjuntoHabitacional.RutEmpresaVendedora = reader["rut_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_empresa_vendedora"]);
                        oConjuntoHabitacional.NombreEmpresaVendedora = reader["nombre_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_empresa_vendedora"]);
                        oConjuntoHabitacional.RepresentanteEmpresaVendedora = reader["representante_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["representante_empresa_vendedora"]);
                        oConjuntoHabitacional.IdComunaEmpresaVendedora = reader["id_comuna_empresa_vendedora"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_comuna_empresa_vendedora"]);
                        oConjuntoHabitacional.DireccionEmpresaVendedora = reader["direccion_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_empresa_vendedora"]);
                        oConjuntoHabitacional.AreaEmpresaVendedora = reader["area_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["area_empresa_vendedora"]);
                        oConjuntoHabitacional.TelefonoEmpresaVendedora = reader["telefono_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["telefono_empresa_vendedora"]);
                        oConjuntoHabitacional.EmailEmpresaVendedora = reader["email_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["email_empresa_vendedora"]);
                        oConjuntoHabitacional.FechaContrato = reader["fecha_contrato"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_contrato"]);
                        oConjuntoHabitacional.FechaTerminoConstruccion = reader["fecha_termino_construccion"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_termino_construccion"]);
                        oConjuntoHabitacional.FechaRecepcionMunicipal = reader["fecha_recepcion_municipal"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_recepcion_municipal"]);
                        oConjuntoHabitacional.FechaRecepcionProhogar = reader["fecha_recepcion_prohogar"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_recepcion_prohogar"]);
                        
                    }
                    return oConjuntoHabitacional;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_INSERT_CONJUNTOHABITACIONAL", ex);
            }
        }

        public int delete(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DELETE_CONJUNTOHABITACIONAL";
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosConjuntoHabitacional.IdConjuntoHabitacional);
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
                throw new Exception("Error al ejecutar SP_DELETE_CONJUNTOHABITACIONAL", ex);
            }


        }

        public int update(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_UPDATE_CONJUNTO_IDCONJUNTOHABITACIONAL";

                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosConjuntoHabitacional.IdConjuntoHabitacional);
                    cmd.Parameters.AddWithValue("@codigo_conjunto", datosConjuntoHabitacional.CodigoConjunto);
                    cmd.Parameters.AddWithValue("@nombre_conjunto", datosConjuntoHabitacional.NombreConjunto);
                    cmd.Parameters.AddWithValue("@etapa", datosConjuntoHabitacional.Etapa);
                    cmd.Parameters.AddWithValue("@direccion_conjunto", datosConjuntoHabitacional.DireccionConjunto);
                    cmd.Parameters.AddWithValue("@rut_constructora", datosConjuntoHabitacional.RutConstructora);
                    cmd.Parameters.AddWithValue("@nombre_constructora", datosConjuntoHabitacional.NombreConstructora);
                    cmd.Parameters.AddWithValue("@rut_empresa_vendedora", datosConjuntoHabitacional.RutEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@nombre_empresa_vendedora", datosConjuntoHabitacional.NombreEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@id_comuna_empresa_vendedora", datosConjuntoHabitacional.IdComunaEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@direccion_empresa_vendedora", datosConjuntoHabitacional.DireccionEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@area_empresa_vendedora", datosConjuntoHabitacional.AreaEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@telefono_empresa_vendedora", datosConjuntoHabitacional.TelefonoEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@email_empresa_vendedora", datosConjuntoHabitacional.EmailEmpresaVendedora);
                    cmd.Parameters.AddWithValue("@fecha_contrato", datosConjuntoHabitacional.FechaContrato);
                    cmd.Parameters.AddWithValue("@fecha_termino_construccion", datosConjuntoHabitacional.FechaTerminoConstruccion);
                    cmd.Parameters.AddWithValue("@fecha_recepcion_municipal", datosConjuntoHabitacional.FechaRecepcionMunicipal);
                    cmd.Parameters.AddWithValue("@fecha_recepcion_prohogar", datosConjuntoHabitacional.FechaRecepcionProhogar);
                
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
                throw new Exception("Error al ejecutar SP_UPDATE_CONJUNTO_IDCONJUNTOHABITACIONAL", ex);
            }
        }

        public ConjuntoHabitacional_ENT getForIdConjuntoHabitacional(ConjuntoHabitacional_ENT datosConjuntoHabitacional)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_CONJUNTO_IDCONJUNTOHABITACIONAL";
                    cmd.Parameters.AddWithValue("@id_conjunto_habitacional", datosConjuntoHabitacional.IdConjuntoHabitacional);
                    SqlDataReader reader = cmd.ExecuteReader();
                    ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();
                    if (reader.Read())
                    {
                        oConjunto.IdConjuntoHabitacional = Convert.ToInt32(reader["@id_conjunto_habitacional"].ToString());
                        oConjunto.CodigoConjunto = reader["@codigo_conjunto"].ToString();
                        oConjunto.NombreConjunto = reader["@nombre_conjunto"].ToString();
                        oConjunto.Etapa = reader["@etapa"].ToString();
                        oConjunto.DireccionConjunto = reader["@direccion_conjunto"].ToString();
                        oConjunto.RutConstructora = reader["@rut_constructora"].ToString();
                        oConjunto.NombreConjunto = reader["@nombre_constructora"].ToString();
                        oConjunto.RutEmpresaVendedora = reader["@rut_empresa_vendedora"].ToString();
                        oConjunto.NombreEmpresaVendedora = reader["@nombre_empresa_vendedora"].ToString();
                        oConjunto.IdComunaEmpresaVendedora = Convert.ToInt32(reader["@id_comuna_empresa_vendedora"].ToString());
                        oConjunto.DireccionEmpresaVendedora = reader["@direccion_empresa_vendedora"].ToString();
                        oConjunto.AreaEmpresaVendedora = reader["@area_empresa_vendedora"].ToString();
                        oConjunto.TelefonoEmpresaVendedora = reader["@telefono_empresa_vendedora"].ToString();
                        oConjunto.EmailEmpresaVendedora = reader["@email_empresa_vendedora"].ToString();
                        oConjunto.FechaContrato = Convert.ToDateTime(reader["@fecha_contrato"].ToString());
                        oConjunto.FechaTerminoConstruccion = Convert.ToDateTime(reader["@fecha_termino_construccion"].ToString());
                        oConjunto.FechaRecepcionMunicipal = Convert.ToDateTime(reader["@fecha_recepcion_municipal"].ToString());
                        oConjunto.FechaRecepcionProhogar = Convert.ToDateTime(reader["@fecha_recepcion_prohogar"].ToString());                     

                        return oConjunto;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_GET_CONJUNTO_IDCONJUNTOHABITACIONAL", ex);
            }
        }

        public List<ConjuntoHabitacional_ENT> listConjuntoHabitacional()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.ConexionPH))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(this.ConexionPH, sqlConn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_LIST_ALL_CONJUNTOHABITACIONAL";

                    List<ConjuntoHabitacional_ENT> listConjunto = new List<ConjuntoHabitacional_ENT>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        ConjuntoHabitacional_ENT oConjunto = new ConjuntoHabitacional_ENT();

                        oConjunto.IdConjuntoHabitacional = Convert.ToInt32(reader["id_conjunto_habitacional"]);
                        oConjunto.CodigoConjunto = reader["codigo_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["codigo_conjunto"]);
                        oConjunto.NombreConjunto = reader["nombre_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_conjunto"]);
                        oConjunto.Etapa = reader["etapa"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["etapa"]);
                        oConjunto.IdComunaConjunto = reader["id_comuna_conjunto"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_comuna_conjunto"]);
                        oConjunto.DireccionConjunto = reader["direccion_conjunto"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_conjunto"]);
                        oConjunto.RutConstructora = reader["rut_constructora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_constructora"]);
                        oConjunto.NombreConstructora = reader["nombre_constructora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_constructora"]);
                        oConjunto.RutEmpresaVendedora = reader["rut_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["rut_empresa_vendedora"]);
                        oConjunto.NombreEmpresaVendedora = reader["nombre_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["nombre_empresa_vendedora"]);
                        oConjunto.RepresentanteEmpresaVendedora = reader["representante_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["representante_empresa_vendedora"]);
                        oConjunto.IdComunaEmpresaVendedora = reader["id_comuna_empresa_vendedora"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(reader["id_comuna_empresa_vendedora"]);
                        oConjunto.DireccionEmpresaVendedora = reader["direccion_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["direccion_empresa_vendedora"]);
                        oConjunto.AreaEmpresaVendedora = reader["area_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["area_empresa_vendedora"]);
                        oConjunto.TelefonoEmpresaVendedora = reader["telefono_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["telefono_empresa_vendedora"]);
                        oConjunto.EmailEmpresaVendedora = reader["email_empresa_vendedora"].Equals(DBNull.Value) ? "" : Convert.ToString(reader["email_empresa_vendedora"]);
                        oConjunto.FechaContrato = reader["fecha_contrato"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_contrato"]);
                        oConjunto.FechaTerminoConstruccion = reader["fecha_termino_construccion"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_termino_construccion"]);
                        oConjunto.FechaRecepcionMunicipal = reader["fecha_recepcion_municipal"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_recepcion_municipal"]);
                        oConjunto.FechaRecepcionProhogar = reader["fecha_recepcion_prohogar"].Equals(DBNull.Value) ? Convert.ToDateTime(null) : Convert.ToDateTime(reader["fecha_recepcion_prohogar"]);

                        listConjunto.Add(oConjunto);
                    }
                    return listConjunto;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP_LIST_ALL_CONJUNTOHABITACIONAL", ex);
            }
        }
    
    }

}
