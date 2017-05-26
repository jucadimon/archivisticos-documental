namespace PrestacionServicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreHoja = new System.Windows.Forms.TextBox();
            this.lblNombreArchivo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreContratista = new System.Windows.Forms.TextBox();
            this.txtCCcontratista = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLugarContratista = new System.Windows.Forms.TextBox();
            this.txtCargoContratista = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtRepresentanteLegal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA DE PAGOS. LISTA DE TRABAJADORES";
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Location = new System.Drawing.Point(33, 81);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(65, 23);
            this.btnCargarLista.TabIndex = 1;
            this.btnCargarLista.Text = "CARGAR";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo de produccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hoja a leer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seleccione el nombre del archivo e ingrese el nombre de la hoja donde se encuentr" +
    "a la base de datos.";
            // 
            // txtNombreHoja
            // 
            this.txtNombreHoja.Location = new System.Drawing.Point(88, 55);
            this.txtNombreHoja.Name = "txtNombreHoja";
            this.txtNombreHoja.Size = new System.Drawing.Size(161, 20);
            this.txtNombreHoja.TabIndex = 5;
            // 
            // lblNombreArchivo
            // 
            this.lblNombreArchivo.AutoSize = true;
            this.lblNombreArchivo.Location = new System.Drawing.Point(357, 58);
            this.lblNombreArchivo.Name = "lblNombreArchivo";
            this.lblNombreArchivo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreArchivo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 202);
            this.dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Verificar la lista sea la correcta y proceder a imprimir los comprobantes de cada" +
    "  empleado.";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(490, 349);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(109, 23);
            this.btnGenerarReporte.TabIndex = 9;
            this.btnGenerarReporte.Text = "GENERAR LISTA";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(553, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Para generar los reportes, es necesario indicar las fechas respectivas del period" +
    "o de produccion y la fecha de pago.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Del:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Al:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Base de datos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha de pago:";
            // 
            // dtFechaInicial
            // 
            this.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicial.Location = new System.Drawing.Point(59, 508);
            this.dtFechaInicial.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicial.Name = "dtFechaInicial";
            this.dtFechaInicial.Size = new System.Drawing.Size(105, 20);
            this.dtFechaInicial.TabIndex = 15;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(195, 508);
            this.dtFechaFinal.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(105, 20);
            this.dtFechaFinal.TabIndex = 16;
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(358, 508);
            this.dtFechaPago.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(105, 20);
            this.dtFechaPago.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nombre Contratista:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Documento:";
            // 
            // txtNombreContratista
            // 
            this.txtNombreContratista.Location = new System.Drawing.Point(133, 409);
            this.txtNombreContratista.Name = "txtNombreContratista";
            this.txtNombreContratista.Size = new System.Drawing.Size(447, 20);
            this.txtNombreContratista.TabIndex = 20;
            // 
            // txtCCcontratista
            // 
            this.txtCCcontratista.Location = new System.Drawing.Point(133, 437);
            this.txtCCcontratista.Name = "txtCCcontratista";
            this.txtCCcontratista.Size = new System.Drawing.Size(90, 20);
            this.txtCCcontratista.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "De:";
            // 
            // txtLugarContratista
            // 
            this.txtLugarContratista.Location = new System.Drawing.Point(252, 437);
            this.txtLugarContratista.Name = "txtLugarContratista";
            this.txtLugarContratista.Size = new System.Drawing.Size(141, 20);
            this.txtLugarContratista.TabIndex = 23;
            // 
            // txtCargoContratista
            // 
            this.txtCargoContratista.Location = new System.Drawing.Point(443, 437);
            this.txtCargoContratista.Name = "txtCargoContratista";
            this.txtCargoContratista.Size = new System.Drawing.Size(137, 20);
            this.txtCargoContratista.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(399, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cargo:";
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(133, 382);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(447, 20);
            this.txtNombreProyecto.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 385);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "PROYECTO:";
            // 
            // txtRepresentanteLegal
            // 
            this.txtRepresentanteLegal.Location = new System.Drawing.Point(136, 323);
            this.txtRepresentanteLegal.Name = "txtRepresentanteLegal";
            this.txtRepresentanteLegal.Size = new System.Drawing.Size(282, 20);
            this.txtRepresentanteLegal.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Representante Legal:";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(490, 323);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(282, 20);
            this.txtSupervisor.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(424, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Supervisor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRepresentanteLegal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCargoContratista);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLugarContratista);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCCcontratista);
            this.Controls.Add(this.txtNombreContratista);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtFechaPago);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtFechaInicial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNombreArchivo);
            this.Controls.Add(this.txtNombreHoja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARCHIVISTICOS GESTION DOCUMENTAL SAS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreHoja;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaInicial;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreContratista;
        private System.Windows.Forms.TextBox txtCCcontratista;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLugarContratista;
        private System.Windows.Forms.TextBox txtCargoContratista;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtRepresentanteLegal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label label17;
    }
}

