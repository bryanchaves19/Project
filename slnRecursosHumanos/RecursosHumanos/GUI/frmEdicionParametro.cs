﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace GUI
{
    public partial class frmEdicionParametro : Form
    {
        private Boolean aceptar;
        private ParametroL oParametroL;
        
        public frmEdicionParametro()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        public frmEdicionParametro(ParametroL pParametroL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdParametro.Text = Convert.ToString(pParametroL.IdParametro);
            this.txtHoraEntrada.Text = Convert.ToString(pParametroL.HoraEntrada);
            this.txtHoraSalida.Text = Convert.ToString( pParametroL.HoraSalida);            
            this.oParametroL = pParametroL;
        }
        public ParametroL OParametroL
        {
            get { return oParametroL; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarSeleccionDias() {
            bool respuesta = false;
            if ((ckdLunes.Checked == true) || (ckdMartes.Checked == true) || (ckdMiercoles.Checked == true) || (ckdJueves.Checked == true)
                || (ckdViernes.Checked == true) || (ckdSabado.Checked == true) || (ckdDomingo.Checked == true))
            {
                respuesta = true;
            }
            return respuesta;       
        }
        private bool validarSeleccionActivo() {
            bool respuesta = false;
            if(ckdActivo.Checked){
                respuesta = true;
            }
            return respuesta;        
        }
        private string validarActivo()
        {
            string respuesta = "No";
            if (ckdActivo.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarLunes() {
            string respuesta ="No";
            if(ckdLunes.Checked){
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarMartes()
        {
            string respuesta = "No";
            if (ckdMartes.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarMiercoles()
        {
            string respuesta = "No";
            if (ckdMiercoles.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarJueves()
        {
            string respuesta = "No";
            if (ckdJueves.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarViernes()
        {
            string respuesta = "No";
            if (ckdViernes.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarSabado()
        {
            string respuesta = "No";
            if (ckdSabado.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        private string validarDomingo()
        {
            string respuesta = "No";
            if (ckdDomingo.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtIdParametro.Text == "") ||
               (this.txtHoraEntrada.Text == "") || (this.txtHoraSalida.Text == "") || (this.ValidarSeleccionDias() == false))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oParametroL = new ParametroL(this.txtIdParametro.Text,
                                        Convert.ToDateTime(this.txtHoraEntrada.Text),
                                        Convert.ToDateTime(this.txtHoraSalida.Text),
                                        this.validarLunes(),
                                        this.validarMartes(),
                                        this.validarMiercoles(),
                                        this.validarJueves(),
                                        this.validarViernes(),
                                        this.validarSabado(),
                                        this.validarDomingo(),
                                        DateTime.Now,
                                        DateTime.Now, Program.usuario, Program.usuario,
                                        this.validarActivo());
            this.aceptar = true;
            this.Close();
        }

    }
}
