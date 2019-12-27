using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSIntegracion_Macal.BE
{
   public  class BitacoraErroresBE


    {
        #region Historia
         
        /*
           Autor: Cristopher Angulo
           Fecha Creación = 27/12/2019
           Notas: Creación Clase BitácoraErrores

        */
         #endregion

        #region Fields and Properties
        // Encapsulamiento
        // Tenemos campos y propiedades de la Clase BitacoraErroresBE
        private String _Codigo;
        public String Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }

        private String _Proceso;
        public String Proceso
        {
            get
            {
                return _Proceso;
            }
            set
            {
                _Proceso = value;
            }
        }

        private String _Error;
        public String Error
        {
            get
            {
                return _Error;
            }
            set
            {
                _Error = value;
            }
        }

        private String _Descripcion;
        public String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }

        private String _IdRegistro;
        public String IdRegistro
        {
            get
            {
                return _IdRegistro;
            }
            set
            {
                _IdRegistro = value;
            }
        }

        private String _Entidad;
        public String Entidad
        {
            get
            {
                return _Entidad;
            }
            set
            {
                _Entidad = value;
            }
        }

        private String _EstadoCarga;
        public String EstadoCarga
        {
            get
            {
                return _EstadoCarga;
            }
            set
            {
                _EstadoCarga = value;
            }
        }
        #endregion
        // Constructor que se ejecuta cuando se inicializa un objeto de esta clase

        #region Builder - CTOR

        public BitacoraErroresBE()
        {

            this.init();
        }
        #endregion


        // Inicializacion 
        #region MyRegion
        private void init()
        {

        }
        #endregion




    }
}
