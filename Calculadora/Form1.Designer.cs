
namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDMes = new System.Windows.Forms.NumericUpDown();
            this.NUDAnio = new System.Windows.Forms.NumericUpDown();
            this.TBPyC = new System.Windows.Forms.TextBox();
            this.TBAyE = new System.Windows.Forms.TextBox();
            this.TBPET = new System.Windows.Forms.TextBox();
            this.DGVMes = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBIDEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.NUDanioRepMen = new System.Windows.Forms.NumericUpDown();
            this.NUDmesRepMen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRepMensual = new System.Windows.Forms.Button();
            this.nudRepAnual = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRepAnual = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.generarRepMen = new System.Windows.Forms.Button();
            this.generarRepAnual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDanioRepMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDmesRepMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepAnual)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calculadora Ambiental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Papel y Cartón";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(607, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aluminio y Electrónicos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(942, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "PET";
            // 
            // NUDMes
            // 
            this.NUDMes.Location = new System.Drawing.Point(738, 117);
            this.NUDMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUDMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDMes.Name = "NUDMes";
            this.NUDMes.Size = new System.Drawing.Size(120, 20);
            this.NUDMes.TabIndex = 6;
            this.NUDMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDAnio
            // 
            this.NUDAnio.Location = new System.Drawing.Point(497, 117);
            this.NUDAnio.Maximum = new decimal(new int[] {
            2123,
            0,
            0,
            0});
            this.NUDAnio.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.NUDAnio.Name = "NUDAnio";
            this.NUDAnio.Size = new System.Drawing.Size(120, 20);
            this.NUDAnio.TabIndex = 7;
            this.NUDAnio.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // TBPyC
            // 
            this.TBPyC.Location = new System.Drawing.Point(425, 199);
            this.TBPyC.Name = "TBPyC";
            this.TBPyC.Size = new System.Drawing.Size(100, 20);
            this.TBPyC.TabIndex = 8;
            // 
            // TBAyE
            // 
            this.TBAyE.Location = new System.Drawing.Point(772, 198);
            this.TBAyE.Name = "TBAyE";
            this.TBAyE.Size = new System.Drawing.Size(100, 20);
            this.TBAyE.TabIndex = 9;
            // 
            // TBPET
            // 
            this.TBPET.Location = new System.Drawing.Point(979, 198);
            this.TBPET.Name = "TBPET";
            this.TBPET.Size = new System.Drawing.Size(100, 20);
            this.TBPET.TabIndex = 10;
            // 
            // DGVMes
            // 
            this.DGVMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMes.Location = new System.Drawing.Point(63, 271);
            this.DGVMes.Name = "DGVMes";
            this.DGVMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMes.Size = new System.Drawing.Size(1143, 150);
            this.DGVMes.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(63, 471);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID";
            // 
            // TBIDEliminar
            // 
            this.TBIDEliminar.Location = new System.Drawing.Point(323, 447);
            this.TBIDEliminar.Name = "TBIDEliminar";
            this.TBIDEliminar.Size = new System.Drawing.Size(100, 20);
            this.TBIDEliminar.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(297, 473);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // NUDanioRepMen
            // 
            this.NUDanioRepMen.Location = new System.Drawing.Point(647, 446);
            this.NUDanioRepMen.Maximum = new decimal(new int[] {
            2123,
            0,
            0,
            0});
            this.NUDanioRepMen.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.NUDanioRepMen.Name = "NUDanioRepMen";
            this.NUDanioRepMen.Size = new System.Drawing.Size(120, 20);
            this.NUDanioRepMen.TabIndex = 19;
            this.NUDanioRepMen.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // NUDmesRepMen
            // 
            this.NUDmesRepMen.Location = new System.Drawing.Point(818, 446);
            this.NUDmesRepMen.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUDmesRepMen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDmesRepMen.Name = "NUDmesRepMen";
            this.NUDmesRepMen.Size = new System.Drawing.Size(120, 20);
            this.NUDmesRepMen.TabIndex = 18;
            this.NUDmesRepMen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(775, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(608, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Año";
            // 
            // btnRepMensual
            // 
            this.btnRepMensual.Location = new System.Drawing.Point(611, 473);
            this.btnRepMensual.Name = "btnRepMensual";
            this.btnRepMensual.Size = new System.Drawing.Size(327, 22);
            this.btnRepMensual.TabIndex = 20;
            this.btnRepMensual.Text = "Reporte Mensual";
            this.btnRepMensual.UseVisualStyleBackColor = true;
            this.btnRepMensual.Click += new System.EventHandler(this.btnRepMensual_Click);
            // 
            // nudRepAnual
            // 
            this.nudRepAnual.Location = new System.Drawing.Point(1086, 445);
            this.nudRepAnual.Maximum = new decimal(new int[] {
            2123,
            0,
            0,
            0});
            this.nudRepAnual.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudRepAnual.Name = "nudRepAnual";
            this.nudRepAnual.Size = new System.Drawing.Size(120, 20);
            this.nudRepAnual.TabIndex = 22;
            this.nudRepAnual.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1047, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Año";
            // 
            // btnRepAnual
            // 
            this.btnRepAnual.Location = new System.Drawing.Point(1051, 471);
            this.btnRepAnual.Name = "btnRepAnual";
            this.btnRepAnual.Size = new System.Drawing.Size(155, 23);
            this.btnRepAnual.TabIndex = 23;
            this.btnRepAnual.Text = "Reporte Anual";
            this.btnRepAnual.UseVisualStyleBackColor = true;
            this.btnRepAnual.Click += new System.EventHandler(this.btnRepAnual_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1082, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "KG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(878, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "KG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(531, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "KG";
            // 
            // generarRepMen
            // 
            this.generarRepMen.Location = new System.Drawing.Point(612, 502);
            this.generarRepMen.Name = "generarRepMen";
            this.generarRepMen.Size = new System.Drawing.Size(326, 23);
            this.generarRepMen.TabIndex = 27;
            this.generarRepMen.Text = "Generar Reporte Mensual";
            this.generarRepMen.UseVisualStyleBackColor = true;
            this.generarRepMen.Click += new System.EventHandler(this.generarRepMen_Click);
            // 
            // generarRepAnual
            // 
            this.generarRepAnual.Location = new System.Drawing.Point(1051, 500);
            this.generarRepAnual.Name = "generarRepAnual";
            this.generarRepAnual.Size = new System.Drawing.Size(155, 23);
            this.generarRepAnual.TabIndex = 28;
            this.generarRepAnual.Text = "Generar Reporte Anual";
            this.generarRepAnual.UseVisualStyleBackColor = true;
            this.generarRepAnual.Click += new System.EventHandler(this.generarRepAnual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 540);
            this.Controls.Add(this.generarRepAnual);
            this.Controls.Add(this.generarRepMen);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRepAnual);
            this.Controls.Add(this.nudRepAnual);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRepMensual);
            this.Controls.Add(this.NUDanioRepMen);
            this.Controls.Add(this.NUDmesRepMen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.TBIDEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVMes);
            this.Controls.Add(this.TBPET);
            this.Controls.Add(this.TBAyE);
            this.Controls.Add(this.TBPyC);
            this.Controls.Add(this.NUDAnio);
            this.Controls.Add(this.NUDMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Ambiental";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDanioRepMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDmesRepMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepAnual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDMes;
        private System.Windows.Forms.NumericUpDown NUDAnio;
        private System.Windows.Forms.TextBox TBPyC;
        private System.Windows.Forms.TextBox TBAyE;
        private System.Windows.Forms.TextBox TBPET;
        private System.Windows.Forms.DataGridView DGVMes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBIDEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown NUDanioRepMen;
        private System.Windows.Forms.NumericUpDown NUDmesRepMen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRepMensual;
        private System.Windows.Forms.NumericUpDown nudRepAnual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRepAnual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button generarRepMen;
        private System.Windows.Forms.Button generarRepAnual;
    }
}

