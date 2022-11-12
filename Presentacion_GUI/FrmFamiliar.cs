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
    public partial class FrmFamiliar : Form
    {
        ServicioContactosFamiliares ServicioCF = new ServicioContactosFamiliares();
        int IdAux = 2;
        int fila;

        public FrmFamiliar()
        {
            InitializeComponent();
        }

        //void Autoincrementar()
        //{
        //    for (int i = 0; i < ServicioCF.ObtenerTodo().Count; i++)
        //    {
        //        IdAux = i + 1;
        //    }
        //}

        void Guardar()
        {
            Familiar familiares = new Familiar();
            //Autoincrementar();
            //familiares.Id = new Random().Next(999999, 10000000);

            for (int i = 0; i < ServicioCF.ObtenerTodo().Count; i++)
            {
                familiares.Id = i + 2;
            }

            familiares.Nombre = txtNombre.Text;
            familiares.Telefono = txtTelefono.Text;
            familiares.FechaNacimiento = dtFecha.Value;
            var mensaje = ServicioCF.Guardar(familiares);
            MessageBox.Show(mensaje);
        }

        void Eliminar(Familiar contacto)
        {
            var mensaje = ServicioCF.Borrar(contacto);
            MessageBox.Show(mensaje);
        }

        void Actualizar(Familiar Oldcontacto,Familiar UpdateContacto)
        {
            Oldcontacto.Nombre = txtNombre.Text;
            Oldcontacto.Telefono = txtTelefono.Text;
            Oldcontacto.FechaNacimiento = dtFecha.Value;
            //UpdateContacto = Oldcontacto;
            var mensaje = ServicioCF.Editar(Oldcontacto,UpdateContacto);
            MessageBox.Show(mensaje);
        }

        void CargarLista()
        {
            // Lista.Items.Clear();
            //foreach (var item in ServicioCF.GetAll())
            //   {
            //       Lista.Items.Add(item.Nombre);
            //   }
            Lista.DataSource = ServicioCF.ObtenerTodo();
            Lista.DisplayMember = "Nombre";
        }
        void CargarGrilla()
        {
            //GrillaFamiliar.Rows.Clear();
            //foreach (var item in ServicioCF.GetAll())
            //{
            //    GrillaFamiliar.Rows.Add(item.Id, item.Nombre, item.Telefono, item.FechaNacimiento);
            //}

            GrillaFamiliar.DataSource = ServicioCF.ObtenerTodo();
        }

        void ver(Familiar contacto)
        {
            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            dtFecha.Value = contacto.FechaNacimiento;

        }

        void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            //dtFecha.Value = null;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarGrilla();
            CargarLista();
            LimpiarCampos();
        }

        private void FrmFamiliar_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
            LimpiarCampos();
            //this.Text = Lista.SelectedIndex.ToString();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = Lista.SelectedIndex.ToString();
            ver(ServicioCF.ObtenerTodo()[Lista.SelectedIndex]);
        }

        private void GrillaFamiliar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ver(ServicioCF.ObtenerTodo()[e.RowIndex]);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(ServicioCF.ObtenerTodo()[Lista.SelectedIndex]);
            CargarGrilla();
            CargarLista();
            LimpiarCampos();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar(ServicioCF.ObtenerPorTelefono(GrillaFamiliar.Rows[fila].Cells[3].Value.ToString()));
            CargarGrilla();
        }

        private void GrillaFamiliar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Familiar oldContacto = new Familiar();
            Familiar UpdateContacto = new Familiar();
            UpdateContacto.Nombre = txtNombre.Text;
            UpdateContacto.Telefono = txtTelefono.Text;
            UpdateContacto.FechaNacimiento = dtFecha.Value;
            var mensaje = ServicioCF.Editar(oldContacto, UpdateContacto);
            MessageBox.Show(mensaje);
            CargarGrilla();
            CargarLista();
            LimpiarCampos();
        }
    }
}
