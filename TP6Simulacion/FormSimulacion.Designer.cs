namespace TP6Simulacion
{
    partial class FormSimulacion
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
            this.numTiempoOciosoPromedio = new System.Windows.Forms.NumericUpDown();
            this.numTiempoEsperaPromedio = new System.Windows.Forms.NumericUpDown();
            this.numPorcentajeTiempoOcioso = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadProcesosTotales = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoOciosoPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoEsperaPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeTiempoOcioso)).BeginInit();
            this.SuspendLayout();
            // 
            // numTiempoOciosoPromedio
            // 
            this.numTiempoOciosoPromedio.DecimalPlaces = 2;
            this.numTiempoOciosoPromedio.Location = new System.Drawing.Point(28, 87);
            this.numTiempoOciosoPromedio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTiempoOciosoPromedio.Name = "numTiempoOciosoPromedio";
            this.numTiempoOciosoPromedio.Size = new System.Drawing.Size(120, 20);
            this.numTiempoOciosoPromedio.TabIndex = 2;
            // 
            // numTiempoEsperaPromedio
            // 
            this.numTiempoEsperaPromedio.DecimalPlaces = 2;
            this.numTiempoEsperaPromedio.Location = new System.Drawing.Point(213, 87);
            this.numTiempoEsperaPromedio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTiempoEsperaPromedio.Name = "numTiempoEsperaPromedio";
            this.numTiempoEsperaPromedio.Size = new System.Drawing.Size(120, 20);
            this.numTiempoEsperaPromedio.TabIndex = 3;
            // 
            // numPorcentajeTiempoOcioso
            // 
            this.numPorcentajeTiempoOcioso.DecimalPlaces = 2;
            this.numPorcentajeTiempoOcioso.Location = new System.Drawing.Point(28, 139);
            this.numPorcentajeTiempoOcioso.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPorcentajeTiempoOcioso.Name = "numPorcentajeTiempoOcioso";
            this.numPorcentajeTiempoOcioso.Size = new System.Drawing.Size(120, 20);
            this.numPorcentajeTiempoOcioso.TabIndex = 4;
            // 
            // txtCantidadProcesosTotales
            // 
            this.txtCantidadProcesosTotales.Location = new System.Drawing.Point(28, 36);
            this.txtCantidadProcesosTotales.Name = "txtCantidadProcesosTotales";
            this.txtCantidadProcesosTotales.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProcesosTotales.TabIndex = 5;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(226, 36);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 6;
            // 
            // FormSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtCantidadProcesosTotales);
            this.Controls.Add(this.numPorcentajeTiempoOcioso);
            this.Controls.Add(this.numTiempoEsperaPromedio);
            this.Controls.Add(this.numTiempoOciosoPromedio);
            this.Name = "FormSimulacion";
            this.Text = "FormSimulacion";
            this.Load += new System.EventHandler(this.FormSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoOciosoPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoEsperaPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentajeTiempoOcioso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTiempoOciosoPromedio;
        private System.Windows.Forms.NumericUpDown numTiempoEsperaPromedio;
        private System.Windows.Forms.NumericUpDown numPorcentajeTiempoOcioso;
        private System.Windows.Forms.TextBox txtCantidadProcesosTotales;
        private System.Windows.Forms.TextBox txtTiempo;
    }
}