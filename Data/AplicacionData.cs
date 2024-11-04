using Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace Dal
{
	public class AplicacionData
	{
		public void GuardarAplicaciones(Aplicacion aplicacion)
		{
			try
			{
				SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UAIStoreDB"].ConnectionString);
				using (conn)
				{
					conn.Open();
					string query = @"INSERT INTO Aplicacion (TITULO, DESCRIPCION, DESARROLLADORA, PRECIO, ID_CATEGORIA) 
									VALUES (@titulo, @descripcion, @desarrolladora, @precio, @idCategoria)";
					SqlCommand cmd = new SqlCommand(query, conn);
					using (cmd)
					{

					}
					
				}
			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
