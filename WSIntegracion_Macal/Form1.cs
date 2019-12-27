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

        BitacoraErroresBE bitacoraErroresBE = new BitacoraErroresBE();
        ClienteBE clienteBE = new ClienteBE();
        FuncionesBL funcionesBL = new FuncionesBL();

        ClienteBL ClienteBL = new ClienteBL();

        #endregion
        
       

        // Declaración de variables y desencriptación 

        string ruta = ConfigurationManager.AppSettings["PathLogServicio"];

        public FormMacal()
        {
            InitializeComponent();
        }

      
        private void Btn_Magico_Click(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void Validaciones()
        {
            ZthMetodosVarios.Metodos.GuardarLog(ruta, "--- Iniciamos el proceso de Carga Masiva de los Contactos " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "---");
            // Guardar Registro

            try
            {


                // Insertamos los valores de los textbox en las variables de ClienteBE
                clienteBE.Nombre = txt_Nombre.Text;
                clienteBE.Apellido = txt_Apellido.Text;
                clienteBE.Rut = txt_Rut.Text;
                clienteBE.Direccion = txt_Direccion.Text;
                clienteBE.Celular = Convert.ToInt32(txt_Celular.Text);

                DataTable existeCliente = new DataTable();
               

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void FormMacal_Load(object sender, EventArgs e)
        {
            txt_Celular.Text = "0000000000";
        }
    }
}
