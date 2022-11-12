namespace Presentacion_GUI
{
    partial class FrmPrincipal
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
            this.btnFamiliar = new System.Windows.Forms.Button();
            this.btnEmpresarial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFamiliar
            // 
            this.btnFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnFamiliar.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamiliar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnFamiliar.Location = new System.Drawing.Point(293, 127);
            this.btnFamiliar.Name = "btnFamiliar";
            this.btnFamiliar.Size = new System.Drawing.Size(220, 43);
            this.btnFamiliar.TabIndex = 0;
            this.btnFamiliar.Text = "Contactos Familiares";
            this.btnFamiliar.UseVisualStyleBackColor = false;
            this.btnFamiliar.Click += new System.EventHandler(this.btnFamiliar_Click);
            // 
            // btnEmpresarial
            // 
            this.btnEmpresarial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnEmpresarial.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresarial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnEmpresarial.Location = new System.Drawing.Point(293, 203);
            this.btnEmpresarial.Name = "btnEmpresarial";
            this.btnEmpresarial.Size = new System.Drawing.Size(220, 43);
            this.btnEmpresarial.TabIndex = 1;
            this.btnEmpresarial.Text = "Contactos Empresariales";
            this.btnEmpresarial.UseVisualStyleBackColor = false;
            this.btnEmpresarial.Click += new System.EventHandler(this.btnEmpresarial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnSalir.Font = new System.Drawing.Font("Eras Demi ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSalir.Location = new System.Drawing.Point(293, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpresarial);
            this.Controls.Add(this.btnFamiliar);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFamiliar;
        private System.Windows.Forms.Button btnEmpresarial;
        private System.Windows.Forms.Button btnSalir;
    }
}