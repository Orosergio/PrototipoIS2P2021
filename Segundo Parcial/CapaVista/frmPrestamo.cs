using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmPrestamo : Form
    {
        clsControlador cn = new clsControlador();
        string UsuarioAplicacion; //usuario heredado
        static Form FormularioPadre;
        public frmPrestamo(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            
            FormularioPadre = formularioPadre;
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            procLlenarCmb("tarjetaidentidad", "idTarjeta", cmbIdTarjeta);
            procLlenarCmb("tarjetaidentidad", "nombres", cmbTarjeta);
            procLlenarCmb("registrovideo", "idRegistro", cmbIdPelicula);
            procLlenarCmb("registrovideo", "nombrePelicula", cmbPelicula);
            procLlenarCmb("encabezadoprestamo", "idEncabezadoPrestamo", cmbIdPrestamo);
            procLlenarCmb("encabezadoprestamo", "nombrePrestamo", cmbNombrePrestamo);
        }

        public void procLlenarCmb(string Tabla, string Campo, ComboBox CmbAgregar)
        {
            string[] Items = cn.funcItems(Tabla, Campo);
            for (int I = 0; I < Items.Length; I++)
            {
                if (Items[I] != null)
                {
                    if (Items[I] != "")
                    {
                        CmbAgregar.Items.Add(Items[I]);
                    }
                }
            }
        }

        private void cmbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdTarjeta.SelectedIndex = cmbTarjeta.SelectedIndex;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarEncabezado_Click(object sender, EventArgs e)
        {
           cn.translado(txtName.Text.ToString(), dtpInicio.Text.ToString() , dtpDevolucion.Text.ToString(), int.Parse(cmbIdTarjeta.Text.ToString()));

            groupBox1.Visible = true;
          

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEncaPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdPelicula.SelectedIndex = cmbPelicula.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void btnInsertarDetalle_Click(object sender, EventArgs e)
        {
            cn.translado2(int.Parse(cmbIdPrestamo.Text.ToString()), int.Parse(cmbIdPelicula.Text.ToString()), int.Parse(txtCantidad.Text.ToString()));
        }
    }
}
