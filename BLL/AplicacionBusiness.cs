using Dal;
using Entity;
using System.Transactions;

namespace BLL
{
    public class AplicacionBusiness
    {
        private AplicacionData aplicacionData = new AplicacionData();

        public void GuardarAplicaciones(Aplicacion aplicaciones)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if(aplicaciones.Precio1 < 0)
                    {
                        throw new Exception("El precio debe ser mayor a cero");
                    }
                    if(aplicaciones.Titulo1.Length < 5)
                    {
                        throw new Exception("El titulo debe tener mas de 5 letras");
                    }
                    if(aplicaciones.Descripcion1.Length < 15)
                    {
                        throw new Exception("La descripcion debe tener mas de 15 letras");
                    }
                    if(aplicaciones.Categoria == null)
                    {
                        throw new Exception("Selecciones una categoria");
                    }
                    aplicacionData.GuardarAplicaciones(aplicaciones);
                    trx.Complete();
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void GuardarAplicacion(List<Aplicacion> aplicacion)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach(Aplicacion aplicaciones in aplicacion)
                    {
                        GuardarAplicaciones(aplicaciones);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
