﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;

namespace GUI
{
    public partial class frmRegistroMarcas : Form
    {
        /// <summary>
        /// Atributos de la clase frmRegistroMarcas 
        /// </summary>
        AccesoDatosOracle cnx;
        public frmRegistroMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
        }
        /// <summary>
        /// Evento del botón Marcar que realiza la marca en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            int contMarcas=1;
            MarcaD oMarcaD=new MarcaD(this.cnx);
            EmpleadoD oEmpleadoD=new EmpleadoD(this.cnx);
            List<EmpleadoL> empleado = oEmpleadoD.buscarEmpleado(this.txtCodigoEmpleado.Text);
            
            if(txtCodigoEmpleado.Text!=""){

                if (empleado.Count>0)
                {
                    MarcaL oMarcaL = new MarcaL(contMarcas, txtCodigoEmpleado.Text, "Generado", oMarcaD.tipoMarca(txtCodigoEmpleado.Text), Program.oUsuarioLogueado.IdUsuario, DateTime.Now, Program.oUsuarioLogueado.IdUsuario, DateTime.Now, "Sí");
                    oMarcaD.agregarMarca2(oMarcaL);
                    txtCodigoEmpleado.Text = "";
                }
                else {
                    MessageBox.Show("El empleado no existe ó se encuentra inactivo en la empresa");
                    txtCodigoEmpleado.Text = "";
                }
            }
        }
        /// <summary>
        /// Evento de teclado que nos permite salir de la pantalla presionando la tecla Esc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmRegistroMarcas_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.btnMarcar_Click(sender, e);
            }
        }
    }
}
