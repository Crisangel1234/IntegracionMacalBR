using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSIntegracion_Macal.BE;
using WSIntegracion_Macal.DA;

namespace WSIntegracion_Macal.BL
{
   public  class ClienteBL
    {
        #region Variables
        private ClienteDA clienteDA = new ClienteDA();
        #endregion
        public DataTable ValidarRut(string Rut)
        {

            try
            {

                return clienteDA.ValidarRut(Rut);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Boolean ActualizarClienteBL( string GuidCliente, ClienteBE clienteBE)
        {


            try
            {
                return clienteDA.ActualizarClienteDA(GuidCliente, clienteBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Guid CrearCliente(ClienteBE clienteBE)
        {
            try
            {
                return clienteDA.CrearCliente(clienteBE);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
