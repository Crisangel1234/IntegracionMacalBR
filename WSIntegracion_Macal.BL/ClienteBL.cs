using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSIntegracion_Macal.DA;

namespace WSIntegracion_Macal.BL
{
   public  class ClienteBL
    {
        #region Variables
        private ClienteDA clienteDA = new ClienteDA();
        #endregion
        public DataTable Validaciones(string Rut)
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


    }
}
