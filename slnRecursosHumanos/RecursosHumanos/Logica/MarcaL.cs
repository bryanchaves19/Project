﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MarcaL
    {
        /// <summary>
        /// Atributos de la clase MarcaL
        /// </summary>
        private int idMarca;
        private int idUnificacion;
        private string idEmpleado;
        private string estadoMarca;
        private string tipoMarca;
        private string nombreEmpleado;       
        private DateTime fechaMarca;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;
        private string activo;



        /// Metodo constructor con parámetros

        public MarcaL(int pIdMarca, int pidUnificacion, string pIdEmpleado,string pnombreEmpleado, string pEstadoMarca, string pTipoMarca, DateTime pfechaMarca, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {
            this.idMarca = pIdMarca;
            this.idUnificacion = pidUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.nombreEmpleado = pnombreEmpleado;
            this.fechaMarca = pfechaMarca;           
            this.tipoMarca = pTipoMarca;
            this.estadoMarca = pEstadoMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }
        public MarcaL(int pidMarca,int pIdUnificacion, string pIdEmpleado, string pTipoMarca, string pEstadoMarca, DateTime pfechaMarca, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {
            this.idMarca = pidMarca;
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.estadoMarca = pEstadoMarca;
            this.tipoMarca = pTipoMarca;
            this.fechaMarca = pfechaMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }
        public MarcaL( int pIdUnificacion, string pIdEmpleado, string pTipoMarca, string pEstadoMarca, DateTime pfechaMarca, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {
            
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.estadoMarca = pEstadoMarca;
            this.tipoMarca = pTipoMarca;
            this.fechaMarca = pfechaMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }

        public MarcaL()
        {

        }

        /// <summary>
        /// Properties de la clase
        /// </summary>
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public int IdUnificacion
        {
            get { return idUnificacion; }
            set { idUnificacion = value; }
        }

        public string EstadoMarca
        {
            get { return estadoMarca; }
            set { estadoMarca = value; }
        }

        public string TipoMarca
        {
            get { return tipoMarca; }
            set { tipoMarca = value; }
        }

        public DateTime FechaMarca
        {
            get { return fechaMarca; }
            set { fechaMarca = value; }
        }

        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }


        /// <summary>
        /// Metodo toString 
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return
                    "ID Marca:" + this.IdMarca + "\n" +
                    "ID Unificación:" + this.IdUnificacion + "\n" +
                    "ID Empleado:" + this.IdEmpleado + "\n" +                    
                    "Nombre Emplaedo:"+this.NombreEmpleado+"\n"+
                    "Fecha Marca:" + this.FechaMarca + "\n" +
                    "Tipo de Marca:" + this.TipoMarca + "\n" +
                    "Estado Marca:" + this.EstadoMarca + "\n" +                    
                    "Creada por:" + this.CreadoPor + "\n" +
                    "Fecha de Creación:" + this.FechaCreacion + "\n" +
                    "Modificado Por:" + this.ModificadoPor + "\n" +
                    "Fecha de Modificación:" + this.FechaModificacion + "\n" +
                    "Activo:" + this.Activo;
        }
    }
}
