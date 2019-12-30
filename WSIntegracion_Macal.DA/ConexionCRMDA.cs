using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZthSeguridad;

namespace WSIntegracion_Macal.DA
{

    /*
     * 
     *  Creamos la clase de la conexión al CRM MACAL QA con el Nombre ConexiónCRMDA  
     * 
     */
    public class ConexionCRMDA
    {

        // Interface Proveniente del DLL Microsoft.Xrm.Sdk        
        static IOrganizationService _orgService;

        static public string connection = ""; // Declara variable vacía de una conexión
        static public string usuarioCRM = Metodos.Desencriptar(ConfigurationManager.AppSettings["Usuario_CRM"]);
        // accede al dato duro o key para poder desencriptar el Usuario CRM ( Halladas en App.config) y lo asigna a la variable
        static public string claveCRM = Metodos.Desencriptar(ConfigurationManager.AppSettings["Clave_CRM"]);
        // accede al dato duro o key de claveCRM para poder desencriptar la Clave CRM y lo asigna a la variable
        static public string deviceId = ""; // ??
        static public string deviceClave = ""; //??
        static public string urlCRM = Metodos.Desencriptar(ConfigurationManager.AppSettings["URL_CRM"]);

        // Namespace Tooling Connector, invocamos la conexión y creamos el campo conn
        static CrmServiceClient conn = null;

        public static IOrganizationService GetConnection()
        {

            try
            {
                // Utilizamos el metodo string.format() , convierte los calores en el objeto deseado

                connection = string.Format(ConfigurationManager.AppSettings["Connection_CRM"], urlCRM, usuarioCRM, claveCRM);

                // Definicion del protocolo de seguridad de la capa de transporte
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Credenciales para conectarse a la instancia especifica de CRM online 
                // con connection entregamos los parametros de conexión formateadas anteriormente
                conn = new CrmServiceClient(connection);

                //Validamos si se pudo realizar la Conexión
                if (conn.IsReady)
                {
                    _orgService = (IOrganizationService)conn.OrganizationWebProxyClient != null ? (IOrganizationService) // respondio datos o fue null
                     conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy; // set up de la variable
                    conn.Dispose(); // Definida en la Interface Disposable ( desechar), su funcion es Liberar Recursos 
                    conn = null; // reasignamos la variable a null
                    return _orgService; // retornamos la conexión 
                }
                else
                {
                    conn.Dispose();
                    conn = null;
                    return _orgService;
                }

            }
            catch (Exception ex)
            {

                string ruta = ConfigurationManager.AppSettings["PathLogServicio"];
                ZthMetodosVarios.Metodos.GuardarLog(ruta, "Se ha producido el siguiente error: " + ex.Message.ToString());
                throw new Exception(ex.Message.ToString());
            }


        }

    }
}
