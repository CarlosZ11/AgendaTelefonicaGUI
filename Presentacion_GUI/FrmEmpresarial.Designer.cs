namespace Presentacion_GUI
{
    partial class FrmEmpresarial
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonales = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.GrillaEmpresarial = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPersonales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpresarial)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(24, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 79);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnSalir.Location = new System.Drawing.Point(468, 33);
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
            this.btnGuardar.Location = new System.Drawing.Point(334, 33);
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
            this.btnNuevo.Location = new System.Drawing.Point(201, 33);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.Lista);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(24, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 267);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contactos Empresariales";
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 16;
            this.Lista.Location = new System.Drawing.Point(422, 62);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(279, 132);
            this.Lista.TabIndex = 21;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 22);
            this.txtTelefono.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 22);
            this.txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabGeneral.Controls.Add(this.GrillaEmpresarial);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(794, 422);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "Listado General";
            // 
            // GrillaEmpresarial
            // 
            this.GrillaEmpresarial.AllowUserToAddRows = false;
            this.GrillaEmpresarial.AllowUserToDeleteRows = false;
            this.GrillaEmpresarial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpresarial.Location = new System.Drawing.Point(25, 19);
            this.GrillaEmpresarial.Name = "GrillaEmpresarial";
            this.GrillaEmpresarial.ReadOnly = true;
            this.GrillaEmpresarial.Size = new System.Drawing.Size(739, 384);
            this.GrillaEmpresarial.TabIndex = 0;
            this.GrillaEmpresarial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpresarial_CellDoubleClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(156, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(195, 22);
            this.txtCorreo.TabIndex = 22;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(156, 169);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(195, 22);
            this.txtNit.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nit";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(156, 213);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(195, 22);
            this.txtRazonSocial.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Razon Social";
            // 
            // FrmEmpresarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEmpresarial";
            this.Text = "FrmEmpresarial";
            this.Load += new System.EventHandler(this.FrmEmpresarial_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpresarial)).EndInit();
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
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.DataGridView GrillaEmpresarial;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
    }
}