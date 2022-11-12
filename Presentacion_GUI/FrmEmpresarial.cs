using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;
using System.Diagnostics.Contracts;

namespace Presentacion_GUI
{
    public partial class FrmEmpresarial : Form
    {
        ServicioContactosEmpresariales ServicioCE = new ServicioContactosEmpresariales();
        int IdAux = 1;
        public FrmEmpresarial()
        {
            InitializeComponent();
        }

        void Autoincrementar()
        {
            IdAux += 1;
        }

        void Guardar()
        {
            Empresarial empresariales = new Empresarial();
            Autoincrementar();
            empresariales.Id = IdAux;
            empresariales.Nombre = txtNombre.Text;
            empresariales.Telefono = txtTelefono.Text;
            empresariales.Correo = txtCorreo.Text;
            empresariales.Nit = txtNit.Text;
            empresariales.RazonSocial = txtRazonSocial.Text;
            var mensaje = ServicioCE.Guardar(empresariales);
            MessageBox.Show(mensaje);
        }

        void CargarLista()
        {
            Lista.DataSource = ServicioCE.ObtenerTodo();
            Lista.DisplayMember = "Nombre";
        }

        void CargarGrilla()
        {
            GrillaEmpresarial.DataSource = ServicioCE.ObtenerTodo();
        }

        void ver(Empresarial contacto)
        {
            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            txtCorreo.Text = contacto.Correo;
            txtNit.Text = contacto.Nit;
            txtRazonSocial.Text = contacto.RazonSocial;
        }

        void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtNit.Text = "";
            txtRazonSocial.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarLista();
            CargarGrilla();
            LimpiarCampos();
        }

        private void FrmEmpresarial_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
            LimpiarCampos();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = Lista.SelectedIndex.ToString();
            ver(ServicioCE.ObtenerTodo()[Lista.SelectedIndex]);
        }

        private void GrillaEmpresarial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ver(ServicioCE.ObtenerTodo()[e.RowIndex]);
            tabPersonales.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
