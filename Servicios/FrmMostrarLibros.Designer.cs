namespace WindowsFormsAppBiblioteca.Servicios
{
    partial class FrmMostrarLibros
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
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnOrdenarAnio = new System.Windows.Forms.Button();
            this.btnOrdenarTitulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(133, 153);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(316, 150);
            this.dgvLibros.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(257, 95);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(106, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Location = new System.Drawing.Point(403, 95);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnCerrar.Location = new System.Drawing.Point(659, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnOrdenarAnio
            // 
            this.btnOrdenarAnio.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenarAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarAnio.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOrdenarAnio.Location = new System.Drawing.Point(494, 229);
            this.btnOrdenarAnio.Name = "btnOrdenarAnio";
            this.btnOrdenarAnio.Size = new System.Drawing.Size(75, 40);
            this.btnOrdenarAnio.TabIndex = 12;
            this.btnOrdenarAnio.Text = "Ordenar por Año";
            this.btnOrdenarAnio.UseVisualStyleBackColor = false;
            this.btnOrdenarAnio.Click += new System.EventHandler(this.btnOrdenarAnio_Click);
            // 
            // btnOrdenarTitulo
            // 
            this.btnOrdenarTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOrdenarTitulo.Location = new System.Drawing.Point(494, 174);
            this.btnOrdenarTitulo.Name = "btnOrdenarTitulo";
            this.btnOrdenarTitulo.Size = new System.Drawing.Size(75, 40);
            this.btnOrdenarTitulo.TabIndex = 11;
            this.btnOrdenarTitulo.Text = "Ordenar por Titulo";
            this.btnOrdenarTitulo.UseVisualStyleBackColor = false;
            this.btnOrdenarTitulo.Click += new System.EventHandler(this.btnOrdenarTitulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese Titulo o Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mostrar Libros";
            // 
            // FrmMostrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdenarAnio);
            this.Controls.Add(this.btnOrdenarTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvLibros);
            this.Name = "FrmMostrarLibros";
            this.Text = "FrmMostrarLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOrdenarAnio;
        private System.Windows.Forms.Button btnOrdenarTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}