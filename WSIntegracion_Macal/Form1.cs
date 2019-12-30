using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSIntegracion_Macal.BE;
using WSIntegracion_Macal.BL;

namespace WSIntegracion_Macal
{
    public partial class FormMacal : Form
    {
        #region Instancias

       // BitacoraErroresBE bitacoraErroresBE = new BitacoraErroresBE();
        ClienteBE clienteBE = new ClienteBE();
        FuncionesBL funcionesBL = new FuncionesBL();

        ClienteBL clienteBL = new ClienteBL();


        #endregion
        
       

        // Declaración de variables y desencriptación 

        string ruta = ConfigurationManager.AppSettings["PathLogServicio"];

        public FormMacal()
        {
            InitializeComponent();
        }

      
        private void Btn_Magico_Click(object sender, EventArgs e)
        {
            CreateClient();
        }

        /// <summary>
        /// Validar 
        /// </summary>
        private void CreateClient()
        {
            ZthMetodosVarios.Metodos.GuardarLog(ruta, "--- Iniciamos la creación de los clientes en CRM" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "---");
            // Guardar Registro

            try
            {
                ZthMetodosVarios.Metodos.GuardarLog(ruta, "--- Inserción de TextBox en Variables" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "---");
                // Insertamos los valores de los textbox en las variables de ClienteBE
                clienteBE.Nombre = txt_Nombre.Text;
                clienteBE.Apellido = txt_Apellido.Text;
                clienteBE.Rut = txt_Rut.Text;
                clienteBE.Direccion = txt_Direccion.Text;
                clienteBE.Celular = Convert.ToInt32(txt_Celular.Text);

                DataTable existeCliente = new DataTable();

                existeCliente = clienteBL.ValidarRut(clienteBE.Rut);

                if (existeCliente.Rows.Count > 0)
                {

                    DataRow row = existeCliente.Rows[0];

                    string GuidCliente;

                    GuidCliente = row["accountid"].ToString();

                    clienteBL.ActualizarClienteBL(GuidCliente, clienteBE);


                    ZthMetodosVarios.Metodos.GuardarLog(ruta, "Se actualizo en el CRM el Cliente con I.D.N: " + clienteBE.Rut);


          
                }
                else
                {
                    Guid ClienteGuid;
                    ClienteGuid = clienteBL.CrearCliente(clienteBE);

                    ZthMetodosVarios.Metodos.GuardarLog(ruta, "Se creo en el CRM el Cliente con I.D.N: " + clienteBE.Rut);

                }

            }
            catch (Exception ex)
            {

                string Mensaje = "Se ha producido el siguiente error: " + ex.Message;
                ZthMetodosVarios.Metodos.GuardarLog(ruta, Mensaje);
            }


        }

        private void FormMacal_Load(object sender, EventArgs e)
        {
            txt_Celular.Text = "0000000000";
        }
    }
}
