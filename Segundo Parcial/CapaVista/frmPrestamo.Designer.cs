namespace CapaVista
{
    partial class frmPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.cmbIdTarjeta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertarEncabezado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.cmbIdPelicula = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnInsertarDetalle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbNombrePrestamo = new System.Windows.Forms.ComboBox();
            this.cmbIdPrestamo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "fecha del Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "fecha de Devolución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "identificación";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(182, 119);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 3;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Location = new System.Drawing.Point(182, 168);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dtpDevolucion.TabIndex = 4;
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(182, 222);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(169, 21);
            this.cmbTarjeta.TabIndex = 5;
            this.cmbTarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbTarjeta_SelectedIndexChanged);
            // 
            // cmbIdTarjeta
            // 
            this.cmbIdTarjeta.FormattingEnabled = true;
            this.cmbIdTarjeta.Location = new System.Drawing.Point(357, 222);
            this.cmbIdTarjeta.Name = "cmbIdTarjeta";
            this.cmbIdTarjeta.Size = new System.Drawing.Size(62, 21);
            this.cmbIdTarjeta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prestamos";
            // 
            // btnInsertarEncabezado
            // 
            this.btnInsertarEncabezado.Location = new System.Drawing.Point(646, 150);
            this.btnInsertarEncabezado.Name = "btnInsertarEncabezado";
            this.btnInsertarEncabezado.Size = new System.Drawing.Size(111, 61);
            this.btnInsertarEncabezado.TabIndex = 8;
            this.btnInsertarEncabezado.Text = "Insertar";
            this.btnInsertarEncabezado.UseVisualStyleBackColor = true;
            this.btnInsertarEncabezado.Click += new System.EventHandler(this.btnInsertarEncabezado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(925, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre del Prestamo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIdPrestamo);
            this.groupBox1.Controls.Add(this.cmbNombrePrestamo);
            this.groupBox1.Controls.Add(this.btnInsertarDetalle);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbIdPelicula);
            this.groupBox1.Controls.Add(this.cmbPelicula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(94, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 242);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DetallePrestamo";
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre Prestamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Video a rentar";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(121, 78);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(206, 21);
            this.cmbPelicula.TabIndex = 4;
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);
            // 
            // cmbIdPelicula
            // 
            this.cmbIdPelicula.FormattingEnabled = true;
            this.cmbIdPelicula.Location = new System.Drawing.Point(343, 76);
            this.cmbIdPelicula.Name = "cmbIdPelicula";
            this.cmbIdPelicula.Size = new System.Drawing.Size(57, 21);
            this.cmbIdPelicula.TabIndex = 5;
            this.cmbIdPelicula.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnInsertarDetalle
            // 
            this.btnInsertarDetalle.Location = new System.Drawing.Point(553, 94);
            this.btnInsertarDetalle.Name = "btnInsertarDetalle";
            this.btnInsertarDetalle.Size = new System.Drawing.Size(177, 71);
            this.btnInsertarDetalle.TabIndex = 8;
            this.btnInsertarDetalle.Text = "Insertar";
            this.btnInsertarDetalle.UseVisualStyleBackColor = true;
            this.btnInsertarDetalle.Click += new System.EventHandler(this.btnInsertarDetalle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Detalle del prestamo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(504, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbNombrePrestamo
            // 
            this.cmbNombrePrestamo.FormattingEnabled = true;
            this.cmbNombrePrestamo.Items.AddRange(new object[] {
            "Primer Prestamo",
            "Segundo Prestamo",
            "Tercer Prestamo",
            "Cuarto Prestamo\t"});
            this.cmbNombrePrestamo.Location = new System.Drawing.Point(121, 40);
            this.cmbNombrePrestamo.Name = "cmbNombrePrestamo";
            this.cmbNombrePrestamo.Size = new System.Drawing.Size(204, 21);
            this.cmbNombrePrestamo.TabIndex = 9;
            // 
            // cmbIdPrestamo
            // 
            this.cmbIdPrestamo.FormattingEnabled = true;
            this.cmbIdPrestamo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbIdPrestamo.Location = new System.Drawing.Point(343, 40);
            this.cmbIdPrestamo.Name = "cmbIdPrestamo";
            this.cmbIdPrestamo.Size = new System.Drawing.Size(57, 21);
            this.cmbIdPrestamo.TabIndex = 10;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 699);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertarEncabezado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdTarjeta);
            this.Controls.Add(this.cmbTarjeta);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrestamo";
            this.Text = "t";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.ComboBox cmbIdTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertarEncabezado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIdPelicula;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Button btnInsertarDetalle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbIdPrestamo;
        private System.Windows.Forms.ComboBox cmbNombrePrestamo;
    }
}