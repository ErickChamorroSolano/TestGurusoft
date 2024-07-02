using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using TestGurusoft.Models;

namespace TestGurusoft.Data
{
    public class Registro
    {
        public int InsertarRequest(Requests oRequest) {
            using (SqlConnection conn = new SqlConnection(Conexion.rutaDB))
            {
                SqlCommand cmd = new SqlCommand("InsertarRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@request", oRequest.request);
                cmd.Parameters.AddWithValue("@response", oRequest.response);
                cmd.Parameters.AddWithValue("@usuario", oRequest.usuario);

                try {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                } 
                catch {
                    return -1;
                }
            }
        }

        public List<Requests> RecuperarRequests() {
            List<Requests> requests = new List<Requests>();
            using (SqlConnection conn = new SqlConnection(Conexion.rutaDB))
            {
                SqlCommand cmd = new SqlCommand("RecuperarRequests", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    conn.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            requests.Add(new Requests()
                            {
                                id = Convert.ToInt32(dr["Id"]),
                                request = dr["request"].ToString(),
                                fechaRequest = Convert.ToDateTime(dr["fechaRequest"]),
                                response = dr["response"].ToString(),
                                fechaResponse = Convert.ToDateTime(dr["fechaResponse"]),
                                usuario = dr["usuario"].ToString()
                            });
                        }
                        dr.Close();
                    }

                    return requests;
                }
                catch
                {
                    return requests;
                }
            }
        }

        public Requests RecuperarRequestPorID(int id)
        {
            Requests Respuesta = new Requests();
            using (SqlConnection conn = new SqlConnection(Conexion.rutaDB))
            {
                SqlCommand cmd = new SqlCommand("RecuperarRequestPorID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Respuesta.id = Convert.ToInt32(dr["Id"]);
                            Respuesta.request = dr["request"].ToString();
                            Respuesta.fechaRequest = Convert.ToDateTime(dr["fechaRequest"]);
                            Respuesta.response = dr["response"].ToString();
                            Respuesta.fechaResponse = Convert.ToDateTime(dr["fechaResponse"]);
                            Respuesta.usuario = dr["usuario"].ToString();
                        }
                        dr.Close();
                    }

                    return Respuesta;
                }
                catch
                {
                    return Respuesta;
                }
            }
        }
    }
}
