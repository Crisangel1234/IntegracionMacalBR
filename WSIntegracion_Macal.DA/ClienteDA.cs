using MediaFoundation.OPM;
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
    public class ClienteDA
    {
        // Instancia de BitacoraErroesBE
        // BitacoraErroresBE oBitacoraErroresBE = new BitacoraErroresBE();
        // Instancia de FuncionesDA
        FuncionesDA oFuncionesDA = new FuncionesDA();

        ClienteBE clienteBE = new ClienteBE();


        string Ruta = ConfigurationManager.AppSettings["PathLogServicio"].ToString();
        public DataTable ValidarRut(string Rut)

        {
            DataTable Dato = null;

            try
            {
                // Instancia de IOrgnizationService
                IOrganizationService servicio;

                // Obtenemos la Conexión de CRM 
                servicio = ConexionCRMDA.GetConnection();


                //Le Entregamos el nombre de la entidad principal a buscar(Cliente, y la referencia al servicio web de CRM)
                zthFetch fetch = new zthFetch("account", ref servicio);

                //fetch.AgregarCampoRetorno("account", "zth_idn", zthFetch.TipoRetorno.String);
                fetch.AgregarCampoRetorno("account", "accountid", zthFetch.TipoRetorno.Key);
                fetch.AgregarFiltroPlano("account", ZthFetchXml365.zthFetch.TipoFiltro.and, "zth_idn", ZthFetchXml365.zthFetch.TipoComparacionFiltro.Igual, Rut);
                fetch.AgregarCantidadRegistrosDevolver_puedesermenorque5000(1);
                // pedimos un registro por ende devuelve un rut

                
                Dato =  fetch.GeneraTblconFetchResult(false);

                /*if (Dato.Rows.Count > 0)
                {
                    return Dato;
                }
                else
                {
                    return null;
                }*/


                

            }

            catch (Exception ex)
            {
                
                // Mensaje de la excepción 
                string Mensaje = "Se ha producido el siguiente error: " + ex.Message;
                // DLL guarda el mensaje de excepción en un registro
                ZthMetodosVarios.Metodos.GuardarLog(Ruta, Mensaje);
                
                

            }
            return Dato;
            
        }
        public DataTable ReturnSomething()
        {
            DataTable dt = new DataTable();

            // logic here
            return dt;
        }

        public Guid CrearCliente(ClienteBE clienteBE)
        {
            // Instancia de IOrgnizationService
            IOrganizationService servicio;

            // Obtenemos la Conexión de CRM 
            servicio = ConexionCRMDA.GetConnection();
            EntidadesCRM.Account account = new EntidadesCRM.Account();
            Guid RutCliente = new Guid(); ;

            try
            {
                account.zth_idn = clienteBE.Rut;
                account.zth_nombre = clienteBE.Nombre;
                account.zth_apellidomaterno = clienteBE.Apellido;
                account.Address1_Line1 = clienteBE.Direccion; // Agregue Set 
                account.Address1_Telephone1 = clienteBE.Celular.ToString();
                RutCliente = servicio.Create(account);
                return RutCliente;
                
            }
            catch (Exception ex)
            {
                string Mensaje = "Error al Crear el Cliente. Se ha producido el siguiente error: " + ex.Message;
                ZthMetodosVarios.Metodos.GuardarLog(Ruta, Mensaje);
                throw ex;
            }

        }

        public Boolean ActualizarClienteDA(string GuidCliente, ClienteBE clienteBE)
        {

            IOrganizationService servicio;
            servicio = ConexionCRMDA.GetConnection();

            EntidadesCRM.Account account = new EntidadesCRM.Account();

            try

            {
                account.AccountId = Guid.Parse(GuidCliente);
                // Identficador unico universal
                account.zth_idn = clienteBE.Rut;
                account.zth_nombre = clienteBE.Nombre;
                account.zth_apellidomaterno = clienteBE.Apellido;
                account.Address1_Line1 = clienteBE.Direccion; // Agregue Set 
                account.Address1_Telephone1 = clienteBE.Celular.ToString();

                // Identificador unico del ID
                // account.AccountId 
                //servicio.Update(account);

                servicio.Update(account);
                return true;

            }
            catch (Exception ex )
            { 
                string Mensaje = "Error al Actualizar el Cliente. Se ha producido el siguiente error: " + ex.Message;
                ZthMetodosVarios.Metodos.GuardarLog(Ruta, Mensaje);
                throw ex;
            }
        }
    }
}
