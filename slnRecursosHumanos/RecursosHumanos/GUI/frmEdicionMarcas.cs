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
using Datos;

namespace GUI
{
    public partial class frmEdicionMarcas : Form
    {
        /// <summary>
        ///  Atributos de la clase el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private AccesoDatosOracle cnx;
        private Boolean aceptar;
        public MarcaL MarcaL;
        

        public MarcaL MarcaL1
        {
            get { return MarcaL; }
            set { MarcaL = value; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        public frmEdicionMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            rdoEntrada.Checked = true;
            this.cargarComboCodigoEmpleado(pcnx);
            this.txtEstado.Text = "Generada";
            this.txtEstado.ReadOnly = true;
            
        }

        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbCodigo.DisplayMember = "idEmpleado";
            cmbCodigo.ValueMember = "idEmpleado";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigo = cmbCodigo.SelectedItem.ToString();

            
            if(rdoSalida.Checked==true){               
                
                MarcaL = new MarcaL(codigo,txtEstado.Text,"Salida","Proyecto",dtpFecha.Value.Date,"Proyecto",dtpFecha.Value.Date,"Sí");

            
            }else{
                MarcaL = new MarcaL(codigo, txtEstado.Text, "Entrada", "Proyecto", dtpFecha.Value.Date, "Proyecto", dtpFecha.Value.Date, "Sí");
            
            }
            this.Aceptar = true;
            this.Close();
        }
    }
}
