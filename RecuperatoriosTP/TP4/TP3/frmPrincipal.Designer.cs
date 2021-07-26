
namespace TP3
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.rbNafta = new System.Windows.Forms.RadioButton();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbElectrico = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockElectrico = new System.Windows.Forms.Label();
            this.lblStockDiesel = new System.Windows.Forms.Label();
            this.lblStockNafta = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTipoModelo = new System.Windows.Forms.Label();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.lstbAutomoviles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.nudCilindrada = new System.Windows.Forms.NumericUpDown();
            this.lstboxColores = new System.Windows.Forms.ListBox();
            this.lblInforme = new System.Windows.Forms.Label();
            this.txtNombreInforme = new System.Windows.Forms.TextBox();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(459, 172);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(619, 221);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(149, 23);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Guardar Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(12, 25);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(42, 13);
            this.lblmodelo.TabIndex = 2;
            this.lblmodelo.Text = "Modelo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(106, 25);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(146, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(106, 51);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(146, 21);
            this.cmbTipo.TabIndex = 6;
            this.cmbTipo.TextChanged += new System.EventHandler(this.cmbTipo_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 120);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            // 
            // rbNafta
            // 
            this.rbNafta.AutoSize = true;
            this.rbNafta.Location = new System.Drawing.Point(27, 41);
            this.rbNafta.Name = "rbNafta";
            this.rbNafta.Size = new System.Drawing.Size(51, 17);
            this.rbNafta.TabIndex = 9;
            this.rbNafta.TabStop = true;
            this.rbNafta.Text = "Nafta";
            this.rbNafta.UseVisualStyleBackColor = true;
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Location = new System.Drawing.Point(27, 95);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(54, 17);
            this.rbDiesel.TabIndex = 10;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diesel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbElectrico
            // 
            this.rbElectrico.AutoSize = true;
            this.rbElectrico.Location = new System.Drawing.Point(27, 150);
            this.rbElectrico.Name = "rbElectrico";
            this.rbElectrico.Size = new System.Drawing.Size(66, 17);
            this.rbElectrico.TabIndex = 11;
            this.rbElectrico.TabStop = true;
            this.rbElectrico.Text = "Electrico";
            this.rbElectrico.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStockElectrico);
            this.groupBox1.Controls.Add(this.lblStockDiesel);
            this.groupBox1.Controls.Add(this.lblStockNafta);
            this.groupBox1.Controls.Add(this.lblMotor);
            this.groupBox1.Controls.Add(this.rbElectrico);
            this.groupBox1.Controls.Add(this.rbDiesel);
            this.groupBox1.Controls.Add(this.rbNafta);
            this.groupBox1.Location = new System.Drawing.Point(283, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lblStockElectrico
            // 
            this.lblStockElectrico.AutoSize = true;
            this.lblStockElectrico.Location = new System.Drawing.Point(24, 178);
            this.lblStockElectrico.Name = "lblStockElectrico";
            this.lblStockElectrico.Size = new System.Drawing.Size(41, 13);
            this.lblStockElectrico.TabIndex = 16;
            this.lblStockElectrico.Text = "Stock: ";
            // 
            // lblStockDiesel
            // 
            this.lblStockDiesel.AutoSize = true;
            this.lblStockDiesel.Location = new System.Drawing.Point(24, 126);
            this.lblStockDiesel.Name = "lblStockDiesel";
            this.lblStockDiesel.Size = new System.Drawing.Size(41, 13);
            this.lblStockDiesel.TabIndex = 15;
            this.lblStockDiesel.Text = "Stock: ";
            // 
            // lblStockNafta
            // 
            this.lblStockNafta.AutoSize = true;
            this.lblStockNafta.Location = new System.Drawing.Point(24, 70);
            this.lblStockNafta.Name = "lblStockNafta";
            this.lblStockNafta.Size = new System.Drawing.Size(41, 13);
            this.lblStockNafta.TabIndex = 14;
            this.lblStockNafta.Text = "Stock: ";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(59, 16);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(34, 13);
            this.lblMotor.TabIndex = 13;
            this.lblMotor.Text = "Motor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cilindrada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTipoModelo);
            this.groupBox2.Controls.Add(this.rbFull);
            this.groupBox2.Controls.Add(this.rbBase);
            this.groupBox2.Location = new System.Drawing.Point(459, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 109);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lblTipoModelo
            // 
            this.lblTipoModelo.AutoSize = true;
            this.lblTipoModelo.Location = new System.Drawing.Point(30, 16);
            this.lblTipoModelo.Name = "lblTipoModelo";
            this.lblTipoModelo.Size = new System.Drawing.Size(66, 13);
            this.lblTipoModelo.TabIndex = 13;
            this.lblTipoModelo.Text = "Tipo Modelo";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(20, 67);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(41, 17);
            this.rbFull.TabIndex = 10;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full";
            this.rbFull.UseVisualStyleBackColor = true;
            // 
            // rbBase
            // 
            this.rbBase.AutoSize = true;
            this.rbBase.Location = new System.Drawing.Point(20, 44);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(49, 17);
            this.rbBase.TabIndex = 9;
            this.rbBase.TabStop = true;
            this.rbBase.Text = "Base";
            this.rbBase.UseVisualStyleBackColor = true;
            // 
            // lstbAutomoviles
            // 
            this.lstbAutomoviles.FormattingEnabled = true;
            this.lstbAutomoviles.Location = new System.Drawing.Point(619, 36);
            this.lstbAutomoviles.Name = "lstbAutomoviles";
            this.lstbAutomoviles.Size = new System.Drawing.Size(289, 134);
            this.lstbAutomoviles.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Automoviles";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(619, 175);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(289, 35);
            this.btnDescripcion.TabIndex = 21;
            this.btnDescripcion.Text = "Descripcion";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            this.btnDescripcion.Click += new System.EventHandler(this.btnDescripcion_Click);
            // 
            // nudCilindrada
            // 
            this.nudCilindrada.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCilindrada.Location = new System.Drawing.Point(106, 80);
            this.nudCilindrada.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCilindrada.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCilindrada.Name = "nudCilindrada";
            this.nudCilindrada.Size = new System.Drawing.Size(146, 20);
            this.nudCilindrada.TabIndex = 22;
            this.nudCilindrada.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lstboxColores
            // 
            this.lstboxColores.FormattingEnabled = true;
            this.lstboxColores.Location = new System.Drawing.Point(106, 115);
            this.lstboxColores.Name = "lstboxColores";
            this.lstboxColores.Size = new System.Drawing.Size(146, 95);
            this.lstboxColores.TabIndex = 24;
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Location = new System.Drawing.Point(353, 227);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(98, 13);
            this.lblInforme.TabIndex = 25;
            this.lblInforme.Text = "Nombre del informe";
            // 
            // txtNombreInforme
            // 
            this.txtNombreInforme.Location = new System.Drawing.Point(457, 224);
            this.txtNombreInforme.Name = "txtNombreInforme";
            this.txtNombreInforme.Size = new System.Drawing.Size(145, 20);
            this.txtNombreInforme.TabIndex = 26;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(459, 124);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(143, 41);
            this.btnAgregarStock.TabIndex = 27;
            this.btnAgregarStock.Text = "Agregar Stock Motores";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(12, 147);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(88, 23);
            this.btnColores.TabIndex = 28;
            this.btnColores.Text = "Cargar colores";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(774, 221);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(134, 23);
            this.btnDB.TabIndex = 29;
            this.btnDB.Text = "Guardar en DB";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 280);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.txtNombreInforme);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lstboxColores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nudCilindrada);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbAutomoviles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblmodelo);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmPrincipal";
            this.Text = "Linea de Produccion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton rbNafta;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbElectrico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTipoModelo;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.ListBox lstbAutomoviles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.NumericUpDown nudCilindrada;
        private System.Windows.Forms.ListBox lstboxColores;
        private System.Windows.Forms.Label lblStockNafta;
        private System.Windows.Forms.Label lblStockElectrico;
        private System.Windows.Forms.Label lblStockDiesel;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.TextBox txtNombreInforme;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnDB;
    }
}

