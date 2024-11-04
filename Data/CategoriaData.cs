using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoriaData
    {
        public List<Categoria> ObtenerCategoria()
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UAIStoreDB"].ConnectionString);
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT * FROM Categoria";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                listaCategoria.Add(CategoriaMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaCategoria;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
