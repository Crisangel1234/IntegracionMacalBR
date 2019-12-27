using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSIntegracion_Macal.BE
{
   public  class ClienteBE


    {
        #region Historia

        /*
           Autor: Cristopher Angulo
           Fecha Creación = 27/12/2019
           Notas: Creación Clase Cliente BE

        */
        #endregion


        #region Fields and Properties

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _rut;

        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _celular;

        public int Celular

        {
            get { return _celular; }
            set { _celular = value; }
        }
        #endregion

        #region Builder - CTOR
        public ClienteBE()
        {
            this.init();
        }
        #endregion

        #region Init
        private void init()
        {
            // agregar parametros
        }
        #endregion


    }
}
