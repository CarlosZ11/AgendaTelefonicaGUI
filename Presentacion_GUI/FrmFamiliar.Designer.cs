namespace Presentacion_GUI
{
    partial class FrmFamiliar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonales = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.GrillaFamiliar = new System.Windows.Forms.DataGridView();
            this.MenuEliminar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPersonales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFamiliar)).BeginInit();
            this.MenuEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonales);
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPersonales
            // 
            this.tabPersonales.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabPersonales.Controls.Add(this.groupBox2);
            this.tabPersonales.Controls.Add(this.groupBox1);
            this.tabPersonales.Location = new System.Drawing.Point(4, 22);
            this.tabPersonales.Name = "tabPersonales";
            this.tabPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonales.Size = new System.Drawing.Size(794, 422);
            this.tabPersonales.TabIndex = 0;
            this.tabPersonales.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(24, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 118);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnEliminar.Location = new System.Drawing.Point(200, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnSalir.Location = new System.Drawing.Point(601, 51);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnGuardar.Location = new System.Drawing.Point(467, 51);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnNuevo.Location = new System.Drawing.Point(334, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lista);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 205);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contactos Familiares";
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 16;
            this.Lista.Location = new System.Drawing.Point(429, 31);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(279, 132);
            this.Lista.TabIndex = 21;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(155, 143);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(195, 22);
            this.dtFecha.TabIndex = 20;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 97);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 22);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabGeneral.Controls.Add(this.GrillaFamiliar);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(794, 422);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "Listado General";
            // 
            // GrillaFamiliar
            // 
            this.GrillaFamiliar.AllowUserToAddRows = false;
            this.GrillaFamiliar.AllowUserToDeleteRows = false;
            this.GrillaFamiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaFamiliar.ContextMenuStrip = this.MenuEliminar;
            this.GrillaFamiliar.Location = new System.Drawing.Point(25, 19);
            this.GrillaFamiliar.Name = "GrillaFamiliar";
            this.GrillaFamiliar.ReadOnly = true;
            this.GrillaFamiliar.Size = new System.Drawing.Size(739, 384);
            this.GrillaFamiliar.TabIndex = 0;
            this.GrillaFamiliar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFamiliar_CellContentClick);
            this.GrillaFamiliar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFamiliar_CellDoubleClick);
            // 
            // MenuEliminar
            // 
            this.MenuEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.MenuEliminar.Name = "MenuEliminar";
            this.MenuEliminar.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnActualizar.Location = new System.Drawing.Point(75, 51);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFamiliar";
            this.Text = "FrmFamiliar";
            this.Load += new System.EventHandler(this.FrmFamiliar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFamiliar)).EndInit();
            this.MenuEliminar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.DataGridView GrillaFamiliar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ContextMenuStrip MenuEliminar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
    }
}