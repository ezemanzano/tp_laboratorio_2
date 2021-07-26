
namespace TP3
{
    partial class frmAgregarStock
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
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.rbNaft = new System.Windows.Forms.RadioButton();
            this.rbDie = new System.Windows.Forms.RadioButton();
            this.rbElectric = new System.Windows.Forms.RadioButton();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(44, 71);
            this.nudCantidad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 0;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Location = new System.Drawing.Point(60, 9);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(104, 13);
            this.lblSeleccione.TabIndex = 1;
            this.lblSeleccione.Text = "Seleccione un motor";
            // 
            // rbNaft
            // 
            this.rbNaft.AutoSize = true;
            this.rbNaft.Location = new System.Drawing.Point(17, 35);
            this.rbNaft.Name = "rbNaft";
            this.rbNaft.Size = new System.Drawing.Size(51, 17);
            this.rbNaft.TabIndex = 2;
            this.rbNaft.TabStop = true;
            this.rbNaft.Text = "Nafta";
            this.rbNaft.UseVisualStyleBackColor = true;
            // 
            // rbDie
            // 
            this.rbDie.AutoSize = true;
            this.rbDie.Location = new System.Drawing.Point(74, 35);
            this.rbDie.Name = "rbDie";
            this.rbDie.Size = new System.Drawing.Size(54, 17);
            this.rbDie.TabIndex = 3;
            this.rbDie.TabStop = true;
            this.rbDie.Text = "Diesel";
            this.rbDie.UseVisualStyleBackColor = true;
            // 
            // rbElectric
            // 
            this.rbElectric.AutoSize = true;
            this.rbElectric.Location = new System.Drawing.Point(131, 35);
            this.rbElectric.Name = "rbElectric";
            this.rbElectric.Size = new System.Drawing.Size(66, 17);
            this.rbElectric.TabIndex = 4;
            this.rbElectric.TabStop = true;
            this.rbElectric.Text = "Electrico";
            this.rbElectric.UseVisualStyleBackColor = true;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(63, 97);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStock.TabIndex = 5;
            this.btnAgregarStock.Text = "Agregar";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(57, 55);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(107, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Ingrese una cantidad";
            // 
            // frmAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 145);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.rbElectric);
            this.Controls.Add(this.rbDie);
            this.Controls.Add(this.rbNaft);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.nudCantidad);
            this.Name = "frmAgregarStock";
            this.Text = "Agregar Stock";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblSeleccione;
        private System.Windows.Forms.RadioButton rbNaft;
        private System.Windows.Forms.RadioButton rbDie;
        private System.Windows.Forms.RadioButton rbElectric;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Label lblCantidad;
    }
}