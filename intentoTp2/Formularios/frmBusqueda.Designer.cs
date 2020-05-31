namespace intentoTp2
{
    partial class frmBusqueda
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(286, 317);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(12, 317);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 35);
            this.txtBuscar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(637, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artículos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMarca);
            this.groupBox1.Controls.Add(this.rbCategoria);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarca.Location = new System.Drawing.Point(20, 168);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(70, 21);
            this.rbMarca.TabIndex = 3;
            this.rbMarca.Text = "MARCA";
            this.rbMarca.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategoria.Location = new System.Drawing.Point(20, 130);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(93, 21);
            this.rbCategoria.TabIndex = 2;
            this.rbCategoria.Text = "CATEGORIA";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(20, 87);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(142, 21);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "NOMBRE ARTICULO";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(20, 44);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(157, 21);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "CODIGO DE ARTICULO";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(409, 69);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(598, 352);
            this.dgvArticulos.TabIndex = 6;
            this.dgvArticulos.DoubleClick += new System.EventHandler(this.dgvArticulos_DoubleClick);
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::intentoTp2.Properties.Resources.fondo_primer_rojo_oscuro_tela_textura_mate_terciopelo_113767_1448;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 451);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 490);
            this.MinimumSize = new System.Drawing.Size(1035, 490);
            this.Name = "frmBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR ARTICULO";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMarca;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}