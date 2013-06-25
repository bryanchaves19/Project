﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioL
    {
        private String idUsuario;        
        private string tipoUsuario;        
        private string password;        
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;

        public UsuarioL(string pIdUsuario, string pTipoUsuario, string pPassword, DateTime pfechaModificacion, DateTime pfechaCreacion, string pcreadoPor, string pmodificadoPor, string pactivo)
        {
            this.idUsuario = pIdUsuario;
            this.tipoUsuario = pTipoUsuario;
            this.password = pPassword;
            this.fechaModificacion = pfechaModificacion;
            this.fechaCreacion = pfechaCreacion;            
            this.creadoPor = pcreadoPor;
            this.modificadoPor = pmodificadoPor;            
            this.activo = pactivo;
        }
        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }
        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }
        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }
        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public override string ToString()
        {
            return "ID Usuario: " + this.idUsuario +
                   "Tipo Usuario: " + this.tipoUsuario +
                   "Password" + this.password +
                   "Fecha de Modificación: " + this.fechaModificacion +
                   "Fecha de Creación: " + this.fechaCreacion +                   
                   "Creado por: " + this.creadoPor +
                   "Modificado por: " + this.modificadoPor +                   
                   "Activo: " + this.activo;
        }
    }
}