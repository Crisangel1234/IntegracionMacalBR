using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSIntegracion_Macal.BE;
using ZthFetchXml365;

namespace WSIntegracion_Macal.DA
{
  public  class ClienteDA
    {
        // Instancia de BitacoraErroesBE
        BitacoraErroresBE oBitacoraErroresBE = new BitacoraErroresBE();
        // Instancia de FuncionesDA
        FuncionesDA oFuncionesDA = new FuncionesDA();

        string Ruta = ConfigurationManager.AppSettings["PathLogServicio"].ToString();
        public DataTable ValidarRut(string Rut)

        {
           

            try
            {
                IOrganizationService servicio; // Instancia de IOrgnizationService
                servicio = ConexionCRMDA.GetConnection(); // Obtenemos la Conexión de CRM 

                //Le Entregamos el nombre de la entidad principal a buscar(Cliente, y la referencia al servicio web de CRM)


                zthFetch fetch = new zthFetch("account", ref servicio);
                fetch.AgregarCampoRetorno("account", "zth_idn", zthFetch.TipoRetorno.String);
                fetch.AgregarFiltroPlano("account",zthFetch.TipoFiltro.and, "zth_idn", zthFetch.TipoComparacionFiltro.PoseeDatos,Rut);
                fetch.AgregarCantidadRegistrosDevolver_puedesermenorque5000(1);
                DataTable  Dato = fetch.GeneraTblconFetchResult(false); // ¿Por que false?

                return Dato;

            }
            catch (Exception ex)
            {
                // Mensaje de la excepción 
                string Mensaje = "Se ha producido el siguiente error: " + ex.Message;
                // DLL guarda el mensaje de excepción en un registro
                ZthMetodosVarios.Metodos.GuardarLog(Ruta, Mensaje);
                throw ex;
            }
        }

    }
}
