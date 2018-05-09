namespace TP6Simulacion
{
    partial class FormPrincipal
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.numNucleos = new System.Windows.Forms.NumericUpDown();
            this.numProcesos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTiempoOciosoPromedio = new System.Windows.Forms.Label();
            this.lblTiempoOciosoPorcentaje = new System.Windows.Forms.Label();
            this.lblTiempoEsperaPromedio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNucleos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcesos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(569, 22);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(119, 42);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // numNucleos
            // 
            this.numNucleos.Location = new System.Drawing.Point(394, 70);
            this.numNucleos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNucleos.Name = "numNucleos";
            this.numNucleos.Size = new System.Drawing.Size(140, 23);
            this.numNucleos.TabIndex = 1;
            this.numNucleos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numProcesos
            // 
            this.numProcesos.Location = new System.Drawing.Point(111, 70);
            this.numProcesos.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numProcesos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProcesos.Name = "numProcesos";
            this.numProcesos.Size = new System.Drawing.Size(140, 23);
            this.numProcesos.TabIndex = 2;
            this.numProcesos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de núcleos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de procesos a finalizar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numProcesos);
            this.groupBox1.Controls.Add(this.numNucleos);
            this.groupBox1.Location = new System.Drawing.Point(14, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unidades de tiempo de finalización";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(26, 69);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(31, 15);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "0 Ns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiempo ocioso promedio de los núcleos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Porcentaje de tiempo ocioso de los núcleos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiempo de espera promedio de los procesos";
            // 
            // lblTiempoOciosoPromedio
            // 
            this.lblTiempoOciosoPromedio.AutoSize = true;
            this.lblTiempoOciosoPromedio.Location = new System.Drawing.Point(381, 69);
            this.lblTiempoOciosoPromedio.Name = "lblTiempoOciosoPromedio";
            this.lblTiempoOciosoPromedio.Size = new System.Drawing.Size(31, 15);
            this.lblTiempoOciosoPromedio.TabIndex = 13;
            this.lblTiempoOciosoPromedio.Text = "0 Ns";
            // 
            // lblTiempoOciosoPorcentaje
            // 
            this.lblTiempoOciosoPorcentaje.AutoSize = true;
            this.lblTiempoOciosoPorcentaje.Location = new System.Drawing.Point(381, 148);
            this.lblTiempoOciosoPorcentaje.Name = "lblTiempoOciosoPorcentaje";
            this.lblTiempoOciosoPorcentaje.Size = new System.Drawing.Size(26, 15);
            this.lblTiempoOciosoPorcentaje.TabIndex = 14;
            this.lblTiempoOciosoPorcentaje.Text = "0 %";
            // 
            // lblTiempoEsperaPromedio
            // 
            this.lblTiempoEsperaPromedio.AutoSize = true;
            this.lblTiempoEsperaPromedio.Location = new System.Drawing.Point(26, 148);
            this.lblTiempoEsperaPromedio.Name = "lblTiempoEsperaPromedio";
            this.lblTiempoEsperaPromedio.Size = new System.Drawing.Size(31, 15);
            this.lblTiempoEsperaPromedio.TabIndex = 15;
            this.lblTiempoEsperaPromedio.Text = "0 Ns";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTiempoOciosoPorcentaje);
            this.groupBox2.Controls.Add(this.lblTiempoEsperaPromedio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTiempoOciosoPromedio);
            this.groupBox2.Controls.Add(this.lblTiempo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(14, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 205);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNucleos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcesos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown numNucleos;
        private System.Windows.Forms.NumericUpDown numProcesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTiempoOciosoPromedio;
        private System.Windows.Forms.Label lblTiempoOciosoPorcentaje;
        private System.Windows.Forms.Label lblTiempoEsperaPromedio;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}