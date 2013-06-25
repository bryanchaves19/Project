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
    public partial class frmEdicionCatalogoFechas : Form
    {
        private Boolean aceptar;
        private CatalogoFechasL oCatalogoFechasL;
        
        public frmEdicionCatalogoFechas()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        public frmEdicionCatalogoFechas(CatalogoFechasL pCatalogoFechasL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtCatalogoFechas.Text = Convert.ToString(pCatalogoFechasL.IdCatalogoFechas);
            this.txtDescripcion.Text = pCatalogoFechasL.Descripcion;
            this.txtFechaModificacion.Text = string.Format("{0:d}", pCatalogoFechasL.FechaModificacion);
            this.txtFechaCreacion.Text = string.Format("{0:d}", pCatalogoFechasL.FechaCreacion);
            this.txtCreadopor.Text = pCatalogoFechasL.CreadoPor;
            this.txtModificadopor.Text = pCatalogoFechasL.ModificadoPor;
            this.txtActivo.Text = pCatalogoFechasL.Activo;
            this.oCatalogoFechasL = pCatalogoFechasL;
        }
           public CatalogoFechasL OCatalogoFechasL
           {
               get { return oCatalogoFechasL; }
           }

           public Boolean Aceptar
           {
               get { return aceptar; }
           }
           private void btnCancelar_Click(object sender, EventArgs e)
           {
               this.Close();
           }

           private void btnAceptar_Click(object sender, EventArgs e)
           {
               bool estadoFecha = false;
               String activo = "No";

               if (this.chkActivo.Checked)
               {
                   activo = "Sí";
               }

               try
               {
                   if (!this.cmbMes.SelectedItem.Equals("") && (!this.cmbDia.SelectedItem.Equals("")))
                   {
                       estadoFecha = true;
                   }
                   else
                   {
                       estadoFecha = true;
                   }

                   if ((this.txtCatalogoFechas.Text == "") || (estadoFecha == false) ||
                       (this.txtDescripcion.Text == ""))
                   {
                       MessageBox.Show("Faltan datos requeridos!!!");
                       return;
                   }
               }
               catch(Exception E) 
               {
                   MessageBox.Show("Faltan datos requeridos!!!");
                   return;
               }

               this.oCatalogoFechasL = new CatalogoFechasL(this.txtCatalogoFechas.Text,
                                        int.Parse(this.cmbDia.SelectedItem.ToString()), this.cmbMes.SelectedItem.ToString(), this.txtDescripcion.Text, DateTime.Now,
                                         DateTime.Now, this.txtCreadopor.Text, this.txtModificadopor.Text, activo);
               this.aceptar = true;
               this.Close();
           }

           private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
           {

               switch (this.cmbMes.SelectedIndex)
               {

                   case 0:
                   case 2:
                   case 4:
                   case 6:
                   case 7:
                   case 9:
                   case 11:
                       cmbDia.Items.Clear();
                       for (int cont = 1; cont < 32; cont++)
                       {
                           cmbDia.Items.Add(cont);
                       }
                       break;
                   case 3:
                   case 5:
                   case 8:
                   case 10:
                       cmbDia.Items.Clear();
                       for (int cont = 1; cont < 31; cont++)
                       {
                           cmbDia.Items.Add(cont);
                       }
                       break;
                   case 1:
                           cmbDia.Items.Clear();
                           for (int cont = 1; cont < 29; cont++)
                           {
                               cmbDia.Items.Add(cont);
                           }
                       break;
            }
        }
    }
}