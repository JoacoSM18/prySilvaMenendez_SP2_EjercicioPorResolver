namespace prySilvaMenendez_SP2_EjercicioPorResolver
{
    partial class frmCalcularPrecioBoletos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcularPrecioBoletos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.NumericUpDown();
            this.txtDistancia = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule el Precio de su Boleto";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(55, 147);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(240, 17);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Ingrese la Distancia Hasta el Destino";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(55, 252);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(260, 17);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Ingrese la Cantidad de Dias de Estancia";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(349, 249);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(55, 20);
            this.txtDias.TabIndex = 3;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(325, 144);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(438, 370);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // frmCalcularPrecioBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(591, 457);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalcularPrecioBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Precio de Boletos - Empresa \"Ferro\"";
            ((System.ComponentModel.ISupportInitialize)(this.txtDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown txtDias;
        private System.Windows.Forms.MaskedTextBox txtDistancia;
        private System.Windows.Forms.Button btnCalcular;
    }
}

